/*
 * scot mclean
 * 1, 24, 2017
 * get's calculates the sales bonus for employees.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_w2017_project1
{
    public partial class DaveFurnitureStore : Form
    {
        public DaveFurnitureStore()
        {
            InitializeComponent();
        }
        /*
         * event handler for the french radio button, it replaces the text for all the labels to french
         */
        private void frenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmpNameLabel.Text = "Nom de l'employé";
            EmpIdLabel.Text = "Employé ID";
            TotalHoursLabel.Text = "Total des heures travaillées";
            MonSalesLabel.Text = "Ventes mensuelles totales";
            SalesBonusLabel.Text = "Bonus de vente";
            LanguageGroupBox.Text = "La langue";
            EnglishRadioButton.Text = "Anglais";
            FrenchRadioButton.Text = "français";
            SpanishRadioButton.Text = "Espanol";
            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Impression";
            ClearButton.Text = "Prochain";
        }
        /*
         * event handler for the english radio button, it replaces the text for all the labels to english
         */
        private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmpNameLabel.Text = "Employee Name";
            EmpIdLabel.Text = "Employee ID";
            TotalHoursLabel.Text = "Total Hours Worked";
            MonSalesLabel.Text = "Total Monthly Sales";
            SalesBonusLabel.Text = "Sales Bonus";
            LanguageGroupBox.Text = "Language";
            EnglishRadioButton.Text = "English";
            FrenchRadioButton.Text = "French";
            SpanishRadioButton.Text = "Spanish";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            ClearButton.Text = "Next";
        }
        /*
         * event handler for the spanish radio button, it replaces the text for all the labels to french
         */
        private void spanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmpNameLabel.Text = "Nombre de empleado";
            EmpIdLabel.Text = "ID de empleado";
            TotalHoursLabel.Text = "Total de horas trabajadas";
            MonSalesLabel.Text = "Total de ventas mensuales";
            SalesBonusLabel.Text = "Bono de ventas";
            LanguageGroupBox.Text = "Idioma";
            EnglishRadioButton.Text = "Inglés";
            FrenchRadioButton.Text = "francés";
            SpanishRadioButton.Text = "Español";
            CalculateButton.Text = "Calcular";
            PrintButton.Text = "Impresión";
            ClearButton.Text = "Siguiente";
        }
        /*
         * event handler for the calculate button.
         * has the logic for the math to get the sales bonus.
         * also has a try catch to ensure that the fields cannot be entered incorrectly and give an error
         */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //converting the string to a double and making sure its between 0-160, if not print to the sales box 
                if (Convert.ToDouble(TotalHoursTextBox.Text) > 160 || Convert.ToDouble(TotalHoursTextBox.Text) <= 0)
                {   
                    
                    SalesBonusTextBox.Text = "Total hours must be between 0-160!";
                    TotalHoursTextBox.ForeColor = Color.Red;
                }
                else
                {
                    //if everthing is alright do the calculation and print to the sales bonus box
                    double percEarned = Convert.ToDouble(TotalHoursTextBox.Text) / 160;
                    double bonusAmount = Convert.ToDouble(MonSalesTextBox.Text) * 0.02;
                    double salesBonus = percEarned * bonusAmount;
                    //adding the $ to the sales bonus calculation
                    SalesBonusTextBox.Text = salesBonus.ToString("C2");
                    TotalHoursTextBox.BackColor = Color.White;
                    //make sure empidbox is an int
                    Convert.ToInt32(EmpIdTextBox.Text);
                }
            }
            catch
            //if there is an unexpected error anywhere it will print this out to the sales bonus box 
            {
                SalesBonusTextBox.Text = "One or more of your fields is not correct!";
            }
            
        }
        /*
         * event handler for the next button
         * clears all the fields except for the total monthly sales 
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            TotalHoursTextBox.Text = "";
            EmpNameTextBox.Text = "";
            EmpIdTextBox.Text = "";
            SalesBonusTextBox.Text = "";
            //setting the color back to white incase there was an error earlier 
            TotalHoursTextBox.ForeColor = Color.White;
        }
        /*
         * event handler for the print button
         * makes a message box that "shows sending to printer"
         */
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sendng to printer");
        }
    }
}
