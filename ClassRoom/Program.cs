using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 3
            var klasserum = new KlasseRum();
            klasserum.NameofClass = "Zealand-3";
            klasserum.SemesterStart = new DateTime(2019, 1, 1);
            klasserum.ListOfClass.Add(new Student("Hans", 5, 7));
            klasserum.ListOfClass.Add(new Student("Grete", 3, 20));
            klasserum.ListOfClass.Add(new Student("Bo", 10, 1));
            //klasserum.Klasseliste.Add(new studerende("Svend", 14, 1)); //fejl i måned
            klasserum.ListOfClass.Add(new Student("Grete1", 3, 1));
            klasserum.ListOfClass.Add(new Student("Grete2", 3, 2));
            klasserum.ListOfClass.Add(new Student("Grete3", 3, 3));
            klasserum.ListOfClass.Add(new Student("Grete4", 3, 4));
            klasserum.ListOfClass.Add(new Student("Bo1", 10, 1));
            klasserum.ListOfClass.Add(new Student("Bo2", 10, 2));
            klasserum.ListOfClass.Add(new Student("Bo3", 10, 3));
            klasserum.ListOfClass.Add(new Student("Bo4", 10, 4));
            klasserum.ListOfClass.Add(new Student("Bo5", 10, 5));

            //opgave 4, udskriv oplysningerne
            Console.WriteLine($"Klassenavn : {klasserum.NameofClass}");
            Console.WriteLine($"Semesterstart : {klasserum.SemesterStart}");
            foreach (var studerende in klasserum.ListOfClass)
            {
                //Obs. jeg bruger en overide på tostring() metoden i studerende klasse
                //for at udskrive disse oplysninger
                Console.WriteLine(studerende.ToString());
            }

            klasserum.WhichSeason();

        }
    }
}
