using BuildingBlocks.CQRS;
using CatalogAPI.Models;

namespace CatalogAPI.Products.CreateProduct
{


    public record CreateProductCommand(string Name, string Description, decimal Price, List<string> Category, string ImageFile) : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // ürün objesini oluştur
            var product = new Product
            {

                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                Category = command.Category,
                ImageFile = command.ImageFile
            };
            // veritabanına kaydet

            // eğer başarılı ise, CreateProductResult döndür
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}

