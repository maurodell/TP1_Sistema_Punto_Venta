using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;

namespace BLL
{
    public class BLLLogin
    {
        public BLLLogin()
        {
            login = new MPPLogin();
        }
        MPPLogin login;
        public bool ConsultarUsuario(string email, string pass)
        {
            return login.ConsultarUsuario(email, pass);
        }
        public string Get(string email, string pass)
        {
            return login.Get(email, pass);
        }
    }
}
