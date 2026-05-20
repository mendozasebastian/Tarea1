
string validacion;
int[] empleado = new int[10];
int[] numeroCedula = new int[10];
int[] tipoEmpleado = new int[10];
int[] cantidadHorasLaboradas = new int[10];
string[] nombreEmpleado = new string[10];
float[] valorHora = new float[10];
float[] salarioOrdinario = new float[10];
float[] aumento = new float[10];
float[] salarioBruto = new float[10];
float[] deduccionCCSS = new float[10];
float[] salarioNeto = new float[10];
int cantidadEmpleadosOperarios = 0, cantidadEmpleadosTecnicos = 0, cantidadEmpleadosProfesionales = 0;
float salarioAcumuladoOperarios = 0, salarioAcumuladoTecnicos = 0, salarioAcumuladoProfesionales = 0, salarioPromedioOperarios = 0, salarioPromedioTecnicos = 0, salarioPromedioProfesionales = 0;

for (int i = 0; i < empleado.Length; i++)
{
    Console.WriteLine("Numero de Cedula: ");
    numeroCedula[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Nombre del Empleado: ");
    nombreEmpleado[i] = Console.ReadLine();
    Console.WriteLine("Tipo de Empleado (1. Operario, 2. Tecnico, 3. Profesional: ");
    tipoEmpleado[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Cantidad de Horas Laboradas: ");
    cantidadHorasLaboradas[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Precio por Hora Laborada: ");
    valorHora[i] = float.Parse(Console.ReadLine());

    salarioOrdinario[i] = cantidadHorasLaboradas[i] * valorHora[i];
    ;

    switch (tipoEmpleado[i])
    {
        case 1:
            Console.WriteLine("Tipo 1. Operario");
            aumento[i] = salarioOrdinario[i] * 0.15f;
            break;
        case 2:
            Console.WriteLine("Tipo 2. Tecnico");
            aumento[i] = salarioOrdinario[i] * 0.10f;
            break;
        case 3:
            Console.WriteLine("Tipo 3. Profesional");
            aumento[i] = salarioOrdinario[i] * 0.05f;
            break;
        default:
            Console.WriteLine("Tipo de Empleado no valido");
            aumento[i] = salarioOrdinario[i];
            break;
    }
    salarioBruto[i] = salarioOrdinario[i] + aumento[i];
    deduccionCCSS[i] = salarioBruto[i] * 0.0917f;
    salarioNeto[i] = salarioBruto[i] - deduccionCCSS[i];

    Console.WriteLine("Ingresar un Empleado mas? (si / no)");
    validacion = Console.ReadLine();
    if (validacion.ToLower() != "si")
        break;

}

for (int i = 0; i < empleado.Length; i++)
{
    if (numeroCedula[i] != 0)
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Cedula: {numeroCedula[i]}");
        Console.WriteLine($"Nombre: {nombreEmpleado[i]}");
        Console.WriteLine($"Tipo empleado: {tipoEmpleado[i]}");
        Console.WriteLine($"Salario por hora: {valorHora[i]}");
        Console.WriteLine($"Cantidad de horas: {cantidadHorasLaboradas[i]}");
        Console.WriteLine($"Salario ordinario: {salarioOrdinario[i]}");
        Console.WriteLine($"Aumento: {aumento[i]}");
        Console.WriteLine($"Salario bruto: {salarioBruto[i]}");
        Console.WriteLine($"Deduccion CCSS: {deduccionCCSS[i]}");
        Console.WriteLine($"Salario neto: {salarioNeto[i]}");
        Console.WriteLine(" ");

        switch (tipoEmpleado[i])
        {
            case 1:
                cantidadEmpleadosOperarios++;
                salarioAcumuladoOperarios += salarioNeto[i];
                break;
            case 2:
                cantidadEmpleadosTecnicos++;
                salarioAcumuladoTecnicos += salarioNeto[i];
                break;
            case 3:
                cantidadEmpleadosProfesionales++;
                salarioAcumuladoProfesionales += salarioNeto[i];
                break;
        }

    }
}

salarioPromedioOperarios = salarioAcumuladoOperarios / cantidadEmpleadosOperarios;
salarioPromedioProfesionales = salarioAcumuladoProfesionales / cantidadEmpleadosProfesionales;
salarioPromedioTecnicos = salarioAcumuladoTecnicos / cantidadEmpleadosTecnicos;

Console.WriteLine($"Cantidad de Operarios: {cantidadEmpleadosOperarios}, salario neto acumulado: {salarioAcumuladoOperarios}, promedio de salario neto: {salarioPromedioOperarios}");
Console.WriteLine($"Cantidad de Operarios: {cantidadEmpleadosTecnicos}, salario neto acumulado: {salarioAcumuladoTecnicos}, promedio de salario neto: {salarioPromedioTecnicos}");
Console.WriteLine($"Cantidad de Operarios: {cantidadEmpleadosProfesionales}, salario neto acumulado: {salarioAcumuladoProfesionales}, promedio de salario neto: {salarioPromedioProfesionales}");
;