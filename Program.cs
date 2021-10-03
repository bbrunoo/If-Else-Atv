using System;
using static System.Console;

namespace ifElseMeses
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escreva o numero do mês:");
            string mes = ReadLine();

            if (mes == "2")
            {
              WriteLine("Este mês tem 28 ou 29 dias");
            }

            //Meses com 31 dias
            
                    else if(mes == "1")
                    {
                    WriteLine("Este mês tem 31 dias"); 
                    }
                    else if(mes == "3")
                    {
                    WriteLine("Este mês tem 31 dias"); 
                    }
                    else if(mes == "5")
                    {
                    WriteLine("Este mês tem 31 dias"); 
                    }
                    else if(mes == "7")
                    {
                    WriteLine("Este mês tem 31 dias"); 
                    }
                    else if(mes == "8")
                    {
                    WriteLine("Este mês tem 31 dias"); 
                    }
                    else if(mes == "10")
                    {
                    WriteLine("Este mês tem 31 dias"); 
                    }
                    else if(mes == "12")
                    {
                    WriteLine("Este mês tem 31 dias"); 
                    }
            
            //Meses com 30 dias

                    else if(mes == "2")
                    {
                    WriteLine("Este mês tem 30 dias"); 
                    }

                    else if(mes == "4")
                    {
                    WriteLine("Este mês tem 30 dias"); 
                    }

                    else if(mes == "6")
                    {
                    WriteLine("Este mês tem 30 dias"); 
                    }

                    else if(mes == "9")
                    {
                    WriteLine("Este mês tem 30 dias"); 
                    }

                    else if(mes == "11")
                    {
                    WriteLine("Este mês tem 30 dias"); 
                    }

            //Meses invalidos        
                
                else
                {
                    WriteLine("Insira um mês valido");
                }

        }
    }
}
