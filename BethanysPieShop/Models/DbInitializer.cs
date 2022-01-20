using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Pies.Any())
            {
                context.AddRange(

                    new Pie { Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "This Apple Pie Recipe combines the sweet and tender flavors of baked apples with a deliciously flaky pie crust. Apple pie with ice cream is one of my favorite desserts, and it couldn’t be easier to make homemade!", IsPieOfTheWeek = true, ImageUrl = "https://mediacdn.grabone.co.nz/asset/wIu0cJQnDp/box=970x0", ImageThumbnailUrl = "https://mediacdn.grabone.co.nz/asset/wIu0cJQnDp/box=970x0" },
                    new Pie { Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "This Lemon Blueberry Cheesecake is thick, creamy and flavored with tangy lemon and blueberries throughout. It sits in a graham cracker crust and is topped with a homemade blueberry sauce.", IsPieOfTheWeek = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR586B9Lxdzr6uaFtEt62-I8_MCzJoIp8bkwsaUxd591Dh4LnjNKA", ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR586B9Lxdzr6uaFtEt62-I8_MCzJoIp8bkwsaUxd591Dh4LnjNKA" },
                    new Pie { Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "This is a classic New York style cheesecake with a graham cracker crust and high sides. It is dense, rich, and light at the same time, and serves a small army.", IsPieOfTheWeek = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTHedxW6labnKn72Y27BtoXh4eaul5H2f0Nlsce11NoM4vsKsvn7g", ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTHedxW6labnKn72Y27BtoXh4eaul5H2f0Nlsce11NoM4vsKsvn7g" },
                    new Pie { Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "This ruby-red cherry pie is just sweet enough, with a hint of almond flavor and a good level of cinnamon. The cherries peeking out of the lattice crust makes it so pretty, too. I like to make a few of these cherry pies throughout the summer.", IsPieOfTheWeek = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDzZPeD9RCN600-hxZiNT8xRxJKNlHe8yqXH-hu0HDUWwDGAv4", ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDzZPeD9RCN600-hxZiNT8xRxJKNlHe8yqXH-hu0HDUWwDGAv4" },
                    new Pie { Name = "Vanilla Cream Pie", Price = 13.95M, ShortDescription = "The classic-est of them all!", LongDescription = "Creamy vanilla filling topped with sweet meringue creates an unbeatable combination in this tasty pie.", IsPieOfTheWeek = false, ImageUrl = "https://images-gmi-pmc.edge-generalmills.com/3e38492d-1ec4-4cba-8903-758c7eb10a4c.jpg", ImageThumbnailUrl = "https://images-gmi-pmc.edge-generalmills.com/3e38492d-1ec4-4cba-8903-758c7eb10a4c.jpg" },
                    new Pie { Name = "Chocolate Rum Pie", Price = 15.95M, ShortDescription = "Chocolate goodness!", LongDescription = "If you love chocolate cream pie, you've got to try this! Adding whipped cream and rum makes it even richer than the standard version!", IsPieOfTheWeek = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk22tJogsLHDtA9YjUKJnO8dbFX5W9hghK6GG_Jy1GOW9Kppze6A", ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk22tJogsLHDtA9YjUKJnO8dbFX5W9hghK6GG_Jy1GOW9Kppze6A" }


                );

                context.SaveChanges();

            }
        }
    }
}
