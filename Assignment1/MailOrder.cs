using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private double _percentageOfHoursWorked;
        private double _totalBonusAmount;
        private double _salesBonus;
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton option = sender as RadioButton;

            switch (option.Tag.ToString())
            {
                case "english":
                    this.label2.Text = "Employee\'s Name :";
                    this.label3.Text = "Employee Id :";
                    this.label4.Text = "Hours Worked :";
                    this.label5.Text = "Total Sales :";
                    this.label6.Text = "Sales Bonus :";
                    this.button1.Text = "Calculate";
                    this.button3.Text = "Clear";
                    this.button2.Text = "Print";
                    this.groupBox1.Text = "Languages";
                    break;
                case "french":
                    this.label2.Text = "Le nom de l'employé :";
                    this.label3.Text = "Employé ID :";
                    this.label4.Text = "Heures travaillées :";
                    this.label5.Text = "Ventes totales :";
                    this.label6.Text = "Bonus de vente :";
                    this.button1.Text = "Calculer";
                    this.button3.Text = "Prochain";
                    this.button2.Text = "Impression";
                    this.groupBox1.Text = "Langues";
                    break;
                case "spanish":
                    this.label2.Text = "Nombre del empleado :";
                    this.label3.Text = "ID de empleado : ";
                    this.label4.Text = "Horas trabajadas :";
                    this.label5.Text = "Ventas totales :";
                    this.label6.Text = "Bono de ventas: ";
                    this.button1.Text = "Calcular";
                    this.button3.Text = "Prochain";
                    this.button2.Text = "Impresión";
                    this.groupBox1.Text = "Idiomas";
                    break;
            }

        }

        //Calculates the Sales Bonus

        private void CalculateButton_Click()
        {

            try
            {
                if (Convert.ToDouble(HoursWorkedTextBox.Text) > 0 && Convert.ToDouble(HoursWorkedTextBox.Text) <= 160)
                {

                    
                }
               


            }
            catch (Exception exception)
            {
                
            }

        }
        

        // Prints the Messsage 
        private void PrintButton_Click()
        {
            if ((SalesBonusTextBox.Text) != string.Empty)
                MessageBox.Show("The form is being sent to the printer. Thank you!");

            
        }

        //When ever buttons are clicked this function will be executed
        private void Button_Click(object sender, EventArgs e)
        {
            Button click = sender as Button;

            switch (click.Tag.ToString())
            {
                case "calculate":
                   

                    break;
                case "print":
                   
                    break;
                case "clear":
                    
                    break;


            }
        }
    }
}
