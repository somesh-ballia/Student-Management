using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
        // property for user authonication
        static int check1;
        public static int check
        {
            get
            {
                return check1;

            }
            set
            {

                check1 = value;

            }
        }

        // property for User Name
       static string user;
        public static string UserName
        {
            get
            {
                return user;

            }
            set
            {

                user = value;

            }
        }

        static int LogInfo = 0;
        public static int log
        {
            get
            {
                return LogInfo;

            }
            set
            {

                LogInfo = value;

            }
        }


        static int ChangeDetail = 0;
        public static int Change
        {
            get
            {
                return ChangeDetail;

            }
            set
            {

                ChangeDetail = value;

            }
        }


        static int Log = 0;
        public static int LogData 
        {
            get
            {
                return Log;

            }
            set
            {

                Log = value;

            }
        }
    }
}