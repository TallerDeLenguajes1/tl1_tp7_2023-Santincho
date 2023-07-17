using EmpleadoSpace;

Empleados empleado1 = new Empleados();
empleado1.Nombre = "Santiago";
empleado1.Apellido = "Gonzalez";
empleado1.FechaNac = new DateTime(2001,09,13);
empleado1.Genero = 'M';
empleado1.EstadoCivil = 'S';
empleado1.Cargo=Cargos.Ingeniero;
empleado1.SueldoBasico = (double)Cargos.Ingeniero;
empleado1.FechaIngreso=new DateTime(2015, 03, 15);
Console.WriteLine("\n\tEmpleado 1\n");
Console.WriteLine("Nombre: " + empleado1.Nombre);
Console.WriteLine("Apellido: " + empleado1.Apellido);
Console.WriteLine("Fecha de nacimiento: " + empleado1.FechaNac);
Console.WriteLine("Genero: " + empleado1.Genero + " (M: masculino, F: femenino)");
Console.WriteLine("Estado Civil: " + empleado1.EstadoCivil + " (C: casado, S: soltero)");
Console.WriteLine("Cargo: " + empleado1.Cargo);
Console.WriteLine("Sueldo básico: " + empleado1.SueldoBasico);
Console.WriteLine("Fecha de ingreso: " + empleado1.FechaIngreso);
Console.WriteLine("Edad:" + empleado1.Edad(empleado1.FechaNac));
Console.WriteLine("Faltan " + empleado1.Jubilacion(empleado1.Genero,empleado1.FechaNac)+" años para jubilarese\n");
Console.WriteLine("Salario: " + empleado1.Salario(empleado1.SueldoBasico, empleado1.FechaIngreso, empleado1.Cargo, empleado1.EstadoCivil));




Empleados empleado2 = new Empleados();
empleado2.Nombre = "Jazmin";
empleado2.Apellido="Martin";
empleado2.FechaNac=new DateTime(2001,05,29);
empleado2.Genero='F';
empleado2.EstadoCivil='S';
empleado2.Cargo = Cargos.Especialista;
empleado2.SueldoBasico = (double)Cargos.Especialista;
empleado2.FechaIngreso=new DateTime(2014, 07, 25);
Console.WriteLine("\n\tEmpleado 2\n");
Console.WriteLine("Nombre: "+empleado2.Nombre);
Console.WriteLine("Apellido: "+empleado2.Apellido);
Console.WriteLine("Fecha de nacimiento: "+empleado2.FechaNac);
Console.WriteLine("Genero: "+empleado2.Genero+" (M: masculino, F: femenino)");
Console.WriteLine("Estado Civil: "+empleado2.EstadoCivil+" (C: casado, S: soltero)");
Console.WriteLine("Cargo: "+empleado2.Cargo);
Console.WriteLine("Sueldo básico: "+empleado2.SueldoBasico);
Console.WriteLine("Fecha de ingreso: "+empleado2.FechaIngreso);
Console.WriteLine("Edad:"+empleado2.Edad(empleado2.FechaNac));
Console.WriteLine("Faltan "+empleado2.Jubilacion(empleado2.Genero,empleado2.FechaNac)+" años para jubilarese\n");
Console.WriteLine("Salario:"+empleado2.Salario(empleado2.SueldoBasico, empleado2.FechaIngreso, empleado2.Cargo, empleado2.EstadoCivil));


Empleados empleado3 = new Empleados();
empleado3.Nombre = "Ignacio";
empleado3.Apellido = "Tula";
empleado3.FechaNac = new DateTime(2001,09,01);
empleado3.Genero = 'M';
empleado3.EstadoCivil = 'C';
empleado3.Cargo = Cargos.Administrativo;
empleado3.SueldoBasico = (double)Cargos.Especialista;
empleado3.FechaIngreso= new DateTime(2015, 10, 08);
Console.WriteLine("\n\tEmpleado 3\n");
Console.WriteLine("Nombre: " + empleado3.Nombre);
Console.WriteLine("Apellido: " + empleado3.Apellido);
Console.WriteLine("Fecha de nacimiento: " + empleado3.FechaNac);
Console.WriteLine("Genero: " + empleado3.Genero + " (M: masculino, F: femenino)");
Console.WriteLine("Estado Civil:  "+ empleado3.EstadoCivil + " (C: casado, S: soltero)");
Console.WriteLine("Cargo: " + empleado3.Cargo);
Console.WriteLine("Sueldo básico: " + empleado3.SueldoBasico);
Console.WriteLine("Fecha de ingreso: " + empleado3.FechaIngreso);
Console.WriteLine("Edad: " + empleado3.Edad(empleado3.FechaNac));
Console.WriteLine("Faltan " + empleado3.Jubilacion(empleado3.Genero,empleado3.FechaIngreso) + " años para jubilarese\n");
Console.WriteLine("Salario: " + empleado3.Salario(empleado3.SueldoBasico, empleado3.FechaIngreso, empleado3.Cargo, empleado3.EstadoCivil));

Console.WriteLine("\n");

salarioTotal();

if (empleado3.Jubilacion(empleado3.Genero,empleado3.FechaIngreso) < empleado2.Jubilacion(empleado2.Genero,empleado2.FechaIngreso) && 
empleado3.Jubilacion(empleado3.Genero,empleado3.FechaIngreso) < empleado1.Jubilacion(empleado1.Genero,empleado1.FechaIngreso))
{
    Console.WriteLine("\n\tEmpleado 3 mas cerca de jubilarse\n");
    Console.WriteLine("Nombre: " + empleado3.Nombre);
    Console.WriteLine("Apellido: " + empleado3.Apellido);
    Console.WriteLine("Fecha de nacimiento: "+ empleado3.FechaNac);
    Console.WriteLine("Genero: " + empleado3.Genero+" (M: masculino, F: femenino)");
    Console.WriteLine("Estado Civil: " + empleado3.EstadoCivil+" (C: casado, S: soltero)");
    Console.WriteLine("Cargo: " + empleado3.Cargo);
    Console.WriteLine("Sueldo básico: " + empleado3.SueldoBasico);
    Console.WriteLine("Fecha de ingreso: "+ empleado3.FechaIngreso);
    Console.WriteLine("Edad:" + empleado3.Edad(empleado3.FechaNac));
    Console.WriteLine("Faltan " + empleado3.Jubilacion(empleado3.Genero,empleado3.FechaNac) + " años para jubilarese\n");
    Console.WriteLine("Salario:" + empleado3.Salario(empleado3.SueldoBasico, empleado3.FechaIngreso, empleado3.Cargo, empleado3.EstadoCivil));
}
else if(empleado1.Jubilacion(empleado1.Genero,empleado1.FechaIngreso) < empleado2.Jubilacion(empleado2.Genero,empleado2.FechaIngreso))
{
    Console.WriteLine("\n\tEmpleado 1 mas cerca de jubilarse\n");
    Console.WriteLine("Nombre: " + empleado1.Nombre);
    Console.WriteLine("Apellido: " + empleado1.Apellido);
    Console.WriteLine("Fecha de nacimiento: " + empleado1.FechaNac);
    Console.WriteLine("Genero: " + empleado1.Genero + " (M: masculino, F: femenino)");
    Console.WriteLine("Estado Civil: " + empleado1.EstadoCivil + " (C: casado, S: soltero)");
    Console.WriteLine("Cargo: " + empleado1.Cargo);
    Console.WriteLine("Sueldo básico: " + empleado1.SueldoBasico);
    Console.WriteLine("Fecha de ingreso: " + empleado1.FechaIngreso);
    Console.WriteLine("Edad:" + empleado1.Edad(empleado1.FechaNac));
    Console.WriteLine("Faltan " + empleado1.Jubilacion(empleado1.Genero,empleado1.FechaNac) + " años para jubilarese\n");
    Console.WriteLine("Salario:" + empleado1.Salario(empleado1.SueldoBasico, empleado1.FechaIngreso, empleado1.Cargo, empleado1.EstadoCivil));
}
else
{
    Console.WriteLine("\n\tEmpleado 2 mas cerca de jubilarse\n");
    Console.WriteLine("Nombre: " + empleado2.Nombre);
    Console.WriteLine("Apellido: " + empleado2.Apellido);
    Console.WriteLine("Fecha de nacimiento: " + empleado2.FechaNac);
    Console.WriteLine("Genero: "+empleado2.Genero+" (M: masculino, F: femenino)");
    Console.WriteLine("Estado Civil: " + empleado2.EstadoCivil+" (C: casado, S: soltero)");
    Console.WriteLine("Cargo: " + empleado2.Cargo);
    Console.WriteLine("Sueldo básico: " + empleado2.SueldoBasico);
    Console.WriteLine("Fecha de ingreso: " + empleado2.FechaIngreso);
    Console.WriteLine("Edad:" + empleado2.Edad(empleado2.FechaNac));
    Console.WriteLine("Faltan " + empleado2.Jubilacion(empleado2.Genero,empleado2.FechaNac) + " años para jubilarese\n");
    Console.WriteLine("Salario:" + empleado2.Salario(empleado2.SueldoBasico, empleado2.FechaIngreso, empleado2.Cargo, empleado2.EstadoCivil));
}



void salarioTotal()
{
    double total = empleado1.Salario(empleado1.SueldoBasico, empleado1.FechaIngreso, empleado1.Cargo, empleado1.EstadoCivil) + 
    empleado2.Salario(empleado2.SueldoBasico, empleado2.FechaIngreso, empleado2.Cargo, empleado2.EstadoCivil) + 
    empleado3.Salario(empleado3.SueldoBasico, empleado3.FechaIngreso, empleado3.Cargo, empleado3.EstadoCivil);
    Console.WriteLine("Total de salarios= "+total+" pesos");
}