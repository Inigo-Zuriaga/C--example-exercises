using ClasesEmpleados;

Administrative administrativo1 = new Administrative("Juan", 10);
ITurnos administrativo2 = new Administrative("Juan", 10);
ITurnos administrativo3 = new Administrative("Juan", 10);
ITurnos factory = new Factory("Juan", 10);

Console.WriteLine(administrativo1.Turno);

Console.WriteLine(administrativo2.Turno);
Console.WriteLine(administrativo3.Turno);
Console.WriteLine(factory.Turno);


// Convertir en worker
Worker worker1 = (Worker)administrativo1;
Worker worker2 = (Worker)administrativo2;
Worker worker3 = (Worker)administrativo3;
Worker worker4 = (Worker)factory;

// Convertir en Empleado
Empleado empleado1 = (Empleado)administrativo1;
Empleado empleado2 = (Empleado)administrativo2;
Empleado empleado3 = (Empleado)administrativo3;
Empleado empleado4 = (Empleado)factory;





// Inyección de dependencias - Inversion de control


