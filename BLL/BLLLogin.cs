using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLLogin
    {
        public BLLLogin()
        {
            MPPlogin = new MPPLogin();
        }
        MPPLogin MPPlogin;
        public bool ConsultarUsuario(string email, string pass)
        {
            return MPPlogin.ConsultarUsuario(email, pass);
        }
        public BEClsEmpleado Get(string email)
        {
            return MPPlogin.Get(email);
        }
    }
}
