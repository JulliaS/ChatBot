using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EchoBot3
{
    public class TezTourQuery
    {
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int ContentCountryId { get; set; }
        public DateTime Date { get; set; }
        public int PeopleNumber { get; set; }

        public void SendQuery()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.tez-tour.com/tariffsearch/getResult?callback=jsonp1559634586348&_=1559634592911&locale=ru&cityId=17151&countryId=5732&after=04.06.2019&before=11.06.2019&nightsMin=6&nightsMax=14&hotelClassId=2569&hotelClassBetter=true&rAndBId=2424&rAndBBetter=true&accommodationId=2&children=0&hotelInStop=false&specialInStop=false&noTicketsTo=false&noTicketsFrom=false&tourType=1&version=2&searchTypeId=3&priceMin=0&priceMax=1500000&currency=5561&contentCountryId=1102");//
            request.Method = "Get";
            request.KeepAlive = true;
            request.ContentType = "appication/json";
            request.Headers.Add("Accept", "text / javascript, application / javascript");
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Accept-Language", "uk-UA,uk;q=0.9,ru;q=0.8,en-US;q=0.7,en;q=0.6");
            request.Headers.Add("Host", "www.tez-tour.com");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string myResponse = "";
            using (System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream()))
            {
                myResponse = sr.ReadToEnd();
            }
        }
    }
}
