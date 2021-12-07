using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0312
{
    class Disciplina
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public Disciplina() { }

        public Disciplina(string nome, int cargahoraria)
        {
            this.CargaHoraria = cargahoraria;
            this.Nome = nome;
        }
   
    }
}
