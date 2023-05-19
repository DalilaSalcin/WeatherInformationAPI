using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace WeatherInfoAPI.Controllers
{
    
    public class WeatherController : Controller
    {

        public static void WriteLog(string msg)
        {

            string logFile = "WeatherAPI_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            string logDest = "C:/WeatherAPIFolder1/" + logFile;


            System.IO.StreamWriter sw = System.IO.File.AppendText(logDest);
            try
            {
                string logLine = System.String.Format(
                    "{0:G}: {1}.", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
        // GET: Weather
        public String Index()
        {
            return "Weather APIs";
        }


        // GET: Weather/current
       
        [Route("Weather/current?city=Sarajevo")]
        [HttpGet]
        public String current(String city)
        {
            String resultString="Poziv";
          
            try
            {
                Console.WriteLine("Test!");
                WriteLog("City: " + city);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=6ecff6f8713f7ce8ba802a3b5424975a");

                httpWebRequest.Headers.Add("appid", "6ecff6f8713f7ce8ba802a3b5424975a");
                httpWebRequest.Method = "GET";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    resultString = streamReader.ReadToEnd();
                    WriteLog("resultString: " + resultString);
                   
                }

              
            }
            catch (Exception e)
            {
                WriteLog("Deserijalizacija neispravna!" + e.ToString());
                resultString = e.ToString();
            }
           
            return resultString;
        }


    }
}
