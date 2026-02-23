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
string resultado, motivo ;
switch (tipo)
{
    case 1:
        Console.Write("empleado fijo ");
        if (ingreso >= monto * 0.5 && antiguedad >= 6)
        {
            resultado = "Aprobado";
            motivo = "Cumple condiciones basicas";
        }
        else
        {
            resultado = "Aprobado con condiciones";
            motivo = "Ingreso o antiguedad baja";
        }
        break;
        

    case 2:
        Console.Write("temporal ");
        if (antiguedad >= 12 && ingreso >= monto * 0.6)
        {
            resultado = "Aprobado";
            motivo = "Temporal estable";
        }
        else
        {
            resultado = "Rechazado";
            motivo = "Temporal con poco respaldo";
        }
        break;

    case 3:
        Console.Write("independiente");
        if (ingreso >= monto)
        {
            resultado = "Aprobado";
            motivo = "Ingreso suficiente";
        }
        else
        {
            resultado = "Rechazado";
            motivo = "Ingreso insuficiente para independiente";
        }
        break;

    case 4:
        Console.Write("estudiante ");
        if (fiador == "S")
        {
            resultado = "Aprobado con condiciones";
            motivo = "Estudiante con fiador";
        }
        else
        {
            resultado = "Rechazado";
            motivo = "Estudiante sin fiador";
        }
        break;
}