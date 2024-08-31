// See https://aka.ms/new-console-template for more information
using MensajeriaS.A.S;

Console.WriteLine("Hello, World!");

Remitente remitenteAdres = new Remitente("andres", "cesar", "315");
Direccion direccionAndres = new Direccion("calle 23","valledupar","na", "na", "colombia", "200004");
Destinatario destinoMaria = new Destinatario("cajasS.A.S", "Maria", direccionAndres, "312");
Paquete paqueteAMaria = new Caja(25, 1, "PAQUETE CROYDON", 250, true, 96);
Guia guia1 = new Guia("571", fecha: new DateTime(2011, 6, 10), Estado.DESPACHO, paqueteAMaria, destinoMaria, remitenteAdres);

Archivo archivo = new Archivo();
archivo.agregarGuia(guia1);
archivo.consultarGuiaPorNumero("521");
Guia guiaConsultada = archivo.consultarGuiaPorNumero("571");
if (guiaConsultada != null)
{
    Console.WriteLine($"Número de Envío: {guiaConsultada.ObtenerNumeroEnvio()}");
    Console.WriteLine($"Fecha: {guiaConsultada.ObtenerFecha():d}");
    Console.WriteLine($"Estado: {guiaConsultada.ObtenerEstado()}");
    Console.WriteLine($"Paquete: {guiaConsultada.ObtenerPaquete().GetDescripcion()}");
    Console.WriteLine($"Destinatario: {guiaConsultada.ObtenerDestinatario().nombreDestinatario}");
    Console.WriteLine($"Remitente: {guiaConsultada.ObtenerRemitente().GetNombre()}");
}
else
{
    Console.WriteLine("No se encontró una guía con el número proporcionado.");
}
