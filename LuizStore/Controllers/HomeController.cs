using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LuizStore.Models;

namespace LuizStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = new(){
            new Categoria {Id = 1, Nome = "Smartphones"},
            new Categoria {Id = 2, Nome = "Consoles"}
        };

        List<Produtos> produtos = new List<Produtos>
        {
            new Produtos {
                Id = 1,
                Categoria = categorias[0],
                Nome = "iPhone 14 Pro",
                Descricao = "Apple A16 Bionic, 128GB",
                ValorCusto = 4500.00,
                ValorVenda = 6999.00,
                QtdeEstoque = 10,
                Foto = "/img/produtos/Iphpone 14 pro.webp"
            },

            new Produtos {
                Id = 2,
                Categoria = categorias[0],
                Nome = "Moto G75 5G",
                Descricao = "Motorola , 256GB",
                ValorCusto = 1785.00,
                ValorVenda = 2645.00,
                QtdeEstoque = 18,
                Foto = "/img/produtos/Moto G75 5G.webp"
            },

            new Produtos {
                Id = 3,
                Categoria = categorias[0],
                Nome = " Xiaomi Redmi 14C",
                Descricao = "Xiaomi 6,88 polegadas, 256GB",
                ValorCusto = 1526.00,
                ValorVenda = 2374.00,
                QtdeEstoque = 14,
                Foto = "/img/produtos/Xiaomi Redmi 14C.webp"
            },

            new Produtos {
                Id = 4,
                Categoria = categorias[0],
                Nome = "Samsung Galaxy S24 Ultra",
                Descricao = "Samsung Galaxy S24 Ultra, 256GB",
                ValorCusto = 3600.00,
                ValorVenda = 5129.00,
                QtdeEstoque = 13,
                Foto = "/img/produtos/Samsung Galaxy S24 Ultra.jpg"
            },

            new Produtos {
                Id = 5,
                Categoria = categorias[1],
                Nome = "PlayStation 5",
                Descricao = "Sony, 47 x 44 x 18 cm; 6,32 quilogramas, 500GB",
                ValorCusto = 2900.00,
                ValorVenda = 4699.00,
                QtdeEstoque = 8,
                Foto = "/img/produtos/PS5.jpg"
            },

            new Produtos {
                Id = 6,
                Categoria = categorias[1],
                Nome = "Xbox Series X",
                Descricao = "Microsoft, 4K a 120 FPS, 500GB",
                ValorCusto = 4500.00,
                ValorVenda = 5979.00,
                QtdeEstoque = 10,
                Foto = "/img/produtos/Xbox Series X.jpg"
            },

            new Produtos {
                Id = 7,
                Categoria = categorias[1],
                Nome = "Nintendo Switch",
                Descricao = "Nintendo, Azul Neon e Vermelho Neon, 32GB",
                ValorCusto = 1600.00,
                ValorVenda = 2199.00,
                QtdeEstoque = 13,
                Foto = "/img/produtos/Nintendo Switch.jpg"
            },

            new Produtos {
                Id = 8,
                Categoria = categorias[1],
                Nome = "PlayStation 4 ",
                Descricao = "Sony, 128GB",
                ValorCusto = 1500.00,
                ValorVenda = 2299.00,
                QtdeEstoque = 10,
                Foto = "/img/produtos/Ps4.webp"
            }
        };
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
