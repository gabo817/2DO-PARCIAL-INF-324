using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int cR, cG, cB;
        int cRt, cGt, cBt;


        private Color[] lista;
        private Color[] pintar = {Color.Violet,Color.Black,Color.Red,Color.Yellow,Color.Fuchsia,
            Color.Blue,Color.Cyan,Color.Magenta,Color.Pink,Color.LightGreen};
        private int[] contadores;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            c = bmp.GetPixel(0,0);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R; cG = c.G; cB=c.B;

            cRt = 0; cGt = 0; cBt = 0;
            for (int i = e.X; i<e.X+10; i++)
                for (int j = e.Y; j < e.Y + 10; j++)
                {
                    c = bmp.GetPixel(i, j);
                    cRt = c.R+cRt; cGt = c.G+cGt; cBt = c.B+cBt;
                }
            cRt = cRt / 100;
            cGt = cGt / 100;
            cBt = cBt / 100;
            textBox1.Text = c.R.ToString()+ " "+cRt.ToString();
            textBox2.Text = c.G.ToString()+ " "+cGt.ToString();
            textBox3.Text = c.B.ToString() + " " + cBt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for(int i=0;i<bmp.Width;i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
                }
            pictureBox2.Image = bmp2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
                }
            pictureBox2.Image = bmp2;
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 50; i < 100; i++)
                for (int j = 50; j < 100; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R!=cR)&&(c.G!=cG)&&(c.B!=cB))
                        bmp2.SetPixel(i, j, c);
                    else
                        bmp2.SetPixel(i, j, Color.Black);
                }
            pictureBox2.Image = bmp2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ( ((cR-10<=c.R) && (c.R<=cR+10)) && ((cG-10<=c.G) && (c.G<=cG+10)) && ((cB-10<=c.B) && (c.B<=cB+10)))
                        bmp2.SetPixel(i, j, Color.Black);
                    else
                        bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int cRto, cGto, cBto;
            Color c = new Color();
            for (int i = 0; i < bmp.Width-20; i=i+10)
                for (int j = 0; j < bmp.Height-20; j=j+10)
                {

                    cRto = 0; cGto = 0; cBto = 0;
                    for (int k = i; k < i +10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                        }
                    cRto = cRto / 100;
                    cGto = cGto / 100;
                    cBto = cBto / 100;
                    c = bmp.GetPixel(i, j);
                    if (((cRt - 10 <= cRto) && (cRto <= cRt + 10)) && ((cGto - 10 <= cGt) && (cGt <= cGto + 10)) && ((cBto - 10 <= cBt) && (cBt <= cBto + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                bmp2.SetPixel(k, l, Color.Black);
                            }
                    else
                        for (int k = i; k< i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp.GetPixel(k,l);
                                bmp2.SetPixel(k,l, c);
                            }
                }
            pictureBox2.Image = bmp2;
        }
        

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }
        private int inc=-1;
        private void paleta_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp1 = new Bitmap(paleta.Image);
            Color c1 = new Color();
            c1 = bmp1.GetPixel(e.X, e.Y);
            cR = c1.R; cG = c1.G; cB = c1.B;
            cRt = cR; cGt = cG; cBt = cB;
            inc++;
            if (inc>9)
            {
                inc = 0;
            }

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            int cRto, cGto, cBto;
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 20; i = i + 10)
                for (int j = 0; j < bmp.Height - 20; j = j + 10)
                {

                    cRto = 0; cGto = 0; cBto = 0;
                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                        }
                    cRto = cRto / 100;
                    cGto = cGto / 100;
                    cBto = cBto / 100;
                    c = bmp.GetPixel(i, j);
                    if (((cRt - 10 <= cRto) && (cRto <= cRt + 10)) && ((cGto - 10 <= cGt) && (cGt <= cGto + 10)) && ((cBto - 10 <= cBt) && (cBt <= cBto + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                bmp2.SetPixel(k, l, pintar[inc]);
                            }
                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp2.GetPixel(k, l);
                                bmp2.SetPixel(k, l, c);
                            }
                   
                }
            pictureBox2.Image = bmp2;

        }

        private void btn_clasificar_Click(object sender, EventArgs e)
        {
            Color c1= Color.FromArgb(3, 36, 47);
            llenar(c1,pintar[3]);
            llenar(lista[0], pintar[2]);
            llenar(lista[3], pintar[6]);

            tex1.BackColor = c1;
            tex2.BackColor = lista[0];
            tex3.BackColor = lista[3];

            lcol1.BackColor = pintar[3];
            lcol2.BackColor = pintar[2];
            lcol3.BackColor = pintar[6];

        }
        public void llenar(Color cx, Color px)
        {
            Color c1 = new Color();
            c1 = cx;
            cR = c1.R; cG = c1.G; cB = c1.B;
            cRt = cR; cGt = cG; cBt = cB;
            inc++;
            if (inc > 9)
            {
                inc = 0;
            }

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            int cRto, cGto, cBto;
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 20; i = i + 10)
                for (int j = 0; j < bmp.Height - 20; j = j + 10)
                {

                    cRto = 0; cGto = 0; cBto = 0;
                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                        }
                    cRto = cRto / 100;
                    cGto = cGto / 100;
                    cBto = cBto / 100;
                    c = bmp.GetPixel(i, j);
                    if (((cRt - 10 <= cRto) && (cRto <= cRt + 10)) && ((cGto - 10 <= cGt) && (cGt <= cGto + 10)) && ((cBto - 10 <= cBt) && (cBt <= cBto + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                bmp2.SetPixel(k, l, px);
                            }
                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp2.GetPixel(k, l);
                                bmp2.SetPixel(k, l, c);
                            }

                }
            pictureBox2.Image = bmp2;
        }

        private int tam_x=0,tam_y=0;
        private int indice = -1;
        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Bitmap bmp3 = new Bitmap(1400, 50);
            Color c1 = new Color();
            Color c2 = new Color();
            Color c3 = new Color();
            pantalla.Text = "Dimensiones: "+bmp.Width + " x " + bmp.Height;
            tam_x = bmp.Width;
            tam_y = bmp.Height;
            lista = new Color[tam_x*tam_y];
            contadores = new int[tam_x * tam_y];
            for (int i = 0; i < bmp.Width; i=i+5)
                for (int j = 0; j < bmp.Height; j=j+5)
            //for (int i = 0; i < 300; i++)
              //  for (int j = 0; j < 300; j++)
                {
                    c1 = bmp.GetPixel(i, j);
                    int aux = esRepetido(c1);
                    if (aux==-1)
                    {
                        indice++;
                        lista[indice] = c1;
                        contadores[indice] = 1;
                    }
                    else
                    {
                        contadores[aux]++;
                    }
                }

            for (int i = 0; i < indice; i++)
            {
                for (int j = i+1; j < indice + 1; j++)
                {
                    if (contadores[i]<contadores[j])
                    {
                        int aux = contadores[i];
                        contadores[i] = contadores[i + 1];
                        contadores[i + 1] = aux;
                        Color aux2 = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = aux2;

                    }
                }
            }
            int cont = -1;
            for (int k = 0; k < bmp3.Width; k += 50)
            {
                cont++;
                for (int i = k; i < bmp3.Width; i ++)
                {
                    
                    for (int j = 0; j < bmp3.Height; j++)
                    {
                        bmp3.SetPixel(i, j, lista[cont]);
                    }
                }
            }
            Color[] azules = new Color[5];
            cont = -1;
            azules[0] = Color.FromArgb(3, 36, 47);
            azules[1] = Color.FromArgb(7, 77, 103);
            azules[2] = Color.FromArgb(19, 85, 103);

            for (int k = 1200; k < bmp3.Width; k += 50)
            {
                cont++;
                for (int i = k; i < bmp3.Width; i++)
                {

                    for (int j = 0; j < bmp3.Height; j++)
                    {
                        bmp3.SetPixel(i, j, azules[cont]);
                    }
                }
            }
            paleta.Image = bmp3;
        }
        private int esRepetido(Color cx)
        {
            int sw = -1;
            
                for (int j = 0; j < indice+1; j++)
                {
                    if (lista[j].Equals(cx))
                    {
                        sw = j;
                        break;
                    }
                }
            return sw;

        }
    }
}
