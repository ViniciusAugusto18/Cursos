using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.content
{
    public class Curso : Conteudo
    {
        public Curso()
        {
            Modelos = new List<Modelo>();
        }
        public string Tag { get; set; }
       public IList<Modelo> Modelos { get; set; }
    }

    

    
}
