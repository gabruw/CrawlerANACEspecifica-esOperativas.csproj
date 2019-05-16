using HtmlAgilityPack;

namespace CrawlerANACEspecificaçõesOperativas
{
    public class FormUtils
    {
        public HtmlDocument ParserHtmlDocument(string html)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            return htmlDoc;
        }
    }
}