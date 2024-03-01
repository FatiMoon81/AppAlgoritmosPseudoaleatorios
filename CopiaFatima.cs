using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppAlgoritmosPseudoaleatorios
{
    public partial class CopiaFatima : Form
    {
        //Se crea una lista que contenga los números calculados
        List<int> pseudoaleatorios = new List<int>();
        int algoritmo = 1;
        public CopiaFatima()
        {
            InitializeComponent();
        }

        #region general

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            switch (algoritmo)
            {
                case 1://cuadrados medios

                    break;
                case 2://lineal
                    AlgoLineal();
                    break;
                case 3://cuadratico
                    AlgoCuadratico();
                    break;
            }
        }

        private void AlgoLineal()
        {
            Limpiar();
            /*los numeros del textBox estan en tipo "string" (texto), hay que convertirlos a
              int (numeros) para hacer operaciones con ellos */
            int x = int.Parse(xTextBox.Text);
            int a = int.Parse(aTextBox.Text);
            int c = int.Parse(cTextBox.Text);
            int m = int.Parse(mTextBox.Text);
            //se agrega x inicial a la lista
            pseudoaleatorios.Add(x);
            decimal r;
            //este guarda si x ya se repitió
            bool repetido;
            /*el codigo se ejecutará una primera vez, y después se seguirá ejecutando
            mientras se cumpla la condicion while*/
            do
            {
                //fórmula del algoritmo. % es igual a mod
                x = (a * x + c) % m;
                //esta función revisa si la raiz generada ya existe en la lista
                //si existe, repetido = true. Si no, repetido = false
                repetido = pseudoaleatorios.Contains(x);
                //si no está repetido, hace lo siguiente
                if (repetido == false)
                {
                    //se agrega el nuevo número a la lista
                    pseudoaleatorios.Add(x);

                    r = (decimal)x / 100;
                    //se imprime el nuevo número en la caja de texto
                    rTextBox.AppendText(r.ToString() + "\r\n");
                }
            }
            //si el número no está repetido, se repite el código
            while (repetido == false);
            //cuando se repite pasa a lo siguiente
            //imprime la cantidad de números que se calcularon
            cantidadTextBox.Text = pseudoaleatorios.Count.ToString();
        }

        private void AlgoCuadratico()
        {
            Limpiar();
            /*los numeros del textBox estan en tipo "string" (texto), hay que convertirlos a
              int (numeros) para hacer operaciones con ellos */
            int x = int.Parse(xTextBox.Text);
            int a = int.Parse(aTextBox.Text);
            int b = int.Parse(bTextBox.Text);
            int c = int.Parse(cTextBox.Text);
            int m = int.Parse(mTextBox.Text);
            //se agrega x inicial a la lista
            pseudoaleatorios.Add(x);
            decimal r;
            //este guarda si x ya se repitió
            bool repetido;
            /*el codigo se ejecutará una primera vez, y después se seguirá ejecutando
            mientras se cumpla la condicion while*/
            do
            {
                //fórmula del algoritmo. % es igual a mod
                x = (a*(int)Math.Pow(x,2)+b*x+c)%m;
                //esta función revisa si la raiz generada ya existe en la lista
                //si existe, repetido = true. Si no, repetido = false
                repetido = pseudoaleatorios.Contains(x);
                //si no está repetido, hace lo siguiente
                if (repetido == false)
                {
                    //se agrega el nuevo número a la lista
                    pseudoaleatorios.Add(x);

                    r = (decimal)x / 100;
                    //se imprime el nuevo número en la caja de texto
                    rTextBox.AppendText(r.ToString() + "\r\n");
                }
            }
            //si el número no está repetido, se repite el código
            while (repetido == false);
            //cuando se repite pasa a lo siguiente
            //imprime la cantidad de números que se calcularon
            cantidadTextBox.Text = pseudoaleatorios.Count.ToString();
        }

        private void mediosRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mediosRButton.Checked == true)
            {
                aTextBox.Visible = false;
                bTextBox.Visible = false;
                cTextBox.Visible = false;
                mTextBox.Visible = false;
                aLabel.Visible = false;
                bLabel.Visible = false;
                cLabel.Visible = false;
                mLabel.Visible = false;
                algoritmo = 1;
            }
        }

        private void linealRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (linealRButton.Checked == true)
            {
                aTextBox.Visible = true;
                bTextBox.Visible = false;
                cTextBox.Visible = true;
                mTextBox.Visible = true;
                aLabel.Visible = true;
                bLabel.Visible = false;
                cLabel.Visible = true;
                mLabel.Visible = true;
                algoritmo = 2;
            }
        }

        private void cuadraticoRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cuadraticoRButton.Checked == true)
            {
                aTextBox.Visible = true;
                bTextBox.Visible = true;
                cTextBox.Visible = true;
                mTextBox.Visible = true;
                aLabel.Visible = true;
                bLabel.Visible = true;
                cLabel.Visible = true;
                mLabel.Visible = true;
                algoritmo = 3;
            }
        }



        private void Limpiar()
        {
            //borra los resultados del textbox
            rTextBox.Text = string.Empty;
            //borra los resultados de la lista
            pseudoaleatorios.Clear();
        }


        #endregion

        #region cuadrados medios



        #endregion

        #region congruencial cuadratico
        #endregion

        #region algoritmo lineal
        #endregion
    }
}
