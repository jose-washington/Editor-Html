using System;
using System.Text;
using System.Xml;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        { 
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Start();

        }


        public static void Start()
        {
            var file = new StringBuilder(); 

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------");
            Console.WriteLine(" Deseja salvar o arquivo? 1 - Sim e 2 - Não");
            // var option = short.Parse(Console.ReadLine());

            // switch(option){
            //     case 1: SalvarFile(file); break;
            // }
        }

        //Erro na implementação
        // public static void SalvarFile(StringBuilder text)
        // {
        //     Console.Clear();
        //     Console.WriteLine("Qual caminho para salvar o arquivo");
        //     var path = Console.ReadLine();

        //     using (var file = new StreamWriter(path))
        //     {
        //         file.Write(text);
        //     }
        // }

    }
}