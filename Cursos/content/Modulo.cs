using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.content
{
   
        public class Modulo
        {
            public Modulo()
            {
                Aulas = new List<Aula>();
            }
            public int Ordem { get; set; }
            public string titulo { get; set; }

            public IList<Aula> Aulas { get; set; }
        }
    }

