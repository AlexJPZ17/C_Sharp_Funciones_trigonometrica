using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Función_trigonométrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Trigonometria()
        {
            //Declaro 6 variables de tipo doublé
            double adyacente, hipotenusa, opuesto, a, b, r;
            //Condición que evalúa el RadioButton si es seleccionado
            if (RadioButton_Adyacente.Checked)
            {
                //Condición que evalúa los TextBox si estos están vacíos
                if (TextBox_Hipotenusa.Text == "")
                {
                    MessageBox.Show("Ingrese un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Coloca el Focus en el TextBox_Hipotenusa
                    TextBox_Hipotenusa.Focus();
                }
                else
                {
                    //Condición que evalúa los TextBox si estos están vacíos
                    if (TextBox_Opuesto.Text == "")
                    {
                        MessageBox.Show("Ingrese un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Coloca el Focus en el TextBox_Opuesto
                        TextBox_Opuesto.Focus();
                    }
                    else
                    {
                        /* Para sacar el Adyacente
                             Funciones que convierte en un tipo doublé el valor que se ingrese por 
                             los TextBox y lo almacena en la variable opuesto y hipotenusa */
                        hipotenusa = Convert.ToDouble(TextBox_Hipotenusa.Text);
                        opuesto = Convert.ToDouble(TextBox_Opuesto.Text);
                        /* Eleva al cuadrado el dato almacenado en las variable 
                               opuesto y hipotenusa y loa almacena  en las variables a,b */
                        a = Math.Pow(hipotenusa, 2);
                        b = Math.Pow(opuesto, 2);
                        //Resta los datos almacenado en las variables a, b
                        r = a - b;
                        /*  Saca la raíz cuadrada del dato almacenado en la variable r y lo 
                             almacena en la variable adyacente */
                        adyacente = Math.Sqrt(r);
                        MessageBox.Show("El lado adyacente es  : " + adyacente + " Cm");
                    }
                }
            }
            else  //Del RadioButton_Adyacente
            {
                //Condición que evalúa el RadioButton si es seleccionado
                if (RadioButton_Hipotenusa.Checked)
                {
                    //Condición que evalúa los TextBox si estos están vacíos
                    if (TextBox_Adyacente.Text == "")
                    {
                        MessageBox.Show("Ingrese un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Coloca el Focus en el TextBox_Adyacente
                        TextBox_Adyacente.Focus();
                    }
                    else
                    {
                        //Condición que evalúa los TextBox si estos están vacíos
                        if (TextBox_Opuesto.Text == "")
                        {
                            MessageBox.Show("Ingrese un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Coloca el Focus en el TextBox_Opuesto
                            TextBox_Opuesto.Focus();
                        }
                        else
                        {
                            /* Para sacar la hipotenusa
                                 Funciones que convierte en un tipo doublé el valor que se ingrese por 
                                 los TextBox y lo almacena en la variable opuesto yadyacente */
                            adyacente = Convert.ToDouble(TextBox_Adyacente.Text);
                            opuesto = Convert.ToDouble(TextBox_Opuesto.Text);
                            /* Eleva al cuadrado el dato almacenado en las variable 
                                   opuesto y adyacente y lo almacena  en las variables a,b */
                            a = Math.Pow(adyacente, 2);
                            b = Math.Pow(opuesto, 2);
                            //Suma de los datos almacenado en las variables a, b
                            r = a + b;
                            /*  Saca la raíz cuadrada del dato almacenado en la variable r y lo 
                                 almacena en la variable hipotenusa */
                            hipotenusa = Math.Sqrt(r);
                            MessageBox.Show("La hipotenusa es  : " + hipotenusa + " Cm");
                        }
                    }
                }
                else  //Del RadioButton_Hipotenusa
                {
                    //Condición que evalúa el RadioButton si es seleccionado
                    if (RadioButton_Opuesto.Checked)
                    {
                        //Condición que evalúa los TextBox si estos están vacíos
                        if (TextBox_Hipotenusa.Text == "")
                        {
                            MessageBox.Show("Ingrese un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Coloca el Focus en el TextBox_Hipotenusa
                            TextBox_Hipotenusa.Focus();
                        }
                        else
                        {
                            //Condición que evalúa los TextBox si estos están vacíos
                            if (TextBox_Adyacente.Text == "")
                            {
                                MessageBox.Show("Ingrese un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Coloca el Focus en el TextBox_Adyacente
                                TextBox_Adyacente.Focus();
                            }
                            else
                            {
                                /* Para sacar el lado opuesto 
                                     Funciones que convierte en un tipo doublé el valor que se ingrese por 
                                     los TextBox y lo almacena en la variable hipotenusa y adyacente */
                                hipotenusa = Convert.ToDouble(TextBox_Hipotenusa.Text);
                                adyacente = Convert.ToDouble(TextBox_Adyacente.Text);
                                /* Eleva al cuadrado el dato almacenado en las variable 
                                       opuesto y adyacente y lo almacena  en las variables a,b */
                                a = Math.Pow(hipotenusa, 2);
                                b = Math.Pow(adyacente, 2);
                                //Resta de los datos almacenado en las variables a, b
                                r = a - b;
                                /*  Saca la raíz cuadrada del dato almacenado en la variable r y lo 
                                     almacena en la variable opúesto */
                                opuesto = Math.Sqrt(r);
                                MessageBox.Show("El lado Opuesto es  :  " +opuesto + " Cm");
                            }
                        }
                    }
                    else  //Del RadioButton_Opuesto
                    {

                    }
                }
            }
        }

        private void RadioButton_Adyacente_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_Adyacente.Visible = false;
            TextBox_Hipotenusa.Visible = true;
            TextBox_Opuesto.Visible = true;
            TextBox_Hipotenusa.Text = "";
            TextBox_Opuesto.Text = "";

        }

        private void RadioButton_Hipotenusa_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_Adyacente.Visible = true;
            TextBox_Hipotenusa.Visible = false;
            TextBox_Opuesto.Visible = true;
            TextBox_Adyacente.Text = "";
            TextBox_Opuesto.Text = "";

        }

        private void RadioButton_Opuesto_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_Adyacente.Visible = true;
            TextBox_Hipotenusa.Visible = true;
            TextBox_Opuesto.Visible = false;
            TextBox_Hipotenusa.Text = "";
            TextBox_Adyacente.Text = "";

        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            Trigonometria();
        }
    }
}
