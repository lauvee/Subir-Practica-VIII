static void Main(string[] args)
{
    // Obtener los parámetros de la línea de comandos
    string noCheque = args[0];
    string conceptoPago = args[1];
    string idCliente = args[2];
    string fechaPago = args[3];
    string montoNumero = args[4];
    string montoLetra = args[5];
    string facturaPagada = args[6];

    // Abrir el formulario de captura de datos del cheque
    // y pasar los parámetros a los campos correspondientes
    FormCapturaCheque formCheque = new FormCapturaCheque();
    formCheque.CargarDatos(noCheque, conceptoPago, idCliente, fechaPago, montoNumero, montoLetra, facturaPagada);
    Application.Run(formCheque);
}