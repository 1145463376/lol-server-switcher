using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            Program p = new Program();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                *******  important   ******                ");
            Console.WriteLine("       Make sure League of legend must be ended            ");
            Console.WriteLine("       before this process!!                               ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("       Which server would you like to join ? :)            ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("       [1]: South Korean.                                  ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("       [2]: NorthAmerican.                                 ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("***********************************************************");


            while (true) {
                char c = Console.ReadKey(true).KeyChar;
                if (c == 49) {
                    Console.WriteLine("                                                           ");
                    Console.WriteLine("Processing now.....");
                    Console.WriteLine("                                                           ");
                    p._koreanServer();
                    break;
                } else if (c == 50) {
                    Console.WriteLine("                                                           ");
                    Console.WriteLine("Processing now.....");
                    Console.WriteLine("                                                           ");
                    p._naServer();
                    break;
                } else {
                }
            }
            Console.Read();
        }

        void _koreanServer() {
            var allFiles = Directory.GetFiles("C:\\Riot Games\\League of Legends\\RADS\\projects", "lol.properties", SearchOption.AllDirectories);
            for (int i = 0; i < allFiles.Length; i++) {
                File.WriteAllText(allFiles[i], String.Empty);
                using (StreamWriter file = new StreamWriter(File.OpenWrite(allFiles[1]))) {
                    file.WriteLine("host=prod.kr.lol.riotgames.com,prod.kr.lol.riotgames.com");
                    file.WriteLine("xmpp_server_url=chat.kr.lol.riotgames.com");
                    file.WriteLine("lq_uri=https://lq.kr.lol.riotgames.com");
                    file.WriteLine("rssStatusURLs=null");
                    file.WriteLine("regionTag=kr");
                    file.WriteLine("lobbyLandingURL=http://frontpage.kr.leagueoflegends.com/ko_KR/client/landing");
                    file.WriteLine("featuredGamesURL=http://spectator.kr.lol.riotgames.com:80/observer-mode/rest/featured");
                    file.WriteLine("storyPageURL=http://www.leagueoflegends.co.kr/launcher/journal.php");
                    file.WriteLine("ladderURL=http://www.leagueoflegends.co.kr");
                    file.WriteLine("platformId=KR");
                    file.WriteLine("ekg_uri=https://ekg.riotgames.com");
                    file.WriteLine("riotDataServiceDataSendProbability=1.0");
                }
            }
            Console.WriteLine("Processes have been done. ");
            Console.WriteLine("Let's meet at the Summoner's Rift lol ");
            Console.WriteLine("                                                           ");
        }

        void _naServer() {
            var allFiles = Directory.GetFiles("C:\\Riot Games\\League of Legends\\RADS\\projects", "lol.properties", SearchOption.AllDirectories);
            for (int i = 0; i < allFiles.Length; i++) {
                File.WriteAllText(allFiles[i], String.Empty);
                using (StreamWriter file = new StreamWriter(File.OpenWrite(allFiles[1]))) {
                    file.WriteLine("host=prod.na2.lol.riotgames.com,prod.na2.lol.riotgames.com");
                    file.WriteLine("xmpp_server_url=chat.na2.lol.riotgames.com");
                    file.WriteLine("ladderURL=http://www.leagueoflegends.com/ladders");
                    file.WriteLine("storyPageURL=http://www.leagueoflegends.com/story");
                    file.WriteLine("lq_uri=https://lq.na2.lol.riotgames.com ");
                    file.WriteLine("ekg_uri=https://ekg.riotgames.com");
                    file.WriteLine("regionTag=na");
                    file.WriteLine("rssStatusURLs=null");
                    file.WriteLine("lobbyLandingURL=http://frontpage.na.leagueoflegends.com/$localeCode/client/landing");
                    file.WriteLine("loadModuleChampionDetail=true");
                    file.WriteLine("featuredGamesURL=http://spectator.na1.lol.riotgames.com:80/observer-mode/rest/featured");
                    file.WriteLine("riotDataServiceDataSendProbability=1.0");
                    file.WriteLine("platformId=na1");

                }
            }
            Console.WriteLine("Processes have been done... ");
            Console.WriteLine("Goodbye Hanna.. :( ");
            Console.WriteLine("                                                           ");
        }
    }
}
