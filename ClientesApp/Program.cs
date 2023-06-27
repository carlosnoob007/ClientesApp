using ClientesApp.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      //agregarCliente();
      //consultarClientes();
      //modificarCliente();
    }

    
    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        ClientesBDContext context = new ClientesBDContext();
        Cliente cliente = new Cliente();

        cliente.nombre = "Carlos";
        cliente.apellido = "Fariño";
        cliente.direccion = "Samborondón";
        cliente.telefono = "0988471445";
        cliente.fechaNacimiento = new DateTime(1990, 10, 15);
        cliente.estado = "Soltero";

        context.Cliente.Add(cliente);
        context.SaveChanges();

        Console.WriteLine("Nombre: " + cliente.nombre + " Operación Completada");

    }


    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar clientes");
        ClientesBDContext context = new ClientesBDContext();
        List<Cliente> listClientes = context.Cliente.ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.id + " Nombre: " + item.nombre + " Apellido: " + item.apellido + " Dirección: " + item.direccion + " Teléfono: " + item.telefono + " Fecha de Nacimiento: " + item.fechaNacimiento + " Estado: " + item.estado);
        }

    }


    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar estudiante");
        ClientesBDContext context = new ClientesBDContext();
        Cliente cliente = new Cliente();
        cliente = context.Cliente.Find(1);

        cliente.nombre = "Josué";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + cliente.id + " Nombre: " + cliente.nombre);

    }


}
