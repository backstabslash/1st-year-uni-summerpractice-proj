using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Users
{
    public class User
    {

        public string login;
        private string password;
        private bool isadmin;


        public User()
        {
            login = "";
            password = "";
            isadmin = false;
        }
        public User(string login, string password, bool isadmin)
        {
            this.login = login;
            this.password = password;
            this.isadmin = isadmin;
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public bool Isadmin
        {
            get
            {
                return isadmin;
            }
            set
            {
                isadmin = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public static void SaveInXmlFormat(string login, string password)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("UserList.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement userElem = xDoc.CreateElement("user");
            XmlElement loginElem = xDoc.CreateElement("login");
            XmlElement passwordElem = xDoc.CreateElement("password");
            XmlElement isadminElem = xDoc.CreateElement("admin");
            XmlText loginText = xDoc.CreateTextNode(login);
            XmlText passwordText = xDoc.CreateTextNode(password);
            XmlText isadminText = xDoc.CreateTextNode(Convert.ToString(false));
            loginElem.AppendChild(loginText);
            passwordElem.AppendChild(passwordText);
            isadminElem.AppendChild(isadminText);
            userElem.AppendChild(loginElem);
            userElem.AppendChild(passwordElem);
            userElem.AppendChild(isadminElem);
            xRoot.AppendChild(userElem);
            xDoc.Save("UserList.xml");
        }
        public static void ChangePassword(string login, string password)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("UserList.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                bool loginOK = false;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "login")
                    {
                        if (childnode.InnerText == login)
                        {
                            loginOK = true;
                        }
                    }
                    if (childnode.Name == "password" && loginOK)
                    {
                        childnode.InnerText = password;
                    }
                }
            }
            xdoc.Save("UserList.xml");
        }

        public static bool CheckLoginPassword(string login, string password)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("UserList.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                bool loginOK = false;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "login")
                    {
                        if (childnode.InnerText == login)
                        {
                            loginOK = true;
                        }
                    }
                    if (childnode.Name == "password" && loginOK)
                    {
                        if (childnode.InnerText == password)
                        {
                            return true;
                        }
                    }
                }

            }

            return false;
        }
        public static bool CheckLogin(string login)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("UserList.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "login")
                    {
                        if (childnode.InnerText == login)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public static bool CheckAdmin(string login, string password)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("UserList.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                bool loginOK = false;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "login")
                    {
                        if (childnode.InnerText == login)
                        {
                            loginOK = true;
                        }
                    }
                    if (childnode.Name == "password" && loginOK)
                    {
                        if (childnode.InnerText == password)
                        {
                            loginOK = true;
                        }
                    }
                    if (childnode.Name == "admin" && loginOK)
                    {
                        if (childnode.InnerText == "True")
                        {
                            return true;
                        }
                    }
                }

            }
            return false;
        }
        public static List<User> ShowUsers()
        {
            List<User> users = new List<User>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("UserList.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                User user = new User();
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "login")
                    {
                        user.login = childnode.InnerText;
                    }
                    if (childnode.Name == "password")
                    {
                        user.password = childnode.InnerText;
                    }
                    if (childnode.Name == "admin")
                    {
                        user.isadmin = Convert.ToBoolean(childnode.InnerText);
                    }
                }
                users.Add(user);
            }
            return users;
        }
        public void MakeAdmin(string login, string password)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("UserList.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            bool loginOK = false;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "login")
                    {
                        if (childnode.InnerText == login)
                        {
                            loginOK = true;
                        }
                    }
                    if (childnode.Name == "admin" && loginOK)
                    {
                        childnode.InnerText = "True";
                        loginOK = false;
                    }
                }
            }
            xdoc.Save("UserList.xml");
        }
        public void CancelAdmin(string login, string password)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("UserList.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            bool loginOK = false;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "login")
                    {
                        if (childnode.InnerText == login)
                        {
                            loginOK = true;
                        }
                    }
                    if (childnode.Name == "admin" && loginOK)
                    {
                        childnode.InnerText = "False";
                        loginOK = false;
                    }
                }

            }
            xdoc.Save("UserList.xml");
        }
    }

}