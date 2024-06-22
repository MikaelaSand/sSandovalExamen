namespace sSandovalExamen.Ventanas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
    
	}

    private const double CostoCurso = 1500;
    private const double PorcentajeIncrementoCuota = 4 / 100.0;
    private const int NumeroCuotas = 4;
    private object stackCuotas;

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(txtMontoInicial.Text, out double montoInicial))
        {
            double montoRestante = CostoCurso - montoInicial;
            double montoPorCuota = montoRestante / NumeroCuotas;
            double incrementoPorCuota = montoPorCuota * PorcentajeIncrementoCuota;
            double totalPagar = montoInicial + montoRestante + (incrementoPorCuota * NumeroCuotas);


            txtPagoMensual.Text = totalPagar.ToString("C2");

            object values = stackCuotas;
            for (int i = 1; i <= NumeroCuotas; i++)
            {
                double cuotaConIncremento = montoPorCuota + (incrementoPorCuota * i);
                Label labelCuota = new Label
                {
                    Text = $"Cuota {i}: {cuotaConIncremento.ToString("C2")}",
                    Margin = new Thickness(0, 5, 0, 0)
                };

            }
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto válido para la inscripción inicial.", "OK");
        }

    }

 
 }






