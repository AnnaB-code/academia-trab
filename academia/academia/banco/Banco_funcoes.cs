using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using academia.banco;
using academia.paginas;

namespace academia.banco
{
    class Banco_funcoes
    {
        private SQLiteConnection conexao;
        string pasta = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);


        public void CriarBancoDeDados()
        {
            string dbPath = System.IO.Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Alunos.db3");
            conexao = new SQLiteConnection(dbPath);
            conexao.CreateTable<Alunos>();
        }

        public void InserirAluno(string nome, string cpf, string fone, string idade, string modalidade, string peso)
        {
            conexao.Query<Alunos>("INSERT INTO alunos (Nome,Cpf,Fone,Idade,Modalidade,Peso) "+
                "VALUES('" + nome + "','" + cpf + "','" + fone + "','" + idade + "','" + modalidade + "','" + peso  + "')");

        }

        private void DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public List<Alunos> GetAlunos()
        {
            return conexao.Query<Alunos>("SELECT * FROM alunos");
        }

        public void ExcluirAluno(string id)
        {
            conexao.Query<Alunos>("DELETE FROM alunos WHERE Id = " + id);

        }

        public void EditarAluno(string id, string nome, string cpf, string fone, string idade, string modalidade, string peso)
        {
            conexao.Query<Alunos>("UPDATE alunos SET Nome = '" + nome + "', Cpf = '" + cpf + "', Fone = '" + fone + "', Idade = '"
                + idade + "', Modalidade = '" + modalidade + "', Peso = '" + peso + "' WHERE Id = '" + id + "' ");

        }

        //PESQUISAR COMMAND
        public List<Alunos> PesquisarAlunos(string query)
            => conexao.Query<Alunos>
            ("SELECT * FROM alunos WHERE Nome like \"%" + query.Trim() + "%\"");

    }
}
