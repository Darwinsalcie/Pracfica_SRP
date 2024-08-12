
using Practica_SRP.Class;

Persona persona = new Persona();
CorreoElectronico correo = new CorreoElectronico();

persona.Nombre = "Juan";
persona.Edad = 45;
persona.Direccion = "Av Máximo Gomez #34";
persona.CorreoElectronico = "juan@gmail.com";

persona.ImprimirDatos();
Console.WriteLine(correo.LogicaEMail("Mandame los datos"));