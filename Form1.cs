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
        //este es para guardar que algoritmo se esta usando en el momento
        //1=cuadrados medios, 2=lineal, 3=cuadratico
        int algoritmo = 1;
        public Form1()
        {
            InitializeComponent();
        }

        #region general

        private void Reiniciar()
        {
            //borra los resultados del textbox
            rTextBox.Text = string.Empty;
            //borra los resultados de la lista
            pseudoaleatorios.Clear();
        }

        //esta funcion se activa cada que se le da click al boton calcular
        private void CalcularButton_Click(object sender, EventArgs e)
        {
            //try sirve para que detecte errores cuando se ingresan mal los números sin que el programa crashee
            try
            {
                Reiniciar();
                //dependiendo del valor de algoritmo correrá una de las tres funciones
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
            //catch indica que hace si hay error, en este caso, mostrar un mensaje al usuario
            catch (System.OverflowException)
            {
                MessageBox.Show("Ingrese un número más pequeño");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Limpiar();
            }
            

        }

        //se activa cuando el radio button pasa de seleccionado a no seleccionado o visceversa
        private void mediosRButton_CheckedChanged(object sender, EventArgs e)
        {
            //el codigo solo corre si el radio button esta seleccionado
            if (mediosRButton.Checked == true)
            {
                //esconde las textbox y las etiquetas que no se utilizan para este algoritmo
                aTextBox.Visible = false;
                bTextBox.Visible = false;
                cTextBox.Visible = false;
                mTextBox.Visible = false;
                aLabel.Visible = false;
                bLabel.Visible = false;
                cLabel.Visible = false;
                mLabel.Visible = false;
                //cambia cual algoritmo es el que se está usando
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

        //revisa que las textbox no esten vacias
        private bool areEmpty()
        {
            //el valor default es que no estan vacias (false)
            bool empty = false;
            //IsNullOrEmpty checa si esa casilla esta vacia. si es asi, cambiará a true
            if(string.IsNullOrEmpty(xTextBox.Text))
                empty = true;
            if (string.IsNullOrEmpty(aTextBox.Text))
                empty = true;
            if (string.IsNullOrEmpty(cTextBox.Text))
                empty = true;
            if (string.IsNullOrEmpty(mTextBox.Text))
                empty = true;
            //regresará true=alguna vacia, o false=ninguna vacia
            return empty;
        }

        //este boton limpiará los textbox de variables
        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            xTextBox.Text = string.Empty;
            aTextBox.Text = string.Empty;
            bTextBox.Text = string.Empty;
            cTextBox.Text = string.Empty;
            mTextBox.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            pseudoaleatorios.Clear();
        }

        #endregion

        #region cuadrados medios

        private void AlgoCuadradosMedios()
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
                    MessageBox.Show("Ingrese una semilla de al menos 4 digitos. Los ceros a la izquierda no se cuentan");
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
                        //se imprime el cuadrado de nuestra raiz, la seleccion de enmedio de la raiz y r
                       

                        rTextBox.AppendText($"{y.ToString().PadRight(10)} | {x.ToString().PadRight(10)} | {r}\r\n");
                        //rTextBox.AppendText(y + " |\t " + x + " |\t " +r.ToString() + "\r\n");
                    }
                }//si se haya un numero repetido dentro de nuestra lista el codigo para
                while (repetido == false);
                //muestra la cantidad de numeros conenidos en nuestra lista
                cantidadTextBox.Text = pseudoaleatorios.Count.ToString();

        }

        public Tuple <long,long> ObtenerSiguienteNumero(long x, int d)
        {
            //inicializamos varaibles
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
            //se declaran las variables a usar
                int x = 0;
                int a = 0;
                int b = 0;
                int c = 0;
                int m = 0;
            // Aqui revisa si las casillas x, a, c, o m estan vacias, O (simbolo ||, or) si b esta vacia
                    if (areEmpty() || string.IsNullOrEmpty(bTextBox.Text))
                    {
                        //indica que alguna esta vacia                
                        MessageBox.Show("Llenar todas las casillas");
                        //sale de la funcion AlgoCuadratico(), ya no ejecuta el demás código
                        return;
                    }
                    else
                    {
                //si no estan vacias, guarda los valores de las casillas en la variables
                /*los numeros del textBox estan en tipo "string" (texto), hay que convertirlos a
      int (numeros) para hacer operaciones con ellos */
                        x = int.Parse(xTextBox.Text);
                        a = int.Parse(aTextBox.Text);
                        b = int.Parse(bTextBox.Text);
                        c = int.Parse(cTextBox.Text);
                        m = int.Parse(mTextBox.Text);
                    }
                //aqui se guarda el resultado ya dividido entre 100
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
                        //el resultado lo divide entre 100
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
            int x;
            int a;
            int c;
            int m;

            //revisa si alguna de las casillas esta vacia
            if (areEmpty())
                {
                    MessageBox.Show("Llenar todas las casillas");
                    return;
                }
                else
                {
                    /*los numeros del textBox estan en tipo "string" (texto), hay que convertirlos a
              int (numeros) para hacer operaciones con ellos */
                    x = int.Parse(xTextBox.Text);
                    a = int.Parse(aTextBox.Text);
                    c = int.Parse(cTextBox.Text);
                    m = int.Parse(mTextBox.Text);
                }
            //guarda resultado despues de dividirlo entre 100
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
