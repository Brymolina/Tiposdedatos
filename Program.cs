using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista para almacenar los contactos
            List<Contacto> contactos = new List<Contacto>();

            // Datos de ejemplo: tu contacto
            contactos.Add(new Contacto
            {
                Nombre = "Bryan Molina",
                Telefono = new string[] { "0968804359", "0991234567", "0987654321" },
                Correo = "bryanmolinav26@gmail.com"
            });

            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA TELEFONICA ===");
                Console.WriteLine("1. Mostrar contactos");
                Console.WriteLine("2. Agregar contacto");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarContactos(contactos);
                        break;
                    case "2":
                        AgregarContacto(contactos);
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Método para mostrar los contactos
        static void MostrarContactos(List<Contacto> contactos)
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE CONTACTOS ===");
            if (contactos.Count == 0)
            {
                Console.WriteLine("No hay contactos guardados.");
            }
            else
            {
                foreach (var c in contactos)
                {
                    Console.WriteLine($"Nombre: {c.Nombre}");
                    Console.WriteLine("Teléfonos: " + string.Join(", ", c.Telefono));
                    Console.WriteLine($"Correo: {c.Correo}");
                    Console.WriteLine("----------------------------");
                }
            }
            Console.WriteLine("Presione Enter para regresar al menú...");
            Console.ReadLine();
        }

        // Método para agregar un nuevo contacto
        static void AgregarContacto(List<Contacto> contactos)
        {
            Console.Clear();
            Console.WriteLine("=== AGREGAR CONTACTO ===");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            string[] telefonos = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            Console.Write("Correo: ");
            string correo = Console.ReadLine();

            contactos.Add(new Contacto
            {
                Nombre = nombre,
                Telefono = telefonos,
                Correo = correo
            });

            Console.WriteLine("Contacto agregado correctamente. Presione Enter para continuar...");
            Console.ReadLine();
        }
    }

    // Clase para representar un contacto
    class Contacto
    {
        public string Nombre { get; set; }
        public string[] Telefono { get; set; }
        public string Correo { get; set; }
    }
}