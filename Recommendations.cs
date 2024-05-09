using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToreBrew
{
    public class Recommendations
    {
        const string COMMON = "Common";
        public Recommendations()
        {

        }
        public List<CoffeeRecipe> CoffeeRecipes
        {
            get
            {

                var coffeeRecipes = new List<CoffeeRecipe>
            {
                new CoffeeRecipe
                {
                    Zodiac = "Aries",
                    FavorCoffee = "Cappuccino",
                    Name = "Arino",
                    Description = "Arino is a coffee drink that is made with espresso, steamed milk, and milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso, \n1/3 cup of steamed milk, \n1/3 cup of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso. \n4. Top with milk foam.",
                    ImagePath = "assets\\coffee\\Arino.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Aries",
                    FavorCoffee = "Latte",
                    Name = "Saggo",
                    Description = "Saggo is a coffee drink that is made with espresso and a scoop of vanilla ice cream. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso, \n1 scoop of vanilla ice cream",
                    Instructions = "1. Brew a shot of espresso. \n2. Scoop the vanilla ice cream into a cup. \n3. Pour the espresso over the ice cream.",
                    ImagePath = "assets\\coffee\\Saggo.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Aries",
                    FavorCoffee = "Black",
                    Name = "Ariano",
                    Description = "Ariano is a coffee drink that is made with espresso and a dollop of milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n a dollop of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Top with a dollop of milk foam.",
                    ImagePath = "assets\\coffee\\Ariano.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Taurus",
                    FavorCoffee = "Latte",
                    Name = "Latrus",
                    Description = "Latrus is a coffee drink that is made with espresso and steamed milk. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso, 1/2 cup of steamed milk",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso.",
                    ImagePath = "assets\\coffee\\Latrus.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Taurus",
                    FavorCoffee = "Cappuccino",
                    Name = "Caprus",
                    Description = "Caprus is a coffee drink that is made with espresso, steamed milk, and milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n 1/3 cup of steamed milk, \n1/3 cup of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso. \n4. Top with milk foam.",
                    ImagePath = "assets\\coffee\\Caprus.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Taurus",
                    FavorCoffee = "Black",
                    Name = "Taurado",
                    Description = "Taurado is a coffee drink that is made with espresso and a dollop of milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n a dollop of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Top with a dollop of milk foam.",
                    ImagePath = "assets\\coffee\\Taurado.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Gemini",
                    FavorCoffee = "Latte",
                    Name = "Gemini",
                    Description = "Gemini is a coffee drink that is made with espresso and steamed milk. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n 1/2 cup of steamed milk",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso.",
                    ImagePath = "assets\\coffee\\Gemini.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Gemini",
                    FavorCoffee = "Cappuccino",
                    Name = "Gemuccino",
                    Description = "Gemuccino is a coffee drink that is made with espresso, steamed milk, and milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n 1/3 cup of steamed milk,\n 1/3 cup of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso. \n4. Top with milk foam.",
                    ImagePath = "assets\\coffee\\Gemuccino.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Gemini",
                    FavorCoffee = "Black",
                    Name = "Gemado",
                    Description = "Gemado is a coffee drink that is made with espresso and a dollop of milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso, \na dollop of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Top with a dollop of milk foam.",
                    ImagePath="assets\\coffee\\Gemado.jfif"    
                },
                new CoffeeRecipe
                {
                    Zodiac = "Gemini",
                    FavorCoffee = "Mocha",
                    Name = "Gemcha",
                    Description = "Gemcha is a coffee drink that is made with espresso, steamed milk, and chocolate. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n 1/2 cup of steamed milk, \n2 tablespoons of chocolate syrup",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Add the chocolate syrup to the espresso. \n4. Pour the steamed milk into the espresso.",
                    ImagePath = "assets\\coffee\\Gemcha.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Cancer",
                    FavorCoffee = "Americano",
                    Name = "Caricano",
                    Description ="Caricano is a coffee drink that is made with espresso and hot water. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n 1/2 cup of hot water",
                    Instructions = "\n1. Brew a shot of espresso. \n2. Add the hot water to the espresso.",
                    ImagePath = "assets\\coffee\\Caricano.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Leo",
                    FavorCoffee = "Espresso",
                    Name = "Leosso",
                    Description = "Leosso is a coffee drink that is made with espresso. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso",
                    Instructions = "1. Brew a shot of espresso.",
                    ImagePath = "assets\\coffee\\Leosso.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Virgo",
                    FavorCoffee = "Cortado",
                    Name = "Virdo",
                    Description = "Virdo is a coffee drink that is made with espresso and steamed milk. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n 1/4 cup of steamed milk",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso.",
                    ImagePath = "assets\\coffee\\Virdo.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Libra",
                    FavorCoffee = "Irish",
                    Name = "Libro",
                    Description = "Libro is a coffee drink that is made with espresso and steamed milk. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso,\n 1/3 cup of steamed milk",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso.",
                    ImagePath = "assets\\coffee\\Libro.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Scorpio",
                    FavorCoffee = "Black",
                    Name = "Scorchiato",
                    Description = "Scorchiato is a coffee drink that is made with espresso and a dollop of milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso, \na dollop of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Top with a dollop of milk foam.",
                    ImagePath = "assets\\coffee\\Scorchiato.jfif"
                },
                
                new CoffeeRecipe
                {
                    Zodiac = "Taurus",
                    FavorCoffee = "Cappuccino",
                    Name = "Capriccino",
                    Description = "Capriccino is a coffee drink that is made with espresso, steamed milk, and milk foam. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 shot of espresso, \n1/3 cup of steamed milk, \n1/3 cup of milk foam",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Pour the steamed milk into the espresso. \n4. Top with milk foam.",
                    ImagePath = "assets\\coffee\\Capriccino.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Gemini",
                    FavorCoffee = "Mocha",
                    Name = "Gemocha",
                    Description = "Gemocha",
                    Ingredients = "1 shot of espresso,\n 1/2 cup of steamed milk,\n 2 tablespoons of chocolate syrup",
                    Instructions = "1. Brew a shot of espresso. \n2. Steam the milk. \n3. Add the chocolate syrup to the espresso. \n4. Pour the steamed milk into the espresso.",
                    ImagePath = "assets\\coffee\\Gemocha.jfif"
                },
                new CoffeeRecipe
                {
                    Zodiac = "Common",
                    FavorCoffee = "Common",
                    Name = "Capricoffee",
                    Description = "Capricoffee is a coffee drink that is made with finely ground coffee beans and water. It is a popular coffee drink that is enjoyed by many people around the world.",
                    Ingredients = "1 tablespoon of finely ground coffee beans,\n 1 cup of water",
                    Instructions = "1. Add the coffee beans and water to a pot. \n2. Bring to a boil. \n3. Simmer for 5 minutes. \n4. Pour into a cup.",
                    ImagePath = "assets\\coffee\\Capricoffee.jfif"
                },
            };
                return coffeeRecipes;
            }
        }

        public CoffeeRecipe? GetCoffeeRecipe(string favorCoffee, string zodiac)
        {
            var coffeeRecipe = CoffeeRecipes.FirstOrDefault(x => (x.Zodiac.Equals(zodiac) && x.FavorCoffee.Equals(favorCoffee)) || x.Zodiac.Equals(COMMON));
            return coffeeRecipe;
        }


    }
    public class CoffeeRecipe
    {
        public string Zodiac { get; set; }
        public string FavorCoffee { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string ImagePath { get; set; }
        
    }
}
