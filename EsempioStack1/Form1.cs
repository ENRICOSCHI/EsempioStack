using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsempioStack1
{
    public partial class Form1 : Form
    {//push==inserire
     //pop=rimuovo
        Stack s;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if(s.push(txtTarga.Text, Int32.Parse(txtCilindrata.Text)))//se ritorna true
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("Stack Pieno");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = new Stack();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            string result = s.pop();
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show("OK,string salvata");
            }
            else
            {
                MessageBox.Show("Stack vuoto");
            }
           // txtStampa.Text = s.toString();
        }
    }
    class Automobile
    {
        protected string targa;
        protected int cilindrata;
        public Automobile(string t, int c)
        {
            targa = t;
            cilindrata = c;
        }
        public string getTarga()
        {
            return targa;
        }
        public int getCilindrata()
        {
            return cilindrata;
        }
    }
    class Stack
    {
        protected int first;
        protected Automobile[] automobili;
        public Stack()
        {
            first = -1;
            automobili = new Automobile[100];
        }
        public bool push(string targa, int cilindrata)
        {
            bool result = false;
            if(first <= automobili.Length)
            {
                first++;//da mettere prima, deve aggiungere una parte di memoria 
                automobili[first] = new Automobile(targa, cilindrata);            
                result = true;
            }
            return result;
        }
        // restituisce la targa dell'automobile se presente, altrimenti stringa vuota
        public string pop()
        {
            string item = "";
            if(first >= 0)
            {            
               item = automobili[first].getTarga();//salvo la stringa che sto per togliere
                automobili[first] = null;
                first--;//Ritorna indietro l'array(il contenitore)

            }
            return item;
        }
        public string toString()
        {
            string result = "";
            for(int i = 0; i <= first; i++)
            {
                result += "targa: " + automobili[i].getTarga();
                result += " cilindrata: " + automobili[i].getCilindrata() + "\n";
            }
            return result;
        }
    }
    class Vettura
    {
        protected string targa;
        protected int cilindrata;
        protected Vettura next;
        public  Vettura(string targa,int cilindrata)
        {
            this.targa = targa; 
            this.cilindrata = cilindrata;
            next = null;
        }
        public string getTarga()
        {
            return targa;
        }
        public int GetCilindrata()
        {
            return cilindrata;
        }
        public void SetNext(Vettura v)
        {
            next = v;
        }
        public Vettura getNext()
        {
            return next;
        }
    }
    class Pila
    {
        protected Vettura first;
        protected int nnodi;
        public Pila()
        {
            nnodi = 0;
            first = null;
        }
        public void push(Vettura v)
        {
            if(nnodi == 0)
            {
                first = v;
                nnodi++;
            }
            else
            {
                v.SetNext(first);
                first = v.getNext();
                nnodi++;
            }
        }
        public Vettura pop()
        {
            Vettura v= null;
            if (nnodi != 0)
            {
                v = first;
                first = v.getNext();
                nnodi--;
            }
            return v;
        }
        public string TOString()
        {
            string s = "";
            Vettura v = first;
            if (v != null)
            {
                while (v != null)
                {
                    s += v.getTarga();
                    s += v.GetCilindrata();
                    v = v.getNext();
                }
            }
            return s;
        }
    }
}
