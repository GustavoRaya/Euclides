using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsi_Click(object sender, EventArgs e)
        {
            int a, b,temp,i=1,res,es;
            a = int.Parse(Txtm.Text);
            b= int.Parse(Txtn.Text);
             while(b!=0)
            {
                temp = b;
                res= a%b;
                es= a/b;
                if (res!=0)
                {
                    DGWres.Rows.Add(i.ToString(), a.ToString() + " Dividido entre " + b.ToString() + " es " + es.ToString() + " y sobran " + res.ToString(), a.ToString() + "/" + b.ToString() + " = " + es.ToString() + " + 1/" + b.ToString() + "/" + res.ToString());
                }
                else
                {
                    DGWres.Rows.Add(i.ToString(), a.ToString() + " Dividido entre " + b.ToString() + " es " + es.ToString() + " y sobran " + res.ToString(), a.ToString() + "/" + b.ToString() + " = " + es.ToString());
                }
                
                b = a%b; 
                a = temp;
                i++;
                
            }
           
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Txtm.Text = "";
            Txtn.Text = "";
            Txtm.Focus();
            DGWres.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
