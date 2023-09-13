using System.Windows.Forms;

namespace FormApp
{
    public partial class Form1 : Form
    {
        private ApiForm _apiForm;
        public Form1()
        {
            InitializeComponent();
            _apiForm = new ApiForm();
        }

        private async void CalculateButton_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari TextBox
            string country = input_negara.Text;
            string port = input_pelabuhan.Text;
            string hsCode = input_code.Text;
            decimal price = decimal.Parse(input_harga.Text);

            // Ambil kode negara
            string countryCode = await _apiForm.GetCountryCode(country);

            // Ambil kode pelabuhan
            string portCode = await _apiForm.GetPortCode(countryCode, port);

            // Ambil kode produk
            string productCode = await _apiForm.GetProductCode(hsCode);
            input_barangdetail.Text = productCode;

            // Ambil tarif Bea Masuk
            decimal tariffRate = await _apiForm.GetTariffRate(hsCode);
            input_tarif.Text = tariffRate.ToString();

            // Hitung total Bea Masuk
            decimal totalTariff = price * tariffRate;

            // Tampilkan hasil di Label
            input_hasil.Text = $"{totalTariff}";
        }

    }
}
