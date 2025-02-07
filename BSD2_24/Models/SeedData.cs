using BSD2_24.Data;
using Humanizer;
using Microsoft.EntityFrameworkCore;

namespace BSD2_24.Models
{
    public static class SeedData
    {
        public static void Initalize(IServiceProvider serviceProvider)
        {

            using (var context = new BSD2_24Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BSD2_24Context>>()))
            {
                if (context.Produit.Any())
                {
                    return;
                }

                context.Produit.AddRange(

                    new Produit { 
                        Nom = "LaPizzaDeKoko",
                        DateDeSortie= DateTime.Parse("2015-02-08"),
                        Prix = 7.99M
                    },
                    new Produit { 
                        Nom = "LaDaronneDeKoko",
                        DateDeSortie = DateTime.Parse("1970-05-10"),
                        Prix = 119.99M
                    },
                    new Produit { 
                        Nom = "Koko",
                        DateDeSortie = DateTime.Parse("2005-12-04"),
                        Prix = 999.99M
                    },
                    new Produit { 
                        Nom = "LeDaronDeKoko",
                        DateDeSortie = DateTime.Parse("1969-06-06"),
                        Prix = 449.99M
                    },
                    new Produit { 
                        Nom = "LaSoeurDeKoko",
                        DateDeSortie = DateTime.Parse("2000-09-03"),
                        Prix = 249.99M
                    },
                    new Produit { 
                        Nom = "ChatDeKoko",
                        DateDeSortie = DateTime.Parse("2017-01-11"),
                        Prix = 20M
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
