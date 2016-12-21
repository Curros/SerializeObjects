using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializeObjects.Classes;
using SerializeObjects.Extensions;

namespace SerializeObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog puppie = new Dog();
            puppie.Name = "Chocolate";
            puppie.BirthDate = Convert.ToDateTime("2015/06/19");

            Dog puppieDesc = new Dog();
            puppieDesc.Name = "White";
            //puppieDesc.BirthDate = Convert.ToDateTime("2016/06/19");  //Want to try null.

            Dog puppieDesc2 = new Dog();
            puppieDesc2.Name = "Black";
            puppieDesc2.PedigreeNumber = 12312323;
            puppieDesc2.BirthDate = Convert.ToDateTime("2016/06/19");  //Want to try null.

            Dog puppieDesc3 = new Dog();
            puppieDesc3.Name = "Brown";
            puppieDesc3.BirthDate = Convert.ToDateTime("2016/06/19");  //Want to try null.

            puppie.AddDescendants(puppieDesc);
            puppie.AddDescendants(puppieDesc2);
            puppie.AddDescendants(puppieDesc3);

            System.Diagnostics.Debug.WriteLine("- Start Exit ----------------");


            System.Diagnostics.Debug.WriteLine("    - XML ----------------");
            var strPuppie = Serialization.SerializeXML(puppie);
            System.Diagnostics.Debug.WriteLine(strPuppie);

            Dog newPuppie = Serialization.DeserializeXML<Dog>(strPuppie);


            System.Diagnostics.Debug.WriteLine("    - JSON ---------------");
            var strJSONPuppie = Serialization.SerializeJson(puppie);
            System.Diagnostics.Debug.WriteLine(strJSONPuppie);

            Dog newPuppieJS = Serialization.DeserializeJson<Dog>(strJSONPuppie);


            System.Diagnostics.Debug.WriteLine("- End Exit ------------------");
        }
    }
}
