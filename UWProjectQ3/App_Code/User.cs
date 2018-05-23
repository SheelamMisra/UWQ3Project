using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


/// <summary>
/// Summary description for User
/// </summary>
namespace UWProjectQ3
{
    public class User
    {

        public string UserName { get; private set; }
        public string UserLogin { get; set; }
        public int StudentId { get; set; }
        public string Password { get; private set; }
        public string ReasonForRequestingUser { get; private set; }
        public string Email { get; private set; }

        public Dictionary<int, Clss> RegisteredClasses; 
        
        public User(string _userName, string _userId, string _userEmail, string _reasonForRequest)
        {
            UserName = _userName;
            UserLogin = _userId;
            Email = _userEmail;
            ReasonForRequestingUser = _reasonForRequest;
        }
        public User(string _userLogin, string _pass)
        {
            UserLogin = _userLogin;
            Password = _pass;
            RegisteredClasses = new Dictionary<int, Clss>();
        }
        public User(){}
        public User(string _userLogin, int _studentId)
        {
            UserLogin = _userLogin;
            StudentId = _studentId;
            RegisteredClasses = new Dictionary<int, Clss>();
        }
        public void StoreUserCredentialsInFile()
        {
            string currDir = @"C:\_CSharpCert\";
            string fileName = "UserInfo.txt";
            string filePath = currDir + fileName;

            if (!(File.Exists(filePath)))
            {
                File.Create(filePath);
            }

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("User Name: " + UserName);
                sw.WriteLine("User Email: " + Email);
                sw.WriteLine("User Id: " + UserLogin);
                sw.WriteLine("Reason for requesting access: " + ReasonForRequestingUser);
                sw.WriteLine("--------------------------------------------------------------------------------------------");
            }

        }
       

    }
}