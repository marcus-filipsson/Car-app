using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_app
{
    public partial class Form1 : Form
    {
        Database dbObject = new Database();
        public Form1()
        {
            InitializeComponent();
            InitListView();
            txtRegNr.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNr.Text) || string.IsNullOrEmpty(txtMake.Text))
            {
                MessageBox.Show("Du måste fylla i alla rutor", "Felaktig inmatning");
            }
            else

            {
                Car car = new Car(txtRegNr.Text, txtMake.Text, txtModel.Text, Convert.ToInt32(txtYear.Text), cbxForSale.Checked);
                AddCarToListView(car);

                int result = dbObject.AddCarRow(car);
                MessageBox.Show("Du har lagt till" + Convert.ToString(result) + "antal bilar");
                ClearTextboxes();
                btnClear.Enabled = true;
            }
        }

        private void AddCarToListView(Car car)
        {
            ListViewItem item = CreateListViewItem(car);
            lsvCars.Items.Add(item);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCars.SelectedItems.Count > 0)
            {
                var item = lsvCars.SelectedItems[0];
                lsvCars.Items.Remove(item);
                MessageBox.Show("Bilen med registreringsnummer " + item.Text + " är borttagen", "Borttag av bil");
            }
            else
            {
                MessageBox.Show("Ingen bil var markerad att tas bort", "borttag av bil");
            }
            btnClear.Enabled = (lsvCars.Items.Count > 0);

        }

        private void lsvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lsvCars.SelectedItems.Count > 0);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsvCars.Items.Clear();
            txtRegNr.Focus();
        }

        private ListViewItem CreateListViewItem(Car car)
        {
            ListViewItem item = new ListViewItem(car.GetRegNr());
            item.SubItems.Add(car.GetMake());
            item.SubItems.Add(car.GetModel());
            item.SubItems.Add(car.GetForSale() ? "Yes" : "No");
            return item;
        }

        private void ClearTextboxes()
        {
            txtRegNr.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            cbxForSale.Checked = false;
            txtRegNr.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRegNr.Text))
            {
                txtRegNr.Text = txtRegNr.Text.ToUpper();
                PrintData(txtRegNr.Text);
            }
            else
            {
                MessageBox.Show("Du måste ange ett registreringsnummer", "Inmatning Saknas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void InitListView()
        {
            List<Car> listOfCars = dbObject.GetRowsFromCars();
            foreach (var item in listOfCars)
            {
                AddCarToListView(item);
            }
        }

        private void PrintData(string regNr)
        {
            string token = "ZYdERdMQ1BLgQ9DP6hwZpO7ScLeXcJUm";
            string call = String.Format($"https://api.biluppgifter.se/api/v1/vehicle/regno/{regNr}?api_token={token}");

            try
            {
                WebRequest request = HttpWebRequest.Create(call);

                WebResponse response = request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string carJSON = reader.ReadToEnd();

                JObject jsonCar = JObject.Parse(carJSON);

                txtMake.Text = jsonCar["data"]["basic"]["data"]["make"].ToString();

                txtModel.Text = jsonCar["data"]["basic"]["data"]["model"].ToString();

                txtYear.Text = jsonCar["data"]["basic"]["data"]["model_year"].ToString();

            }
            catch (Exception e)
            {

                MessageBox.Show($"Bil med registreringsnummer {regNr} kunde inte hittas\n\nMeddelande: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
