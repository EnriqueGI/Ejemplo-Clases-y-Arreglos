using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        Persona[] arregoPersonas = new Persona[4];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona();
            oPersona.Cedula = int.Parse(textBoxCI.Text);
            oPersona.Nombre = textBoxNombre.Text;
            oPersona.Edad = int.Parse(textBoxEdad.Text);
            if(i< arregoPersonas.Length)
            {
                arregoPersonas[i] = oPersona;
                i++;
            }
            else
            {
                MessageBox.Show("Se superó el límite de personas");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int i = 0; i < arregoPersonas.Length; i++)
            {
                if(arregoPersonas[i] != null)
                {
                    ListViewItem itemsTabla = new ListViewItem();
                    itemsTabla.Text = arregoPersonas[i].Cedula.ToString();
                    itemsTabla.SubItems.Add(arregoPersonas[i].Nombre);
                    itemsTabla.SubItems.Add(arregoPersonas[i].Edad.ToString());
                    listView1.Items.Add(itemsTabla);
                }
                
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonasMayores();
        }

        public void PersonasMayores()
        {

            listView1.Items.Clear();
            for (int i = 0; i < arregoPersonas.Length; i++)
            {
                if (arregoPersonas[i] != null && arregoPersonas[i].Edad > 18)
                    {
                        ListViewItem itemsTabla = new ListViewItem();
                        itemsTabla.Text = arregoPersonas[i].Cedula.ToString();
                        itemsTabla.SubItems.Add(arregoPersonas[i].Nombre);
                        itemsTabla.SubItems.Add(arregoPersonas[i].Edad.ToString());
                        listView1.Items.Add(itemsTabla);
                    }


                }

            }
        }
    }
