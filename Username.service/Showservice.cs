using System;
using System.Collections.Generic;
using System.Text;
using UsernameAppmodel;

namespace UsernameApp.service
{
    public class Showservice : IShowservice
    {
        public Showservice()
        {
        }

        public string DisplaySalutation(Namecollectormodel model)
        {
            string Display = $"Hi {model.Username}";
            Console.WriteLine("loggin this");
            return Display;
        }

    }
}
