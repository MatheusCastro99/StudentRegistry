using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry.Components
{
    public class SessionContext //Stores some basic Session Information
    {
        public string CurrentUsername { get; set; } = "";
        public DateTime SessionStart { get; set; }

        public SessionContext(string username) 
        {
            CurrentUsername = username;
            SessionStart = DateTime.Now;
        }

        public SessionContext() { }
    }
}
