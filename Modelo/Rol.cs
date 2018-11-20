using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Rol
    {
        public int IDrol { get; set; }
        public String DErol { get; set; }

        public Rol() : this("") { }

        public Rol( String pRol )
        {
            this.DErol = pRol;
        }
    }
}
