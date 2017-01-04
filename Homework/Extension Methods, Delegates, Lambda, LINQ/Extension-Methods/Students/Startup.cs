using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Startup
    {
        static void Main(string[] args)
        {
            var studentsArr = new List<Students>()
            {
                new Students("Kalin", "Atanasov", 21, 45689 , "02-413-4130", "atanasovv@abv.bg", new List<byte> {
                    5,2,6,6 }, 2),
                new Students("Ivan", "Kostov", 18, 45972, "07-409-3313", "i.kostov@abv.bg",new List<byte> {
                    }, 1),
                new Students("Maya", "Georgieva", 26, 47900, "07-436-5022", "m.georgieva@gmail.com", new List<byte> {
                    },2),
                new Students("Stoyko", "Stoqnov", 17, 43876, "02-285-8624", "ssm_98@gmail.com", new List<byte> { 
                  2,4  }, 1),
                new Students("Pesho", "Goshov", 38, 40002, "05-352-6526", "pe66@abv.bg",new List<byte> {
                   6 }, 2)
            };
        }
    }
}
