using AmazingGeekShop.API.APIModels;
using AmazingGeekShop.Application.Adapter;
using AmazingGeekShop.Domain.Entities;
using FluentAssertions;

namespace AmazingGeekStore.Tests.Application.Adapters;

public class ObjectAdapterTest
{
    
    [Fact]
    public void RetornarTTargetComSucesso()
    {
        var sut = new ObjectAdapter<ProductViewModel, Product>();
        var input = new ProductViewModel()
        {
            Id = Guid.NewGuid(),
            Description = "TESTE DESCRIÇÃO",
            CategoryName = "TESTE CATEGORIA",
            ImageURL = "TESTE IMAGE URL",
            Name = "TESTE NOME",
            Price = 10.0M
        };
        var target = new Product();
        var res = sut.MapToTarget(input);

        res.Should().BeOfType<Product>();

    }
    
}