using _240325_clinica.models;

Clinica c1 = new Clinica();
Clinica.InstanceCount = 1; // Static acessa pela classe
c1.ObjectCount = 1; // Dynamic acessa pelo ojeto


// Segunda Clinica
Clinica c2 = new Clinica();
Clinica.InstanceCount++;
c2.ObjectCount = 10;

Console.WriteLine($"Valor Clinica Instancia: {Clinica.InstanceCount}");
Console.WriteLine($"Valor C1: {c1.ObjectCount} Valor C2: {c2.ObjectCount}");