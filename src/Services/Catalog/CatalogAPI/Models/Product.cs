namespace CatalogAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default;

        public List<string> Category { get; set; } = new();

        public string Description { get; set; } = default;

        public string ImageFile { get; set; } = default;

        public decimal Price { get; set; } = default;
    }
}
/** Bu sınıf, ürünlerin temel özelliklerini tanımlar.
 * - Id: Ürünün benzersiz kimliği
 * - Name: Ürünün adı
 * - Category: Ürünün ait olduğu kategoriler
 * - Description: Ürünün açıklaması
 * - ImageFile: Ürünün resim dosyası adı
 * - Price: Ürünün fiyatı
 */