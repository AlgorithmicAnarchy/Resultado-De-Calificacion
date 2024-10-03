using System;

namespace ResultadoDeCalificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularPromedio();
        }

        static void CalcularPromedio()
        {
            Console.WriteLine("Bienvenido a ToDaKi");

            Console.WriteLine("\nInserta el nombre del estudiante:");
            string nombreEstudiante = Console.ReadLine();

            Console.WriteLine("\nInserta el nombre de la materia:");
            string nombreMateria = Console.ReadLine();

            double[] notas = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nInserta la nota {i + 1}:");
                notas[i] = double.Parse(Console.ReadLine());
            }
            
            double promedio = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            if (promedio >= 70)
            {
                Console.WriteLine("Este estudiante ha pasado el año escolar.");
                MostrarResultadoFinal(nombreEstudiante, nombreMateria, promedio, "Aprobado");
            }
            else
            {
                Console.WriteLine("Este estudiante ha reprobado. Procederá al completivo.");

                double CPromedio = promedio / 2;
                Console.WriteLine("Nota del estudiante en el completivo:");
                double notaCompletivo = double.Parse(Console.ReadLine());
                double resultadoCompletivo = CPromedio + (notaCompletivo / 2);

                Console.WriteLine($"El resultado de la nota en completivo es: {resultadoCompletivo:F2}");

                if (resultadoCompletivo >= 70)
                {
                    Console.WriteLine("El estudiante ha aprobado el completivo.");
                    MostrarResultadoFinal(nombreEstudiante, nombreMateria, resultadoCompletivo, "Aprobado");
                }
                else
                {
                    Console.WriteLine("El estudiante ha reprobado el completivo. Procederá al extraordinario.");

                    double porcentajePromedio = promedio * 0.30;
                    Console.WriteLine("Ingresa la nota del examen extraordinario:");
                    double notaExtraordinario = double.Parse(Console.ReadLine());
                    double resultadoExtraordinario = porcentajePromedio + (notaExtraordinario * 0.70);

                    Console.WriteLine($"El resultado de la nota en extraordinario es: {resultadoExtraordinario:F2}");

                    if (resultadoExtraordinario >= 70)
                    {
                        Console.WriteLine("El estudiante ha aprobado el extraordinario.");
                        MostrarResultadoFinal(nombreEstudiante, nombreMateria, resultadoExtraordinario, "Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("El estudiante ha reprobado el extraordinario.");
                        MostrarResultadoFinal(nombreEstudiante, nombreMateria, resultadoExtraordinario, "Reprobado");
                    }
                }
            }
        }

        static void MostrarResultadoFinal(string nombreEstudiante, string nombreMateria, double notaFinal, string situacion)
        {
            Console.Clear();
            Console.WriteLine("\n---- Resultado Final ----");
            Console.WriteLine($"Nombre del estudiante: {nombreEstudiante}");
            Console.WriteLine($"Nombre de la materia: {nombreMateria}");
            Console.WriteLine($"Calificación obtenida: {notaFinal:F2}");
            Console.WriteLine($"Situación: {situacion}");
            Console.WriteLine("--------------------------");
        }
    }
}
