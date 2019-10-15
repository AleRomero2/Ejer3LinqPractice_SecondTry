using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            String archivo = File.ReadAllText("Cars.json");
            List<Car> cochesito = JsonConvert.DeserializeObject<List<Car>>(archivo);

        }
        public static string Ej4(List<Car> cochesio)
        {
            var colorCar = cochesio.Where(x => x.color == "Fuscia");
            foreach (var a in colorCar)
            {
                Console.WriteLine("Marca: "+a.maker+" Modelo: "+a.model);
            }
        }
    }
}
