namespace sSandovalExamen.Ventanas;

public partial class Resumen : ContentPage
{
    private string nombreUsuario = "";
    private string apellidoUsuario = "";
    private int edadUsuario = 30;
    private DateTime fechaInscripcion = new DateTime(2024, 6, 22);
    private string ciudadUsuario = "";
    private string paisUsuario = "";
    private double montoInicial = 500;
    private double pagoMensual = 350;
    private double pagoTotal = 1700;
    public Resumen()
    {
        InitializeComponent();



        labelNombre.Text = nombreUsuario;
        labelApellido.Text = apellidoUsuario;
        labelEdad.Text = edadUsuario.ToString();
        labelFecha.Text = fechaInscripcion.ToString("dd/MM/yyyy");
        labelCiudad.Text = ciudadUsuario;
        labelPais.Text = paisUsuario;
        labelMontoInicial.Text = montoInicial.ToString("C2");
        labelPagoMensual.Text = pagoMensual.ToString("C2");
        labelPagoTotal.Text = pagoTotal.ToString("C2");
    }

}

