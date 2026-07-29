using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry.Components
{
    public class SessionContext //Stores some basic Session Information
    {
        public string CurrentUsername { get; set; } = "";
        public string CurrentFirstName { get; set; } = "";
        public DateTime SessionStart { get; set; }

        public SessionContext(string username, string firstName) 
        {
            CurrentFirstName = firstName;
            CurrentUsername = username;
            SessionStart = DateTime.Now;
        }

        public SessionContext() { }
    }
}
