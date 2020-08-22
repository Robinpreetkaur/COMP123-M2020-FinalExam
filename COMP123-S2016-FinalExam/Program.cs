/*
   Author's name: Robinpreet Kaur
   Author’s student number: 301100296
   Date last Modified: Augusts 21 2020
   Program description: 
       Final test of Programming-2
   Revision History: 
       2020-21-08 : tring to implement splash form
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static SplashForm Splashform;
        public static Character character = new Character();
        public static GenerateNameForm GenerateNameForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Splashform = new SplashForm();

            //it will display splashscreen first
            Application.Run(Splashform);
   
        }
    }
}
