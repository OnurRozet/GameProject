using System;
using System.Collections.Generic;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Onur", LastName = "Rozet", NationalId = "1111111111", YearOfBirth = new DateTime(1989, 06, 19) } ;
            Gamer gamer2 = new Gamer {  Id = 2, FirstName = "Derya", LastName = "Rozet", NationalId = "222222222", YearOfBirth = new DateTime(1987, 07, 05) } ;
            Gamer gamer3 = new Gamer { Id = 3, FirstName = "Furkan", LastName = "Yilmaz", NationalId = "333333333", YearOfBirth = new DateTime(2006, 01, 28) } ;
            Gamer gamer4 = new Gamer { Id = 4, FirstName = "Kerem", LastName = "Yilmaz", NationalId = "444444444", YearOfBirth = new DateTime(2010, 07, 27) } ;
            Gamer gamer5 = new Gamer {Id = 5, FirstName = "Mehmet", LastName = "Bayrak", NationalId = "555555555", YearOfBirth = new DateTime(1991, 06, 05) } ;


            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer3);
            gamerManager.Add(gamer4);
            gamerManager.Add(gamer5);


            Console.WriteLine("------------------------------------");

            Game game1 = new Game { GameID = 1, CategoryId = 1, GameName = "Fifa 2020", UnitInStock = 10, UnitPrice = 200 };
            Game game2 = new Game { GameID = 2, CategoryId = 2, GameName = "Last Of Us", UnitInStock = 14, UnitPrice = 100 };
            Game game3 = new Game { GameID = 3, CategoryId = 2, GameName = "Uncharted", UnitInStock = 10, UnitPrice = 50 };
            Game game4 = new Game { GameID = 4, CategoryId = 3, GameName = "Sims", UnitInStock = 22, UnitPrice = 1500 };

            Console.WriteLine("{0} oyunu satisa sunuldu ",game1.GameName);
            Console.WriteLine("{0} oyunu satisa sunuldu ",game2.GameName);
            Console.WriteLine("{0} oyunu satisa sunuldu ",game3.GameName);
            Console.WriteLine("{0} oyunu satisa sunuldu ",game4.GameName);

            Console.WriteLine("----------------------------------");

            Campaign campaign1 = new Campaign { CampaignName = "Yaz Tatili Kampanyasi" , CampaignRate=50};
            Campaign campaign2 = new Campaign { CampaignName = "Somestir Kampanyasi" , CampaignRate=25};

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("----------------------------------");

            Console.WriteLine("{0} oyununa {1} kampanyasi uygunlandi. Oyun fiyat {2} TL indirimli fiyat {3} TL ",game2.GameName,campaign1.CampaignName,game2.UnitPrice,Campaign.CampaignResult(campaign1,game2));
            Console.WriteLine("{0} oyununa {1} kampanyasi uygunlandi. Oyun fiyat {2} TL indirimli fiyat {3} TL ",game1.GameName,campaign1.CampaignName,game1.UnitPrice,Campaign.CampaignResult(campaign1,game1));

            GameManager gameManager = new GameManager();
            gameManager.Sale(gamer1, game1);
            gameManager.Sale(gamer2, game2);


        }
    }
}
