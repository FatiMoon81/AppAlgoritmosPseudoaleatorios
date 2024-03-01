using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppAlgoritmosPseudoaleatorios
{
    public partial class Form1 : Form
    {
        //Se crea una lista que contenga los números calculados
        List<int> pseudoaleatorios = new List<int>();
        int algoritmo = 1;
        public Form1()
        {
            InitializeComponent();
        }

        #region general

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            switch (algoritmo)
            {
                case 1://cuadrados medios
                    AlgoCuadradosMedios();
                    break;
                case 2://lineal
                    AlgoLineal();
                    break;
                case 3://cuadratico
                    AlgoCuadratico();
                    break;
            }
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

        private void lineal()
        {
            VerificarOpcSeleccionada(AlgoritmosGroupBox);

            /*los numeros del textBox estan en tipo "string" (texto), hay que convertirlos a
              int (numeros) para hacer operaciones con ellos */

            try
            {
                int x = int.Parse(xTextBox.Text);
                int a = int.Parse(aTextBox.Text);
                int c = int.Parse(cTextBox.Text);
                int m = int.Parse(mTextBox.Text);
                //se agrega x inicial a la lista
                pseudoaleatorios.Add(x);
                //decimal r;
                //este guarda si x ya se repitió
                bool repetido;
                decimal r;
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
                        //se imprime el nuevo número en la caja de texto
                        //rTextBox.AppendText(x + "\r\n");
                        r = x / 100;
                        rTextBox.AppendText(r.ToString() + "\r\n");
                    }
                }
                //si el número no está repetido, se repite el código
                while (repetido == false);

                //cuando se repite pasa a lo siguiente
                //imprime la cantidad de números que se calcularon
                cantidadTextBox.Text = pseudoaleatorios.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                //se limpian todos los textbox para el siguiente calculo
                Limpiar();
            }
        }


        private void Limpiar()
        {
            //borra los resultados del textbox
            rTextBox.Text = string.Empty;
            //borra los resultados de la lista
            pseudoaleatorios.Clear();
        }

        private bool areEmpty()
        {
            bool empty = false;
            empty = string.IsNullOrEmpty(xTextBox.Text);
            empty = string.IsNullOrEmpty(aTextBox.Text);
            empty = string.IsNullOrEmpty(cTextBox.Text);
            empty = string.IsNullOrEmpty(mTextBox.Text);
            return empty;
        }

        private void VerificarOpcSeleccionada(GroupBox opciones)
        {

            // Itera a través de todos los controles dentro del GroupBox
            foreach (Control control in opciones.Controls)
            {
                // Verifica si el control es un RadioButton y está marcado
                if (control is RadioButton && ((RadioButton)control).Checked)
                {
                    // Si se encuentra un RadioButton seleccionado, muestra un mensaje
                    MessageBox.Show("Algoritmo seleccionado");
                    return; // Termina la verificación después de encontrar un RadioButton seleccionado
                }
            }
            // Si ningún RadioButton está seleccionado, muestra un mensaje
            MessageBox.Show("Seleccione un algoritmo.");
        }

        #endregion

        #region cuadrados medios

        private void AlgoCuadradosMedios()
        {
            //el try es utilizado como manera segura de correr las instrucciones,
            //ayuda a que no 'crashee' el programa si algun error logico humano ocurre.
            try
            {
                //definimos variables
                long y;
                //obtenemos la semilla y la llamamos 'x'.
                long x = long.Parse(xTextBox.Text);
                //obtenemos el largo de la semilla.
                int d = x.ToString().Length;
                //
                decimal r;
                //
                bool repetido;

                //Verificamos que la semilla tenga 4 digitos o mas.
                if (!(d > 3))
                {
                    //de lo contrario mostramos el mensaje, vaciamos la casilla y regresamos a menu.
                    MessageBox.Show("Ingrese una semilla de al menos 4 digitos.");
                    xTextBox.Text = string.Empty;
                    return;
                }

                //Ya podemos empezar a hacer calculos, agregamos la semilla a la lista
                pseudoaleatorios.Add((int)x);

                do
                {
                    (x,y) = ObtenerSiguienteNumero(x,d);
                    repetido = pseudoaleatorios.Contains((int)x);

                    if (repetido == false)
                    {
                        //se agrega el nuevo número a la lista
                        pseudoaleatorios.Add((int)x);
                        //se obtiene r
                        r = (decimal)x / 10000;
                        //se imprime el cuadrado de nuestra raiz, laseleccion del medio de la raiz y r
                        rTextBox.AppendText($"{y.ToString().PadRight(10)} | {x.ToString().PadRight(10)} | {r}\r\n");


                        //rTextBox.AppendText(y + " |\t " + x + " |\t " +r.ToString() + "\r\n");
                    }
                }
                while (repetido == false);
                cantidadTextBox.Text = pseudoaleatorios.Count.ToString();
            }
            catch (Exception e){
                //mostramos el mensaje de error generado
                MessageBox.Show("Error: " + e.Message);
            }

            
        }

        public Tuple <long,long> ObtenerSiguienteNumero(long x, int d)
        {
            long y = x * x;
            string yStr = y.ToString();
            int n = yStr.Length;

            // Verificar si la cantidad de digitos de nuestro numero al cuadrado es impar o si nuestros digitos n son menores que los digitos de nuestra semilla/'x'
            while (n % 2 != 0 || n < d)
            {
                // Agregar ceros a la izquierda para hacer el cuadrado de longitud par
                yStr = "0" + yStr;
                n++; // Incrementar la longitud después de agregar un cero
            }

            //creamos una nueva subcadena de valores de largo d
            yStr = yStr.Substring((n - d) / 2, d); // Utiliza (n - d) / 2 como índice de inicio
            x = long.Parse(yStr);
            return Tuple.Create(x,y);
        }


        #endregion

        #region congruencial cuadratico
        private void AlgoCuadratico()
        {
            int x=0;
            int a=0;
            int b = 0;
            int c = 0;
            int m = 0;
            bool repetir;
            do
            {
                if (areEmpty() || string.IsNullOrEmpty(bTextBox.Text))
                {
                    repetir = true;
                    MessageBox.Show("Llenar todas las casillas");
                    return;
                }
                else
                {
                    repetir = false;
                    x = int.Parse(xTextBox.Text);
                    a = int.Parse(aTextBox.Text);
                    b = int.Parse(bTextBox.Text);
                    c = int.Parse(cTextBox.Text);
                    m = int.Parse(mTextBox.Text);
                }
            }
            while (repetir);
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
                x = (a * (int)Math.Pow(x, 2) + b * x + c) % m;
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
        #endregion

        #region algoritmo lineal
        private void AlgoLineal()
        {
            //se declaran variables
            int x = 0;
            int a = 0;
            int c = 0;
            int m = 0;
            bool repetir;
            do
            {
                if (areEmpty())
                {
                    repetir = true;
                    MessageBox.Show("Llenar todas las casillas");
                    return;
                }
                else
                {
                    repetir = false;
                    /*los numeros del textBox estan en tipo "string" (texto), hay que convertirlos a
              int (numeros) para hacer operaciones con ellos */
                    x = int.Parse(xTextBox.Text);
                    a = int.Parse(aTextBox.Text);
                    c = int.Parse(cTextBox.Text);
                    m = int.Parse(mTextBox.Text);
                }
            }
            while (repetir);
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
        #endregion
    }
}
