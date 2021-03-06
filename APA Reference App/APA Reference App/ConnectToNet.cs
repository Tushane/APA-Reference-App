﻿/*
 *@author: Tushane Mclean 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APA_Reference_App
{
    public class ConnectToNet
    {
       
        private string url;
        private string _dataRecieved;
        private MainScreen c;
        //defualt constructor 
        public ConnectToNet()
        {
            url = null;
            _dataRecieved = null;
            c = Program.GetMain(); //getting the current instance of the main screen that was created

        }

        //an Setter which set the url
        public void SetUrl(string temp_url)
        {
            if (temp_url.StartsWith("https://") || temp_url.StartsWith("http://"))
            {
                url = temp_url;
            }
            else
            {
                c.SetOutput("Please Check your url format it.");
            }
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

        
        //another to get data from a website 
        public async Task GetNewWebData()
        {
            
            try
            {
                c.SetOutput("Getting Data..");
                HttpClient _client = new HttpClient();
                c.SetOutput("Getting Data....");
                Uri _uri = new Uri(Uri.EscapeUriString(url));
                c.SetOutput("Getting Data.........");
                string datagathered = await _client.GetStringAsync(_uri);
                c.SetOutput("Completing Data Collection........");
                _client.CancelPendingRequests();
               // Console.WriteLine(datagathered);

                c.SetOutput(datagathered);
                //SetOutput(datagathered);

            }catch(WebException e)
            {
                c.SetOutput(e.Message);
            }
        }

        //another to get data from a website
        public async Task NewGetWebDatam()
        {
            c.ComponentState(false);
            try
            {
                HttpWebRequest newRequest = (HttpWebRequest)WebRequest.Create(url);
                c.SetState("Requesting Response");
                c.TrackProgress(100);
                Console.WriteLine("Requesting....");
                HttpWebResponse newResponse = (HttpWebResponse)newRequest.GetResponse();
                c.TrackProgress(10);
                c.SetState("Receving a Response");
                Thread.Sleep(100);
                Console.WriteLine("Getting Response....");
                Thread.Sleep(100);
                Stream NewStream = newResponse.GetResponseStream();
                c.TrackProgress(20);
                c.SetState("Encoding the Response");
                Console.WriteLine("Encoding Response....");
                Thread.Sleep(100);
                StreamReader NewReader = new StreamReader(NewStream);
                c.TrackProgress(10);
                c.SetState("Finalizing the Response");
                Console.WriteLine("Finalizing Response....");
                _dataRecieved = await NewReader.ReadToEndAsync();
                c.TrackProgress(20);
                Thread.Sleep(100);
                /*NewReader.Close();
                NewStream.Close();
                newResponse.Close();*/
                c.SetOutput(_dataRecieved);
                c.TrackProgress(20);
                c.SetState("Complete");
                
            }
            catch(WebException e)
            {
                c.SetOutput(e.Message);
            }
            c.ComponentState(true);

        }

    }
}
