using System;
using Modelos;

class Aula3 {

  public static void Main (string [] args) { 
    Aluno aluno1 = new Aluno {
        Matricula = "2020ENEL123",
        Nome = "Maria",
        Periodo = 0
    };
  Impressora.Imprimir(aluno1);
    Aluno aluno2 = new Aluno ();
  Impressora.Imprimir(aluno2);
    Aluno aluno3 = new Aluno  (2);
  Impressora.Imprimir(aluno3);
    Aluno aluno4 = new Aluno ("2020ENEL456", "josé");
  Impressora.Imprimir(aluno4);
    Aluno aluno5 = new Aluno ("2020ENEL789", "joão", 3);
  Impressora.Imprimir(aluno5);

  Disciplina disciplina1 = new Disciplina  (0);
  Impressora.Imprimir(disciplina1);
  Disciplina disciplina2 = new Disciplina  (11);
  Impressora.Imprimir(disciplina2);
  }
}
