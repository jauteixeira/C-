namespace Senaizinho
{
    public class Aluno
    {
        /*================= ATRIBUTOS DA CLASSE ALUNO =================*/
        public string nome {get; set;}
        public string curso {get; set;}
        public int numeroSala {get; set;}

        /*================= CONSTRUTORES DA CLASSE ALUNO =================*/
        public Aluno (string nome, string curso, int numeroSala)
        {
            this.nome = nome;
            this.curso = curso;
            this.numeroSala = numeroSala;
        }
    }
}