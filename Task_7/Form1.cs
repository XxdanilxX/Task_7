using System.Diagnostics.Metrics;

namespace Task_7
{
    enum Country
    {
        Nigerya,
        Japan,
        Ukraine,
        Kanada,
        Brazil,
        Avstraly
    }
    enum Continent
    {
        Africa,
        Asia,
        Europe,
        NorthAmerica,
        SouthAmerica,
        Australia
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int countryChoice = Convert.ToInt32(textBox1.Text);
            Country selectedCountry = (Country)(countryChoice - 1);
            Continent countryContinent = GetContinent(selectedCountry);

            textBox2.Text = "Країна: " + selectedCountry + "\r\nЗнаходиться в континенті: " + countryContinent;
            static Continent GetContinent(Country country)
            {
                switch (country)
                {
                    case Country.Nigerya:
                        return Continent.Africa;
                    case Country.Japan:
                        return Continent.Asia;
                    case Country.Ukraine:
                        return Continent.Europe;
                    case Country.Kanada:
                        return Continent.NorthAmerica;
                    case Country.Brazil:
                        return Continent.SouthAmerica;
                    case Country.Avstraly:
                        return Continent.Australia;
                    default:
                        throw new ArgumentException("Континент для вибраної країни не визначений.");
                }

            }
        }
    }
}