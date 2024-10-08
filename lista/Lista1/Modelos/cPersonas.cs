using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista1.Modelos
{
    class cPersonas
    {
        private string Nombres;

        public string pNombres
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
        private DateTime fechaNac;

        public DateTime pFechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        private string Sexo;

        public string pSexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }

  
        
        public cPersonas()
        {
        }
        public int Edad()
        {
            int e = DateTime.Now.Year - this.fechaNac.Year;
            return e;
        }




        
    }
}
