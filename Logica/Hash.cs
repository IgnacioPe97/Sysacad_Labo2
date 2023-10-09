using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Hash
    {

        public static string ObtenerHash(string contra)
        {
            var hash2 = BCrypt.Net.BCrypt.EnhancedHashPassword(contra, 13);
            return hash2;
        }
        public static bool ValidaContrasenia(string contrasenia,string hash)
        {

            return BCrypt.Net.BCrypt.EnhancedVerify(contrasenia,hash);
        } 
    }
}
