using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerANACEspecificaçõesOperativas
{
    public class Catcher
    {
        public string GetUrl(HtmlDocument html, string COA)
        {
            var nodes = html.DocumentNode.SelectNodes("//table[preceding-sibling::h2[1][contains(text(), 'RBAC 135')]]//tr[td/a]");
            if(nodes == null)
            {
                throw new Exception("Erro ao encontrar a lista COA's 135.");
            }

            var url = string.Empty;
            foreach (var node in nodes)
            {            
                if (node.ChildNodes[3].InnerText.Equals(COA))
                {
                    url = node.ChildNodes[1].ChildNodes[0].GetAttributeValue("href", "");

                    break;
                }
            }

            return url;  
        }
    }
}