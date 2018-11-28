/*
 *@author: Tushane Mclean 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APA_Reference_App
{
    public class ConnectToNet
    {
       
        private string url;
        private string _dataRecieved;
        
        //defualt constructor 
        public ConnectToNet()
        {
            url = null;
            _dataRecieved = null;
        }

        //an Setter which set the url
        public void SetUrl(string temp_url)
        {
            url = temp_url;
        }

        //an getter to reference the url from outside this script if neeeded
        public string GetUrl()
        {

            return url;

        }

        //function that handles the retrieval of data from the a webpage
        public string GetWebData()
        {
            try
            {
                if (url != null) //checking if the url was entered
                {
                    WebClient gateway = new WebClient(); 
                    Uri uri = new Uri(url); //converting the url to an uri so that the webpage can be connected to 
                    
                    /* an different way to get the data from a webpage
                     * Stream receiver = gateway.OpenRead(uri);
                     StreamReader interpretor = new StreamReader(receiver);
                     string response = interpretor.ReadToEnd().ToString();*/

                    Console.WriteLine("shdsj"); // dumbing statement for testing purposes 
                    string response = gateway.DownloadString(uri);// downloading all the data from the webpage

                    //checking if data was actually received
                    if (response.Equals(null))
                    {
                        response = "It is seemed Data Could not be retrieved from the url " +
                            "you have entered";
                    }

                    Console.WriteLine("Bastard");// dumbing statement for testing purposes 
                    Console.WriteLine(uri);

                    return response; //return the response
                }
            }catch(WebException e)
            {
                Console.WriteLine(e);
                return e.ToString(); // returning any error that came up when requesting the data
            }
            return null;
        }

        

        public async Task GetNewWebData()
        {
            MainScreen c = Program.GetMain(); //getting the current instance of the main screen that was created
            try
            {
                HttpClient _client = new HttpClient();

                Uri _uri = new Uri(Uri.EscapeUriString(url));
                string datagathered = await _client.GetStringAsync(_uri);
                _client.CancelPendingRequests();
               // Console.WriteLine(datagathered);

                c.SetOutput(datagathered);
                //SetOutput(datagathered);

            }catch(WebException e)
            {
                c.SetOutput(e.Message);
            }
        }

    }
}
