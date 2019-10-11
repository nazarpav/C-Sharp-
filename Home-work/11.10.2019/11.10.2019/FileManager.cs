using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _11._10._2019
{
    class FileManager
    {
        private void DrawBuf(Stack<string> buffer)
        {
            Console.WriteLine("Buffer VVV");
            foreach (var i in buffer) Console.WriteLine(i);
            Console.WriteLine("^^^");
        }
        public void Start()
        {
            FileInfo fileInfo;
            int choise = 0;
            string currenDir = "";
            Stack<string> buffer = new Stack<string>();
            while (true)
            {
                DrawBuf(buffer);
                currenDir = Directory.GetCurrentDirectory();
                Console.WriteLine("\nCurrent directory =>>>>   " + currenDir + "\n");
                Console.WriteLine("Operation with Directory\n{\n1 :: Create new directory\n2 :: Delete directory\n3 :: View all file in directory\n4 :: View all directory in directory\n}" +
                                              "\nOpearation with file\n{\n11 :: Delete file\n12 :: Copy path to file\n13 :: Move file with use your path\n14 :: View information with file\n15 :: Paste file with buf\n}\nChange directory\n{\n" +
                                              "21 :: Back\n22 :: Go to directory with your path\n23 :: Go to directory with name\n\n0 :: Exit");
                while (!(int.TryParse(Console.ReadLine(), out choise))) ;
                switch (choise)
                {
                    case 0: return;
                    case 1:
                        Console.WriteLine("Enter name directory => ");
                        Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\" + Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Enter name directory => ");
                        Directory.Delete(Directory.GetCurrentDirectory() + @"\" + Console.ReadLine(), true);
                        break;
                    case 3:
                        foreach (var i in Directory.GetFiles(Directory.GetCurrentDirectory())) Console.WriteLine(i);
                        break;
                    case 4:
                        foreach (var i in Directory.EnumerateDirectories(Directory.GetCurrentDirectory())) Console.WriteLine(i);
                        break;
                    case 11:
                        Console.WriteLine("Enter file name => ");
                        File.Delete(Directory.GetCurrentDirectory() + @"\" + Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("Enter file name => ");
                        buffer.Push(Directory.GetCurrentDirectory() + @"\" + Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("Enter path to move => ");
                        string pathm = Console.ReadLine();
                        Console.WriteLine("Enter file name => ");
                        File.Move(Directory.GetCurrentDirectory() + @"\" + Console.ReadLine(), pathm);
                        break;
                    case 14:
                        Console.WriteLine("Enter file name => ");
                        string name = Console.ReadLine();
                        fileInfo = new FileInfo(Directory.GetCurrentDirectory() + @"\" + name);
                        Console.WriteLine("Name => "+ fileInfo.Name);
                        Console.WriteLine("Full fame => "+ fileInfo.FullName);
                        Console.WriteLine("Attributes => "+ fileInfo.Attributes);
                        Console.WriteLine("Directory name => "+ fileInfo.DirectoryName);
                        Console.WriteLine("Creation time => " + fileInfo.CreationTime);
                        Console.WriteLine("Last access time => " + fileInfo.LastAccessTime);
                        Console.WriteLine("Last write time => " + fileInfo.LastWriteTime);
                        Console.WriteLine("Extension => " + fileInfo.Extension);
                        Console.WriteLine("Size in byte => " + fileInfo.Length);
                        break;
                    case 15:
                        for (int i = buffer.Peek().Length - 1; i > 0; i--)
                            if (buffer.Peek()[i] == '\\' || buffer.Peek()[i] == '/')
                            {
                                File.Move(buffer.Peek(), Directory.GetCurrentDirectory() + buffer.Peek().Remove(0, i));
                                buffer.Pop();
                                break;
                            }
                        break;
                    case 21:
                        for (int i = currenDir.Length-1; i > 0; i--)
                            if (currenDir[i] == '\\' || currenDir[i] == '/')
                            {
                                Directory.SetCurrentDirectory(currenDir.Remove(i));
                                break;
                            }
                        break;
                    case 22:
                        Console.WriteLine("Enter path");
                        Directory.SetCurrentDirectory(Console.ReadLine());
                        break;
                    case 23:
                        Console.WriteLine("Enter folder name");
                        Directory.SetCurrentDirectory(Directory.GetCurrentDirectory()+ @"\"+Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Invalid key!");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
