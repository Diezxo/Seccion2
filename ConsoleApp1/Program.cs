namespace Tareas
{
    class Program
    {
        string? nombre, apellido, correo, mensaje;
        int edad, telefono;
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu Nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu apellido");
            var apellido = Console.ReadLine();
            Console.WriteLine("Que edad tienes");
            var edad = Console.ReadLine();
            Console.WriteLine("Cual es tu correo electronico");
            var correo = Console.ReadLine();
            Console.WriteLine("cual es tu numero de telefono");
            var telefono = Console.ReadLine();

            var mensaje = "Hola "+ nombre+" "+apellido+", tienes "+edad +" años," + " tu correo electronico es " + correo + " y tu numero de telefono es " + telefono;
            Console.WriteLine(mensaje);
         }
    }
}