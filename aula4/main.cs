using Modelos;

class Aula4 {
  public static void Main (string [] args) { 
  Aluno aluno1 = new Aluno (0);
  Impressora.Imprimir(aluno1);
    aluno1.Periodo = 0;
    Impressora.Imprimir(aluno1);
    Disciplina disciplina = new Disciplina (0);
    Impressora.Imprimir(disciplina);
    disciplina.Semestre = 11;
    Impressora.Imprimir(disciplina);
    }
}