
using Excel = Microsoft.Office.Interop.Excel;
namespace BPTest
{
    public partial class Form1 : Form
    {
         double totalPrice = 0;
         double totalTaxes = 0;


        List<object[]> table = new List<object[]>();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopMost = true;
            f2.Show();
            this.Focus();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(comboBoxCount.SelectedItem.ToString());
            double price = double.Parse(textBoxPrice.Text);
            string product = textBoxProduct.Text;

            table.Add(new object[] {product, amount, price });




            coverLetter();


            contentOutput.Text += "Produkt\t\t\tMenge\t\tUst. 19%\t\t\tPreis\t\tGesamt " + @"
            ";

            for (int i = 0; i < table.Count; i++)
            {
                printRow(i);
            }

            printShipping();



        }


        //function for default message
        void coverLetter()
        {
            string name = "Frau Test";
            string date = "01.01.1980";
           contentOutput.Text = "Hallo " + name + @",
bestätigung ihrer bestellung vom " + date + @".
anbei finden sie details zu ihrer Bestellung.

Vielen Dank und viel Spaß auf dem Turnier" + @"
           
             
            ";
        }

        //detail input
        void printRow(int rowNumber)
        {
            details((string)table[rowNumber][0], (int)table[rowNumber][1], (double)table[rowNumber][2]);
        }

        //function order detailscwin
         void details(string product, int amount, double price)
        {

            double total = amount * price;
            totalPrice = totalPrice + total;
            double taxes = total * 0.19;
            totalTaxes = totalPrice * 0.19;




           contentOutput.Text += product + "\t\t\t" + amount + "\t\t" + Math.Round(taxes, 2) + "€\t\t\t" + price + "€\t\t" + Math.Round(total, 2) + "€" + @"
            ";
        }

         void printShipping()
        {

            //shipping calc
            if (totalPrice > 50)
            {
                contentOutput.Text += "Versand \t\t\t\t\t\t\t\t\t" + 0 + "€" + @"
           
            ";
            }
            else
            {
                contentOutput.Text += "Versand \t\t\t\t\t" + Math.Round(4.99 * 0.19, 2) + "€\t\t\t\t\t" + 4.99 + "€" + @"
           
            ";
                totalPrice = totalPrice + 4.99;
                totalTaxes = totalTaxes + 4.99 * 0.19;
            }

           contentOutput.Text += "";

            //total sum
            contentOutput.Text += "Gesamt \t\t\t\t\t\t\t" + Math.Round(totalPrice, 2) + "€" + @"
            ";  //print total price
            contentOutput.Text += "Davon Ust. \t\t\t\t\t\t" + Math.Round(totalTaxes, 2) + "€" + @"
            "; //print total price

        }

       
    }
}