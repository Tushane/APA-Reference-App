/*
 *@author: Tushane Mclean 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APA_Reference_App
{
    public class ConnectToNet
    {
       
        private string url;
        private string _dataRecieved;
        
        public ConnectToNet()
        {
            url = null;
            _dataRecieved = null;
        }

        public void SetUrl(string temp_url)
        {
            url = temp_url;
        }

        public string GetUrl()
        {

            return url;

        }

        public string GetWebData()
        {
            try
            {
                if (url != null)
                {
                    WebClient gateway = new WebClient();
                    Uri uri = new Uri(url);
                    /* Stream receiver = gateway.OpenRead(uri);
                     StreamReader interpretor = new StreamReader(receiver);
                     string response = interpretor.ReadToEnd().ToString();*/
                    Console.WriteLine("shdsj");
                    string response = gateway.DownloadString(uri);
                    if (response.Equals(null))
                    {
                        response = "It is seemed Data Could not be retrieved from the url " +
                            "you have entered";
                    }
                    Console.WriteLine("Bastard");
                    Console.WriteLine(uri);
                    return response;
                }
            }catch(WebException e)
            {
                Console.WriteLine(e);
                return e.ToString();
            }
            return null;
        }

    }
}
