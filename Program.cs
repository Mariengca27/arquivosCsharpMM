//Não esquecer das bibliotecas 
using System;
using System.IO;

namespace TratativaArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tratativas com arquivos
            string sourcePath = @"C:\Users\user\Desktop\PROJETOS DEZEMBRO\Udemy C#\POO\TratativaArquivos\Exemplo.txt"; //Arquivo de origem.
            string targetPath = @"C:\Users\user\Desktop\PROJETOS DEZEMBRO\Udemy C#\POO\TratativaArquivos\Exemplo2.txt"; //Novo arquivo para ir a tratativa


            try
            {

                //Instanciando os objetos de arquivos.

                FileInfo arquivoOne = new FileInfo(sourcePath);
                arquivoOne.CopyTo(targetPath);         //Fazendo uma função de cópia de um arquivo source para um novo. 
            }
            
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu!!! ");
                Console.WriteLine(e.Message);
            } 
            
        }
    }
}
