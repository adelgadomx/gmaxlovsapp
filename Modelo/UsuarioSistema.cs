using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioSistema
    {
        public int id_persona { get; set; }
        public String de_nombre_completo { get; set; }
        public String cv_username { get; set; }
        public String cv_password { get; set; }
        public String es_vigente { get; set; }

        public UsuarioSistema() {}

        public UsuarioSistema (int id_persona, String de_nombre_completo, String cv_username, String cv_password, String es_vigente)
        {
            this.id_persona = id_persona;
            this.de_nombre_completo = de_nombre_completo;
            this.cv_username = cv_username;
            this.cv_password = cv_password;
            this.es_vigente = es_vigente;

        }

    }
}
