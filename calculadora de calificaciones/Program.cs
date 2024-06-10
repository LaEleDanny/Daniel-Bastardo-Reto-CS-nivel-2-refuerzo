Console.WriteLine("Calculadora de Estadísticas de Calificaciones");

Console.Write("Ingresa la cantidad de calificaciones: ");
int cantidadCalificaciones = int.Parse(Console.ReadLine());

double sumaCalificaciones = 0;
double notaMasAlta = double.MinValue;
double notaMasBaja = double.MaxValue;

for (int i = 1; i <= cantidadCalificaciones; i++)
{
    Console.Write($"Ingresa la calificación {i}: ");
    double calificacion = double.Parse(Console.ReadLine());
    sumaCalificaciones += calificacion;

    notaMasAlta = Math.Max(notaMasAlta, calificacion);
    notaMasBaja = Math.Min(notaMasBaja, calificacion);
}

double promedio = sumaCalificaciones / cantidadCalificaciones;

Console.WriteLine($"El promedio de las {cantidadCalificaciones} calificaciones es: {promedio:F2}");

Console.WriteLine($"La nota más alta es: {notaMasAlta:F2}");
Console.WriteLine($"La nota más baja es: {notaMasBaja:F2}");