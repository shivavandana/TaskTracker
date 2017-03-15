//author: shivavandana

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace TaskTrackerApp
{
    class FormToXML
    {
        #region Variable Declaration
        XmlDocument xmlDoc = new XmlDocument();        
        XmlElement TaskDetails;
        XmlElement Users,UserTaskDetails;        
        string[] name;
        string[] date;
        string strXMLFilePath = ConfigurationManager.AppSettings["XMLFilePath"];
        #endregion
        public void MainProgram(string userName, string projectType, string projectName,string taskName,string task_Id,string dateTime,string hours,string status)
        {           
            #region Adding user task details to xml         
            name = userName.Split('\\');
            date = dateTime.Split(' ');
            if (!File.Exists(strXMLFilePath))                       
            {
                //create new xml file and update the tak details
                TaskDetails = xmlDoc.CreateElement("TaskDetails");
                UserTaskDetails = LoadUserTaskDeatils(userName, projectType, projectName, taskName, task_Id, dateTime, hours, status);
                TaskDetails.AppendChild(UserTaskDetails);
                xmlDoc.AppendChild(TaskDetails);                
            }
            else
            {
                //Append the task details in the existing xml file.                
                xmlDoc.Load(strXMLFilePath);
                UserTaskDetails = LoadUserTaskDeatils(userName, projectType, projectName, taskName, task_Id, dateTime, hours, status);
                xmlDoc.DocumentElement.AppendChild(UserTaskDetails);
                //xmlDoc.DocumentElement.ReplaceChild(UserTaskDetails,UserTaskDetails);  
            }
            xmlDoc.Save(strXMLFilePath);
           
            return;
            #endregion
        }
        #region Get the user task details
       public XmlElement LoadUserTaskDeatils(string userName, string projectType, string projectName, string taskName,string task_Id, string dateTime, string hours, string status)
       {
           //Adding the <Task> header element
           Users = xmlDoc.CreateElement("Task");

           /*--------------------------------*/
           // Adding <task> and Setting Value 
           XmlElement taskNumElement = xmlDoc.CreateElement("TaskID");
           taskNumElement.InnerText = task_Id;
           Users.AppendChild(taskNumElement);

           //Adding the <name> Element 
           XmlElement usernameElement = xmlDoc.CreateElement("user");
           usernameElement.InnerText = name[1];
           Users.AppendChild(usernameElement);

           // Adding <type> and Setting Value 
           XmlElement typeElement = xmlDoc.CreateElement("type");
           typeElement.InnerText = projectType;
           Users.AppendChild(typeElement);

           // Adding <name> and Setting Value 
           XmlElement nameElement = xmlDoc.CreateElement("name");
           nameElement.InnerText = projectName;
           Users.AppendChild(nameElement);
           

           // Adding <task> and Setting Value 
           XmlElement taskElement = xmlDoc.CreateElement("taskName");
           taskElement.InnerText = taskName;
           Users.AppendChild(taskElement);

           // Adding <date> and Setting Value 
           XmlElement dateElement = xmlDoc.CreateElement("date");
           dateElement.InnerText = date[0];
           Users.AppendChild(dateElement);

           // Adding <hours> and Setting Value 
           XmlElement hourElement = xmlDoc.CreateElement("hours");
           hourElement.InnerText = hours;
           Users.AppendChild(hourElement);

           // Adding <status> and Setting Value 
           XmlElement statusElement = xmlDoc.CreateElement("status");
           statusElement.InnerText = status;
           Users.AppendChild(statusElement);

           return Users;
       }
       #endregion

    }
}
