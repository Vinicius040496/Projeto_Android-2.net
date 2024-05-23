namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                double Dolar1 = string.IsNullOrEmpty(Dolar.Text) ? 0 : Convert.ToDouble(Dolar.Text);
                double Euro1 = string.IsNullOrEmpty(Euro.Text) ? 0 : Convert.ToDouble(Euro.Text);
                double Libra1 = string.IsNullOrEmpty(Libra.Text) ? 0 : Convert.ToDouble(Libra.Text);
                double Peso1 = string.IsNullOrEmpty(Peso.Text) ? 0 : Convert.ToDouble(Peso.Text);

              
                double VDolarr = 5.15;
                double VEuroo = 5.50;
                double VLibraa = 6.50;
                double VPesoo = 0.50;

        
                double VDolar = Dolar1 / VDolarr;
                double VEuro = Euro1 / VEuroo;
                double VLibra = Libra1 / VLibraa;
                double VPeso = Peso1 / VPesoo;

               
                string Msg = $"Conversão Valores:\n" +
                             $"USD: {VDolar:F2}\n" +
                             $"EUR: {VEuro:F2}\n" +
                             $"Libra: {VLibra:F2}\n" +
                             $"Peso: {VPeso:F2}";

              
                DisplayAlert("Resultado Conversão", Msg, "Fechar");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Fechar");
            }
        }
    }
}
