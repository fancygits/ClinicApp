using ClinicApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Controller
{
    class CredentialController
    {
        public string GetPassword(string username)
        {
            return CredentialDAL.GetPassword(username);
        }

        public string GetRole(string username)
        {
            return CredentialDAL.GetRole(username);
        }

        public bool AddCredential(string username, string password, string role)
        {
            return CredentialDAL.AddCredential(username, password, role);
        }
    }
}
