Console.WriteLine("bienvenido");
int tipo, historial, antiguedad;
double ingreso, monto;
string fiador;
Console.WriteLine("1 Empleado fijo\r\n2 Temporal\r\n3 Independiente\r\n4 Estudiante");
Console.Write("Tipo de solicitante ");
tipo = int.Parse(Console.ReadLine());
Console.Write("Ingreso mensual");
ingreso = double.Parse(Console.ReadLine());
Console.Write("Antiguedad laboral  ");
antiguedad = int.Parse(Console.ReadLine());
Console.Write("Monto solicitado");
monto = double.Parse(Console.ReadLine());
Console.WriteLine("Historial crediticio");
Console.WriteLine("1 Excelente\r\n2 Bueno\r\n3 Regular\r\n4 Malo");
historial = int.Parse(Console.ReadLine());
Console.Write("Tiene fiador s/n ");
fiador = Console.ReadLine();

switch (tipo)
{
    case 1:
        Console.Write("empleado fijo ");
        break;

    case 2:
        Console.Write("temporal ");
        break;

    case 3:
        Console.Write("independiente");
        break;

    case 4:
        Console.Write("estudiante ");
        break;
}