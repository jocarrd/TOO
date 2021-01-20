using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Clave
    {
        private String primera;
        private String segunda;

        public Clave(String d , String f)
        {
            this.primera = d;
            this.segunda = f;

        }
        public String GetPrimera()
        {
            return this.primera;

        }
        public String GetSegunda()
        {
            return this.segunda;

        }
        
        public bool Equals(Clave c)
        {
            return (this.GetPrimera().Equals(c.GetPrimera()) && this.GetSegunda().Equals(c.GetSegunda()));
              
        }

    }
}
