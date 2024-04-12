using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serealize
{
    internal class Program
    {
        public class cereal
        {
            public string Name { get; set; }
            public string Slogan { get; set; }
            public Boolean ClarkeApproved { get; set; }
            public int Calories { get; set; }
            public decimal price { get; set; }
            public string Picture { get; set; }
        }
        static void Main(string[] args)
        {
            cereal LuckyCharms = new cereal();
            LuckyCharms.Name = "Lucky Charms";
            LuckyCharms.Slogan = "They're magically delicious";
            LuckyCharms.ClarkeApproved = true;
            LuckyCharms.Calories = 1;
            LuckyCharms.price = 15.37M;


            cereal FrostedMinneWheat = new cereal();
            FrostedMinneWheat.Name = "FrostedMinneWheat";
            FrostedMinneWheat.Slogan = "Keeps them full. Keeps them focused";
            FrostedMinneWheat.ClarkeApproved = true;
            FrostedMinneWheat.Calories = 2;
            FrostedMinneWheat.price = 7.76M;

            cereal CinnamonToastCrunch = new cereal();
            CinnamonToastCrunch.Name = "CinnamonToastCrunch";
            CinnamonToastCrunch.Slogan = "Crave Those Crazy Squares";
            CinnamonToastCrunch.ClarkeApproved = true;
            CinnamonToastCrunch.Calories = 3;
            CinnamonToastCrunch.price = 13.65M;


            string JsonString = JsonSerializer.Serialize(FrostedMinneWheat);
            Console.WriteLine(JsonString);

            cereal MiniWheats = new cereal();
            MiniWheats = JsonSerializer.Deserialize<cereal>(JsonString);

            Console.ReadKey();
        }
    }
}
