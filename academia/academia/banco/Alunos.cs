using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace academia.banco
{
    internal class Alunos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Fone { get; set; }
        public int Idade { get; set; }
        public string Modalidade { get; set; }
        public int Peso { get; set; }
    }
}
