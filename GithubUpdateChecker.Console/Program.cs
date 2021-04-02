namespace GithubUpdateChecker.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Github Update Checker!");

            string url = "https://api.github.com/repos/HerpDerpinstine/MelonLoader/releases";
            var updater = new UpdateChecker(url);
            var releaseInfo = await updater.GetLatestReleaseAsync();
            Console.WriteLine($"Got release info from Gtihub");

            const string currentVersion = "0.2.9";
            Console.WriteLine($"Current Version is: {currentVersion}");
            Console.WriteLine($"Latest Version is: {releaseInfo.TagName}");

            bool isUpdate = updater.IsUpdate(currentVersion, releaseInfo);
            Console.WriteLine($"Is an update avalible: {isUpdate}");

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}