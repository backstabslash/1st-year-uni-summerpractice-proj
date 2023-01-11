using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using RegisterForm;

namespace prog
{
    [Serializable]
    class Log
    {
        private string condition;
        private string pre_condition;
        private string userLogin;
        public static string UserLogin
        {

            get
            {
                Log log = new Log();
                return log.userLogin;
            }
            set
            {
                Log log = new Log();
                log.userLogin = value;
            }
        }
        public static void AddToLog(string event_name, string pre_condition, string condition)
        {
            XmlDocument xDoc1 = new XmlDocument();
            xDoc1.Load("Log.xml");
            XmlElement xRoot1 = xDoc1.DocumentElement;
            XmlElement eventElem = xDoc1.CreateElement("event");
            XmlElement event_nameElem = xDoc1.CreateElement("event_name");
            XmlElement dateElem = xDoc1.CreateElement("date");
            XmlElement userElem = xDoc1.CreateElement("user");
            XmlElement pre_conditionElem = xDoc1.CreateElement("pre_condition");
            XmlElement conditionElem = xDoc1.CreateElement("condition");

            XmlText event_nameText = xDoc1.CreateTextNode(event_name);
            XmlText dateText = xDoc1.CreateTextNode(Convert.ToString(DateTime.Now));
            XmlText userText = xDoc1.CreateTextNode(MainForm.tBlogin.Text);
            XmlText pre_conditionText = xDoc1.CreateTextNode(pre_condition);
            XmlText conditionText = xDoc1.CreateTextNode(condition);

            event_nameElem.AppendChild(event_nameText);
            dateElem.AppendChild(dateText);
            userElem.AppendChild(userText);
            pre_conditionElem.AppendChild(pre_conditionText);
            conditionElem.AppendChild(conditionText);
            eventElem.AppendChild(event_nameElem);
            eventElem.AppendChild(dateElem);
            eventElem.AppendChild(userElem);
            eventElem.AppendChild(pre_conditionElem);
            eventElem.AppendChild(conditionElem);
            xRoot1.AppendChild(eventElem);
            xDoc1.Save("Log.xml");
        }
    }
}
