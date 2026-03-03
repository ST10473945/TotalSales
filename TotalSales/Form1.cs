namespace TotalSales
{
    public partial class frmTotalSales : Form
    {
        public frmTotalSales()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            //Implement try catch
            try
            {
                //create a 1D array that will read from the text file
                string[] allLines = File.ReadAllLines("Sales.txt");
                double[] sales = new double[allLines.Length];
                double sum = 0;
                int counter = 0;

                //for each loop to convert strings to double
                foreach (string line in allLines)
                {
                    //convert string to double
                    sales[counter] = Convert.ToDouble(line);
                    
                    //calculate sum
                    sum += sales[counter];

                    //Display the current value in the list box
                    lstDisplay.Items.Add($"{sales[counter]:C}");

                    //increment counter
                    counter++;
                }

                //display sum
                lstDisplay.Items.Add($"Total Sales: {sum:C}");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
