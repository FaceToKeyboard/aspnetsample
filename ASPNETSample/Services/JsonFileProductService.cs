using ASPNETSample.Models;
using System.Text.Json;

namespace ASPNETSample.Services
{
    public class JsonFileProductService
    {
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void AddRating(string productId, int newRating)
        {
            IEnumerable<Product>? products = GetProducts();

            // LINQ
            Product oneProduct = products.First(x => x.Id == productId);

            if (oneProduct.Ratings == null)
            {
                oneProduct.Ratings = new int[] { newRating };
            }
            else
            {
                List<int> ratings = oneProduct.Ratings.ToList();
                ratings.Add(newRating);
                oneProduct.Ratings = ratings.ToArray();
            }

            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                Utf8JsonWriter writer = new Utf8JsonWriter( outputStream, new JsonWriterOptions {SkipValidation = true, Indented = true} );
                JsonSerializer.Serialize<IEnumerable<Product>>(writer, products);
            }

        }
    }
}
