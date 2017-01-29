using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//App name : mail order calculation
//Author's Name  : Subham Salaria (200333595)
//App Creation Date : January 23,2017
//App Description : To calculate sales Bonus 

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private double _percentageOfHoursWorked;
        private double _totalBonusAmount;
        private double _salesBonus;
        // initialize the constructor
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for all radio Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton option = sender as RadioButton;

            //initialize the three different languages English,french and spanish

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

        //Calculates the  SalesBonus for each employee

        private void CalculateButton_Click()
        {

            try
            {
                if (Convert.ToDouble(HoursWorkedTextBox.Text) > 0 && Convert.ToDouble(HoursWorkedTextBox.Text) <= 160)
                {

                    this._percentageOfHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text) / 160;
                    if (TotalSalesTextBox.Text.Substring(0, 1) == "$")
                    {
                        this._totalBonusAmount = Convert.ToDouble(TotalSalesTextBox.Text.Substring(1)) * 0.02;
                    }
                    else
                    {
                        this._totalBonusAmount = Convert.ToDouble(TotalSalesTextBox.Text) * 0.02;
                        TotalSalesTextBox.Text = "$" + TotalSalesTextBox.Text;
                    }

                    this._salesBonus = this._percentageOfHoursWorked * this._totalBonusAmount;
                    SalesBonusTextBox.Text = this._salesBonus.ToString();

                }
                else
                {
                    MessageBox.Show("Hours Worked: Enter a value from 0 to 160");

                }


            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");


            }

        }
        //clears all fields
        private void clearAll()
        {
            EmployeesNameTextBox.Focus();
            EmployeesNameTextBox.Text = " ";
            EmployeeIDTextBox.Text = " ";
            HoursWorkedTextBox.Text = " ";
            SalesBonusTextBox.Text = "";
        }

        // Prints the Messsage 
        private void PrintButton_Click()
        {
            if ((SalesBonusTextBox.Text) != string.Empty)
                MessageBox.Show("The form is being sent to the printer. Thank you!");

            else
                MessageBox.Show("Please fill the form");
        }

        //When ever buttons are clicked this function will be executed
        private void Button_Click(object sender, EventArgs e)
        {
            Button click = sender as Button;

            switch (click.Tag.ToString())
            {
                case "calculate":
                    this.CalculateButton_Click();

                    break;
                case "print":
                    this.PrintButton_Click();
                    break;
                case "clear":
                    this.clearAll();
                    break;


            }
        }
    }
}
