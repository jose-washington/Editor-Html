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
            Console.WriteLine(" Deseja salvar o arquivo? 1 - Sim , 2 - Não ou 3 - visualização");
            
            var option = short.Parse(Console.ReadLine());

            switch(option){
                case 1: SalvarFile(file.ToString()); break;
                //Usando o ToString pra converte o file em string
                case 3: Viewer.Show(file.ToString()); break;
            }
        }


        public static void SalvarFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
        }

    }
}