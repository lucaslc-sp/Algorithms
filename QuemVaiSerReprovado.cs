using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//  Titulo: PLACAR - Quem vai ser reprovado
//  Link: http://br.spoj.com/problems/PLACAR/

//  AUTHOR: LUCAS LIMA 
//  DATE: 16/04/2016 
//  LINKEDIN: https://br.linkedin.com/in/lucaslc 
//  GITHUB: https://github.com/lucaslc-sp 

namespace QuemVaiSerReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int instance = 1;

            string aux;
            do
            {
                try
                {
                    aux = Console.ReadLine();
                    if (aux != null)
                    {
                        n = Convert.ToInt16(aux);

                        var disapprovedStudent = Console.ReadLine();
                        string disapprovedName = disapprovedStudent.Split(' ')[0];
                        int disapprovedNumberQuestions = Convert.ToInt16(disapprovedStudent.Split(' ')[1]);

                        for (int i = 0; i < n - 1; i++)
                        {
                            string actualStudent = Console.ReadLine();
                            string actualStudentName = actualStudent.Split(' ')[0];
                            int actualStudentNumberQuestions = Convert.ToUInt16(actualStudent.Split(' ')[1]);


                            if (disapprovedNumberQuestions >= actualStudentNumberQuestions)
                            {
                                if (actualStudentNumberQuestions == disapprovedNumberQuestions && actualStudentName.CompareTo(disapprovedName) > 0 || actualStudentNumberQuestions < disapprovedNumberQuestions)
                                {
                                    disapprovedName = actualStudentName;
                                    disapprovedNumberQuestions = actualStudentNumberQuestions;
                                }
                            }


                        }

                        Console.WriteLine("Instancia " + instance);
                        Console.WriteLine(disapprovedName);
                        Console.WriteLine();

                        instance++;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            } while (aux != null);

            Environment.Exit(0);
        }

    }
}
