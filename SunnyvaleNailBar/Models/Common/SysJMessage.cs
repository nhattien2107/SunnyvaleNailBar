using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunnyvaleNailBar.Models
{
    public class SysJMessage
    {
        public class JMessage
        {
            public int ID { get; set; }
            public bool Error { get; set; }
            public string Title { get; set; }
            public Object Object { get; set; }
            public Object Object2 { get; set; }
            public Object Object3 { get; set; }
        }

        public static JMessage Error(bool error, string title)
        {
            JMessage msg = new JMessage();
            msg.Error = true;
            msg.Title = title;
            return msg;
        }

        public static JMessage ErrorV2(string error)
        {
            JMessage msg = new JMessage();
            msg.Error = true;
            msg.Title = error;
            return msg;
        }

        public static JMessage OK_V1(object lst = null, string description = null)
        {
            JMessage msg = new JMessage();
            msg.ID = 1;
            msg.Error = false;
            msg.Title = description;
            msg.Object = lst;
            return msg;
        }
    }
}