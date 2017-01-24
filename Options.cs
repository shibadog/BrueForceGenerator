using BrueForceGenerator.CommandLine;

namespace BrueForceGenerator
{
    
    public class Options
    {
        [Option("vaborse", HelpText = "実行の詳細を表示する")]
        public bool Vaborse {get; set;}

        public string GetUsage()
        {
            // ヘッダの設定
            HeadingInfo head = new HeadingInfo("Brue Force Generator", "Version 0.1");
            HelpText help = new HelpText(head);
            help.Copyright = new CopyrightInfo("k_imai_c", 2017);
            help.AddPreOptionsLine("JSON形式で受け取ったパターンを総当たりの組み合わせで返してくれる。");

            // 全オプションを表示(1行間隔)
            help.AdditionalNewLineAfterOption = true;
            help.AddOptions(this);

            return help.ToString();
        }
    }

}
