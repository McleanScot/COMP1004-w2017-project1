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

        private void frenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            empNameLabel.Text = "Nom de l'employé";
            empIdLabel.Text = "Employé ID";
            totalHoursLabel.Text = "Total des heures travaillées";
            monSalesLabel.Text = "Ventes mensuelles totales";
            salesBonusLabel.Text = "Bonus de vente";
            languageGroupBox.Text = "La langue";
            englishRadioButton.Text = "Anglais";
            frenchRadioButton.Text = "français";
            spanishRadioButton.Text = "Espanol";
            calculateButton.Text = "Calculer";
            printButton.Text = "Impression";
            clearButton.Text = "Clair";
        }

        private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            empNameLabel.Text = "Employee Name";
            empIdLabel.Text = "Employee ID";
            totalHoursLabel.Text = "Total Hours Worked";
            monSalesLabel.Text = "Total Monthly Sales";
            salesBonusLabel.Text = "Sales Bonus";
            languageGroupBox.Text = "Language";
            englishRadioButton.Text = "English";
            frenchRadioButton.Text = "French";
            spanishRadioButton.Text = "Spanish";
            calculateButton.Text = "Calculate";
            printButton.Text = "Print";
            clearButton.Text = "Clear";
        }

        private void spanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            empNameLabel.Text = "Nombre de empleado";
            empIdLabel.Text = "ID de empleado";
            totalHoursLabel.Text = "Total de horas trabajadas";
            monSalesLabel.Text = "Total de ventas mensuales";
            salesBonusLabel.Text = "Bono de ventas";
            languageGroupBox.Text = "Idioma";
            englishRadioButton.Text = "Inglés";
            frenchRadioButton.Text = "francés";
            spanishRadioButton.Text = "Español";
            calculateButton.Text = "Calcular";
            printButton.Text = "Impresión";
            clearButton.Text = "Claro";
        }
    }
}
