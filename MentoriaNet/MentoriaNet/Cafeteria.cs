using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaNet
{
    public class Cafeteria : ILugar
    {

        public Grao Grao { get; set; }

        public Cafe FazerCafe(MetodoDeExtracao metodo, Grao grao)
        {
            return metodo.FazExtracao(grao);
        }

        public Cafe FazerCafe()
        {
            throw new NotImplementedException();
        }
    }
    public class Padaria : ILugar
    {

        public Cafe FazerCafe()
        {
            return new Cafe();
        }
    }
}
