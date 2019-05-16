using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerANACEspecificaçõesOperativas
{
    public class Navigator
    {
        public string NavPrincipal(string COA)
        {
            Connect newConnect = new Connect();
            Catcher newCatcher = new Catcher();

            var url = new Uri("http://www.anac.gov.br/assuntos/setor-regulado/empresas/especificacoes-operativas");

            newConnect.CheckStatus(url);
            var html = newConnect.RequestGET(url);

            var urlCOA = newCatcher.GetUrl(html, COA);

            return urlCOA;
        }
    }
}