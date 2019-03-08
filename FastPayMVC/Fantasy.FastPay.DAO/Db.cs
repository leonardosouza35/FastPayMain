using Fantasy.FastPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.DAO
{
    public sealed class Db
    {
        private static List<Usuario> _usuarios;
        public static List<Usuario> Usuarios
        {
            get{return _usuarios ?? (_usuarios = new List<Usuario>());}  
        }

    }
}
