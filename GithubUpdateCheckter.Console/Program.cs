namespace GithubUpdateCheckter.Console
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string url = "https://api.github.com/repos/gurrenm3/BloonsTD6-Mod-Helper/releases";
            //string url = "https://api.github.com/repos/TDToolbox/BTD6-Mod-Manager/releases";
            string url = "https://api.github.com/repos/HerpDerpinstine/MelonLoader/releases";
            var updater = new GithubUpdateChecker.Updater(url);
            var releaseInfo = await updater.GetReleaseInfoAsync();

            Console.WriteLine("Got release info");

            Console.WriteLine(releaseInfo.Count);

            Console.WriteLine("Done");
        }
    }
}
