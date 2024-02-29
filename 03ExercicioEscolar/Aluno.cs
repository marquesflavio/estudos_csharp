using System;

class Aluno
{
    // Atributos dos alunos
    public string nome;
    public double nota1, nota2;

    public double media()
    {
        double mediaDasNotas = (nota1 + nota2) / 2;
        return mediaDasNotas;
    }
}