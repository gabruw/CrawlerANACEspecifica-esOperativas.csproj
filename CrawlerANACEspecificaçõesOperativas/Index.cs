using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerANACEspecificaçõesOperativas
{
    public class Index
    {
        static void Main(string[] args)
        {
            Navigator newNavigator = new Navigator();

            //Console.WriteLine("Digite o número COA:");
            //Console.Write("->>");

            //var COA = Console.ReadLine();

            var COA = "2010-01-ICNC-02-00";

            var urlCOA = newNavigator.NavPrincipal(COA);
        }
    }
}