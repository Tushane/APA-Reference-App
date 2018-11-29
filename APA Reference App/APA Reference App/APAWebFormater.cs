/*@author: Tushane Mclean
 * Date Created: Novemeber 29, 2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APA_Reference_App
{
    public class APAWebFormater
    {

        private string finaloutput;
        private DateTime Date;

        //defualt constructor
        public APAWebFormater()
        {
            finaloutput = null;
            Date = new DateTime().Date;
        }

        //function that handles the formating the reference
        public void Formating(string DatePublished, string AuthorName, string Article_Title)
        {
          

        }

        //getter to get the final formated output 
        public string GetFinalOutput()
        {
            return finaloutput;
        }

    }
}
