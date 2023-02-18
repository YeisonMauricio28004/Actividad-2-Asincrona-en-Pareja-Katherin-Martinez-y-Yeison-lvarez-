using Actividad_2_Asincrona_En_Pareja.Entidades;
using Actividad_2_Asincrona_En_Pareja.Negocio;

Persona persona = new Persona();
ClsPersona clsPersona = new ClsPersona();
Console.WriteLine("Escribe cualquier palabra");
persona.persona = Console.ReadLine();
int count = clsPersona.count(persona.persona);
Console.WriteLine("La palabra tiene " + count + " letras");
Console.ReadKey();
