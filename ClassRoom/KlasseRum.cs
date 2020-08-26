using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string NameofClass { get; set; }

        public List<Student> ListOfClass { get; set; }

        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            ListOfClass = new List<Student>();
            SemesterStart = new DateTime();
        }

        public void WhichSeason()
        {
            var resultliste  = 
                this.ListOfClass.GroupBy(x => x.Season())
                .Select(aarstidGroup => new {
                    aarstid = aarstidGroup.Key,
                    countAarstid = aarstidGroup.Count()
                });

            foreach (var item in resultliste)
            {
                Console.WriteLine($"Season: {item.aarstid} Count: {item.countAarstid} ");

            }
        }

    }
}
