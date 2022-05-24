using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mediaMin = 20;
            int mediaMax = 50;
            int mediaAluno = 0;

            mediaAluno = (mediaMin + mediaMax)/2;

            Console.WriteLine($"A idade média dos alunos é: {mediaAluno} anos");
        }
    }
}
