using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3RegistroUH
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 5;

        struct Student
        {
            public int codeStudent;
            public string studentName;
            public string StudentGender;
            public int StudentEdge;
        };

        static Student[] Students;

        static void AddStudents()
        {
            int finish = 0;
            while (finish != 1)
            {
                Console.Clear();
                if (i < Students.Length)
                {
                    Console.WriteLine("Bienvenido al registro de la UH");
                    Console.WriteLine("Ingreso de estudiantes");
                    Console.WriteLine("Digite el Codigo:");
                    Students[i].codeStudent = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el nombre del estudiente:");
                    Students[i].studentName = Console.ReadLine();
                    Console.WriteLine("Digite la edad del estudiante:");
                    Students[i].StudentEdge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el genero:");
                    Students[i].StudentGender = Console.ReadLine();
                    Console.WriteLine("Desea agregar otro estudiente 0-Sí 1-No");
                    finish = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro completo");
                    finish = 1;
                    Console.ReadKey();
                }
            }

        }

        static void ShowStudents()
        {
            int reg = 0;
            Console.Clear();

            Console.WriteLine("==================================================");
            Console.WriteLine("             " + "Listado de estudintes" + "          ");
            Console.WriteLine("==================================================");
            Console.WriteLine("Universidad Hispanoamericana");
            Console.WriteLine("==================================================");
            for (i = 0; i < Students.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                Console.WriteLine(reg + " " + Students[i].codeStudent + " " + Students[i].studentName + "  " + Students[i].StudentGender + "  " + Students[i].StudentEdge);

            }
            Console.WriteLine("===================================================");
            Console.WriteLine("Fin de informe \n\n");

            Console.ReadKey();
        }


        static void ShowClasification()
        {

            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("Informe Clasificación estudiantil UH");
            Console.WriteLine("====================================");
            int child = 0;
            int young = 0;
            int adult = 0;
            for (int i = 0; i < Students.Length; i++)
            {

                if (Students[i].StudentEdge < 18)
                {
                    child++;
                }
                else
                {
                    if (Students[i].StudentEdge > 19 && Students[i].StudentEdge < 29)
                    {
                        young++;
                    }
                    else
                    {
                        if (Students[i].StudentEdge > 30)
                        {

                            adult++;

                        }
                    }

                }
            }


            int women = 0;
            int men = 0;
            for (i = 0; i < Students.Length; i++)
            {
                if (Students[i].StudentGender == "F")
                {
                    women++;

                }
                else
                {
                    if (Students[i].StudentGender == "M")
                    {
                        men++;
                    }
                }
            }


            Console.WriteLine("Clasificacion por edad        ||   Clasificacion por Genero");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Menores de edad " + child + " || ");
            Console.WriteLine("Jovenes " + young + "         || " + " Hombres " + men);
            Console.WriteLine("Adultos " + adult + "         || " + " Mujeres " + women);
            Console.WriteLine("=============================================================");
            Console.WriteLine("Fin del informe");

            Console.ReadKey();
        }


        static void SeekStudents()
        {
            int code = 0;
            int reg = 0;
            int finish = 0;
            bool found = false;
            while (finish != 1)
            {
                Console.Clear();
                Console.WriteLine("Registro de estudiantes");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Digite el ID del libro a buscar");
                code = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (code == Students[i].codeStudent)
                    {
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese Codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro estudiente 0-Sí 1-No");
                finish = int.Parse(Console.ReadLine());
            }
        }

        static void ModifiedStudents()
        {
            int code = 0;
            string name = "";
            int edge = 0;
            string gender = "";
            int reg = 0;
            int finish = 0;
            bool found = false;
            while (finish != 1)
            {
                Console.Clear();
                Console.WriteLine("Registro de estudientes");
                Console.WriteLine("Modificacion de elemento.   ");
                Console.WriteLine("Digite el codigo desea buscar");
                code = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (code == Students[i].codeStudent)
                    {
                        Console.WriteLine("Ingrese el nuevo codigo");
                        int codeNew = int.Parse(Console.ReadLine());
                        Students[i].codeStudent = codeNew;
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese codigo");
                        found = false;
                    }
                }
                Console.WriteLine("Digite el nombre desea cambiar");
                name = Console.ReadLine();
                for (i = 0; i < Students.Length; i++)
                {
                    if (name == Students[i].studentName)
                    {
                        Console.WriteLine("Ingrese el nuevo nombre");
                        string newName = Console.ReadLine();
                        Students[i].studentName = newName;
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese nombre");
                        found = false;
                    }
                }

                Console.WriteLine("Digite la edad que desea cambiar");
                edge = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (edge == Students[i].StudentEdge)
                    {
                        Console.WriteLine("Ingrese la nueva edad");
                        int newEdge = int.Parse(Console.ReadLine());
                        Students[i].StudentEdge = newEdge;
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro esa eda");
                        found = false;
                    }
                }
                Console.WriteLine("Digite el genero que desea cambiar");
                gender = Console.ReadLine();
                for (i = 0; i < Students.Length; i++)
                {
                    if (gender == Students[i].StudentGender)
                    {
                        Console.WriteLine("Ingrese de nuevo el genero");
                        string newGender = Console.ReadLine();
                        Students[i].StudentGender = newGender;
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese genero");
                        found = false;
                    }
                }

                Console.WriteLine("Desea buscar otro elemento 0-Sí 1-No");
                finish = int.Parse(Console.ReadLine());
            }
        }

        static void deleteStudents()
        {
            int code = 0;
            string name = "";
            int edge = 0;
            string gender = "";
            int reg = 0;
            int finish = 0;
            bool found = false;
            while (finish != 1)
            {
                Console.Clear();
                Console.WriteLine("Registro de estudientes");
                Console.WriteLine("Modificacion de elemento.   ");
                Console.WriteLine("Digite el codigo a eliminar");
                code = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (code == Students[i].codeStudent)
                    {

                        Students[i].codeStudent = 0;
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese codigo");
                        found = false;
                    }
                }
                Console.WriteLine("Digite el nombre desea eliminar");
                name = Console.ReadLine();
                for (i = 0; i < Students.Length; i++)
                {
                    if (name == Students[i].studentName)
                    {
                        Students[i].studentName = " ";
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese nombre");
                        found = false;
                    }
                }

                Console.WriteLine("Digite la edad que desea eliminar");
                edge = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (edge == Students[i].StudentEdge)
                    {

                        Students[i].StudentEdge = 0;
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro esa eda");
                        found = false;
                    }
                }
                Console.WriteLine("Digite el genero que desea eliminar");
                gender = Console.ReadLine();
                for (i = 0; i < Students.Length; i++)
                {
                    if (gender == Students[i].StudentGender)
                    {

                        Students[i].StudentGender = "";
                        reg = i + 1;
                        Console.WriteLine(" Reg " + " Codigo " + "   " + "Nombre" + "    " + "Sexo" + "     " + "Edad");
                        Console.WriteLine(reg + "   " + Students[i].codeStudent + "      " + Students[i].studentName + "      " + Students[i].StudentGender + "       " + Students[i].StudentEdge);

                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese genero");
                        found = false;
                    }
                }

                Console.WriteLine("Desea buscar otro elemento 0-Sí 1-No");
                finish = int.Parse(Console.ReadLine());
            }
        }



        static void Main()
        {
            Students = new Student[size];
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al registro de la UH");
                Console.WriteLine("1. Ingreso de estudientes");
                Console.WriteLine("2. Modificación de estudientes.");
                Console.WriteLine("3. Eliminación de estudiantes");
                Console.WriteLine("4. Búsquedad de estudiantes");
                Console.WriteLine("5. Listado de estudiantes");
                Console.WriteLine("6. Informe de clasificacion de estudiantes");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddStudents();
                            break;
                        }
                    case 2:
                        {
                            ModifiedStudents();
                           
                            break;
                        }
                    case 3:
                        {
                            deleteStudents();
                            
                            break;
                        }
                    case 4:
                        {
                            SeekStudents();
                            break;
                        }
                    case 5:
                        {
                            ShowStudents();
                            break;
                        }
                    case 6:
                        {
                            ShowClasification();
                            
                            break;
                        }
                    case 7:
                        
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }

    }
}
