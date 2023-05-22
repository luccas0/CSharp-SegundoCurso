using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PDesafio4_Matricula
{
    internal class Aluno
    {
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Não pode ser colocado um núnero que seja menor ou igual a 0.");
                }
                else
                {
                    matricula = value;

                    Console.WriteLine("O número da matrícula é: " + matricula);
                }
            }
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }

    }
}
