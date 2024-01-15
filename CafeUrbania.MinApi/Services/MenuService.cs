

using CafeUrbania.MinApi.Services.Interfaces;
using CafeUrbania.Models;

namespace CafeUrbania.MinApi.Services;

public class MenuService : IMenuService
{
    public List<MenuItem> GetMenuItems()
    {
        return new List<MenuItem>() {
            new MenuItem()
            {
                Id = 6,
                Name = "Gâteau noir & blanc",
                ShortDescription = "Couleurs opposées, saveurs complémentaires.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/layer-cake.png",
                Price = 9,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Macaroons",
                ShortDescription = "Vous croyez être mort et arrivé au paradis.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/macaroon.png",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Caramel Mocha",
                ShortDescription = "Le mélange parfait de saveurs riches.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/mocha.png",
                Price = 4,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Thé citron lavande",
                ShortDescription = "Une explosion de saveur rafraîchissante à chaque lampée.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/lemon-tea.png",
                Price = 4,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Espresso Micro",
                ShortDescription = "Petit format, violent en caféine.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/micro-espresso.png",
                Price = 9,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Frites sans fond",
                ShortDescription = "Commandez ces croustillantes comme accompagnement ou... plat principal.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/fries.png",
                Price = 7,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Burger à la dinde",
                ShortDescription = "Une délicieuse option de lunch santé.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/burger.png",
                Price = 12,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Douce crêpe",
                ShortDescription = "Crumble de biscuits, crème pâtissière... tout est là.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/crepe-sweet.png",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Crêpe Savory",
                ShortDescription = "Saveurs riches présentées comme une oeuvre d'art.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/crepe-savory.png",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Coquille déjeuner",
                ShortDescription = "Chaque parcelle de ce plat vous laisse un goût sublime.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/breakfast-taco.png",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Déjeuner Burrito",
                ShortDescription = "Un petit-déjeuner copieux et plein de saveurs.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/breakfast-burrito.png",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Red Velvet",
                ShortDescription = "Le Red Velvet est finalement arrivé.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/cake.jpg",
                Price = 6,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Caramel salé gâteau chocolat",
                ShortDescription = "Super sucré, légèrement salé.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/cake-brown.jpg",
                Price = 7,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Gourmet Cupcakes",
                ShortDescription = "La saveur d'un gâteau entier.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/cupcakes.jpg",
                Price = 6,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Salade maison poulet",
                ShortDescription = "Une salade légère avec notre incroyable poulet grillé.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/salad-chicken.png",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Salade César",
                ShortDescription = "Un lunch léger et parfait.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/salad-house.jpg",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Salade branchée",
                ShortDescription = "Ingredients uniques, faveurs croisées.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/salad-special.jpg",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Charcuterie",
                ShortDescription = "Nourriture pour les amis.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/charcuterie.jpg",
                Price = 8,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Chausson aux pommes",
                ShortDescription = "Légé en calorie et belle texture, chargé en saveur.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/applefritter.jpg",
                Price = 6,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Cupcake",
                ShortDescription = "Cupcakes vanille avec le niveau parfait de douceur.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/cupcake-pair.png",
                Price = 4,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Bruine de baies à la guimauve",
                ShortDescription = "La simplicité est la sophistication ultime.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/berry-drizzle.jpg",
                Price = 4,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Muffin",
                ShortDescription = "Un muffin aux pépites de chocolat fraîchement sorti du four - la façon idéale de commencer un lundi matin.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/muffin.png",
                Price = 3,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 6,
                Name = "Bouchées chocolatées",
                ShortDescription = "Des bouchées de chocolat riches et sucrées pour ceux qui ont besoin d'une gâterie spéciale.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/chocolate.png",
                Price = 5,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 1,
                Name = "Pain à la citrouille légèrement givré",
                Slug = "pumpkin-bread",
                ShortDescription = "Un délice saisonnier que nous proposons chaque automne. Pain à la citrouille avec juste un peu d'épices, glaçage au fromage à la crème avec juste un soupçon de maison.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/pumpkinbread.png",
                Price = 4,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Granola et noix",
                ShortDescription = "Ce n’est pas tape-à-l’œil, mais c’est certainement sain. Parfait lorsque vous avez besoin de calories, mais pas de culpabilité.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/granola.png",
                Price = 3,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 4,
                Name = "Biscuits brisures de chocolat",
                ShortDescription = "Ils sont préparés frais tous les jours et ils en ont le goût.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/cookies.png",
                Price = 2,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 5,
                Name = "Bagels frais frais frais",
                ShortDescription = "Ils sont aussi ronds que des beignets, mais bien plus sains ! Fraîchement préparé chaque matin avant le lever du soleil.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/bagel.png",
                Price = 5,
                Category = "Food"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Designer Espresso",
                ShortDescription = "La caféine n’a jamais été aussi puissante.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/design.png",
                Price = 6.5M,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Thé vert Matcha",
                ShortDescription = "Pour une introduction en douceur à la caféine.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/matcha.jpg",
                Price = 3.5M,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Mocha Latte",
                ShortDescription = "Saveur de chocolat noir dans le café infusé noir.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/iced-mocha.jpg",
                Price = 3.5M,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Bière secret",
                ShortDescription = "Qu'est-ce que c'est? Vous devrez l'essayer pour le savoir.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/latte.jpg",
                Price = 3.5M,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Thé glacé à la fraise",
                ShortDescription = "Un mélange parfait de saveur et de cafféine.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/raspberry-tea.jpg",
                Price = 3.5M,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 1,
                Name = "Café noir infusé",
                Slug = "dark-brew",
                ShortDescription = "Un original classique et rafraîchissant.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/ground.png",
                Price = 2,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Latté",
                ShortDescription = "Plus que du café, mais toujours du café.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/cappucino.png",
                Price = 3,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 2,
                Name = "Americano",
                Slug = "ground-coffee",
                ShortDescription = "Toujours classique, mais un peu plus sophistiqué.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/beans.jpg",
                Price = 3.5M,
                Category = "Coffee"
            },
            new MenuItem()
            {
                Id = 3,
                Name = "Cappuccino",
                ShortDescription = "Riche et mousseux, c’est le café réconfortant parfait.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "images/menu/cup.png",
                Price = 4.5M,
                Category = "Coffee"
            }
        };
    }
}
