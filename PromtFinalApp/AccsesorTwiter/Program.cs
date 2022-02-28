using PromtFinalApp.NewFolder1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwiterAccsessor
{
    internal class Accsesor
    {
        static async Task Main(string[] args)
        {

            await Accsesor_tw.test();
            //    List<dynamic> userNames = new List<dynamic>();
            //    string APIKEY = "DjeaTQPPDHBhcWhYopJTkt1Ad";
            //    string APISECRET = "lvC6Tdrz5v5fTSMbiNxRvdsy0PCujE1hNKilw0gjNRuPPNkBuL";
            //    string APIToken = "AAAAAAAAAAAAAAAAAAAAAGgiYgEAAAAAKuJeA9e0%2FlfX8%2FdMK%2BKpHsO8sag%3DBl4SUxmfoLDZaZBsiNOZNRKKUCPFVz4KDlnSXvFJQgPrepBDtm";
            //    //string APITokenSecret = "";
            //    var userClient = new TwiterClient(APIKEY, APISECRET, APIToken);
            //    var tweetparam = new puplishTweetparamters
            //    {
            //        Text = $"twitter.com #test",

            //    };
        }
        //public static DataTable AllDonationsTable()
        //{

        //    // populate the datagridview- Present donations Table
        //    string selectQuery = " call DisplayAllDonations_procedure(); ";
        //    DataTable table = new DataTable();
        //    var adapter = Connection.Adapter(selectQuery, "PromoIt");
        //    adapter.Fill(table);
        //    return table;
        //}
    }

}
