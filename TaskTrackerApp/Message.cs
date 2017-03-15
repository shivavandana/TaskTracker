//author: shivavandana

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaskTrackerApp
{
    class Message
    {
        public void message()
        {
            string message = "Data Inserted Successfully...";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            return;
            //ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
    }
}
