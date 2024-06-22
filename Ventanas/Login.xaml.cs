
namespace sSandovalExamen.Ventanas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private readonly string[] usuarios = { "estudiante", "moviles" };
    private readonly string[] contraseñas = { "uisrael", "2024" };

private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtContraseña.Text;

        bool credencialesValidas = false;


        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuario == usuarios[i] && contraseña == contraseñas[1])
            {
                credencialesValidas = true;
                break;
            }
        }

        if (credencialesValidas)
        {
            Navigation.PushAsync(new Registro(usuario));
            DisplayAlert("Inicio de sesión", "EXITOSO" , "OK");


           
        }
        else
        {
            DisplayAlert("ALERTA", "Usuario o Contraseña Incorrectos", "OK");
        }
    }
}
  