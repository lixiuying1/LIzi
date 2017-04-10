using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlSearch = "select * from Myschool1";
            List<Userinfo> re = DBHelper.Query<Userinfo>(sqlSearch, sdr =>
            {
                Userinfo p = new Userinfo();
                p.ID = (int)sdr["ID"];
                p.Namw = sdr["Namw"].ToString();

                return p;
            });
            foreach (var item in re)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Namw);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
