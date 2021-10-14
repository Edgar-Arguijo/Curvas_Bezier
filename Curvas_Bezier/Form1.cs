using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvas_Bezier
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		System.Drawing.Pen lapiz1 = new System.Drawing.Pen(System.Drawing.Color.Transparent);
		System.Drawing.Pen lapiz2 = new System.Drawing.Pen(System.Drawing.Color.Red, 3);//Curva Bezier
		System.Drawing.Pen lapiz3 = new System.Drawing.Pen(System.Drawing.Color.Purple, 3);//Linea Puntero Mous
		System.Drawing.Pen lapiz4 = new System.Drawing.Pen(System.Drawing.Color.Purple, 3);
		System.Drawing.Pen lapiz5 = new System.Drawing.Pen(System.Drawing.Color.Blue, 3);
		Pen pluma = new Pen(Color.Black, 2);

		private void Principal()
		{
			System.Drawing.Graphics dibujo = this.pictureBox1.CreateGraphics();
			dibujo.TranslateTransform(0, 0);
			double t = 0, x = 0, y = 0;
			double p0 = 0, p1 = 0, p2 = 0;
			double p3 = 0, p4 = 0;

			double[] Resultx = new double[1001];
			double[] Resulty = new double[1001];

			if (numericUpDown1.Text == "2")
			{
				double[] X = new double[] { Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtX2.Text) };
				double[] Y = new double[] { Convert.ToInt32(txtY1.Text), Convert.ToInt32(txtY2.Text) };
				t = 0;
				p0 = (Math.Pow((1 - t), 2) * X[0]);
				p1 = (2 * (t) * (1 - t)) * X[1];
				//p2 = Math.Pow(t, 2) * X[2];
				int j = 0;

				for (double i = 0; i <= 1; i = i + .001)
				{
					t = 0;
					t = t + i;
					x = (Math.Pow((1 - t), 2) * X[0]) + (2 * (t) * (1 - t)) * X[1];
					//+ Math.Pow(t, 2) * X[2]
					y = (Math.Pow((1 - t), 2) * Y[0]) + (2 * (t) * (1 - t)) * Y[1];
					// + Math.Pow(t, 2) * Y[2]

					Resultx[j] = x;
					Resulty[j] = y;

					j++;
				}
				label1.Text = Resultx[999].ToString();
				label2.Text = Resulty[999].ToString();


				for (int i = 0; i < 999; i++)
				{
					dibujo.DrawLine(lapiz2, Convert.ToInt32(Resultx[i]), Convert.ToInt32(Resulty[i]), Convert.ToInt32(Resultx[i + 1]), Convert.ToInt32(Resulty[i + 1]));
				}
			}
			if (numericUpDown1.Text == "3")
			{
				double[] X = new double[] { Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtX3.Value) };
				double[] Y = new double[] { Convert.ToInt32(txtY1.Text), Convert.ToInt32(txtY2.Text), Convert.ToInt32(txtY3.Value) };
				t = 0;
				p0 = (Math.Pow((1 - t), 2) * X[0]);
				p1 = (2 * (t) * (1 - t)) * X[1];
				p2 = Math.Pow(t, 2) * X[2];
				int j = 0;

				for (double i = 0; i <= 1; i = i + .001)
				{
					t = 0;
					t = t + i;
					x = (Math.Pow((1 - t), 2) * X[0]) + (2 * (t) * (1 - t)) * X[1] + Math.Pow(t, 2) * X[2];
					y = (Math.Pow((1 - t), 2) * Y[0]) + (2 * (t) * (1 - t)) * Y[1] + Math.Pow(t, 2) * Y[2];

					Resultx[j] = x;
					Resulty[j] = y;

					j++;
				}
				label1.Text = Resultx[999].ToString();
				label2.Text = Resulty[999].ToString();


				for (int i = 0; i < 999; i++)
				{
					dibujo.DrawLine(lapiz2, Convert.ToInt32(Resultx[i]), Convert.ToInt32(Resulty[i]), Convert.ToInt32(Resultx[i + 1]), Convert.ToInt32(Resulty[i + 1]));
				}

			}
			if (numericUpDown1.Text == "4")
			{
				double[] X = new double[] { Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtX3.Value), Convert.ToInt32(txtX4.Value) };
				double[] Y = new double[] { Convert.ToInt32(txtY1.Text), Convert.ToInt32(txtY2.Text), Convert.ToInt32(txtY3.Value), Convert.ToInt32(txtY4.Value) };
				t = .1;
				p0 = Math.Pow((1 - t), 3) * X[0];
				p1 = 3 * t * Math.Pow((1 - t), 2) * X[1];
				p2 = 3 * Math.Pow(t, 2) * (1 - t) * X[2];
				p3 = Math.Pow(t, 3) * X[3];
				int j = 0;


				for (double i = 0; i <= 1; i = i + .001)
				{
					t = 0;
					t = t + i;
					x = Math.Pow((1 - t), 3) * X[0] + 3 * t * Math.Pow((1 - t), 2) * X[1] + 3 * Math.Pow(t, 2) * (1 - t) * X[2] + Math.Pow(t, 3) * X[3];
					y = Math.Pow((1 - t), 3) * Y[0] + 3 * t * Math.Pow((1 - t), 2) * Y[1] + 3 * Math.Pow(t, 2) * (1 - t) * Y[2] + Math.Pow(t, 3) * Y[3];

					Resultx[j] = x;
					Resulty[j] = y;

					j++;
				}
				label1.Text = Resultx[1000].ToString();
				label2.Text = Resulty[1000].ToString();
				label3.Text = p2.ToString();
				label4.Text = p3.ToString();



				for (int i = 0; i < 999; i++)
				{
					dibujo.DrawLine(lapiz2, Convert.ToInt32(Resultx[i]), Convert.ToInt32(Resulty[i]), Convert.ToInt32(Resultx[i + 1]), Convert.ToInt32(Resulty[i + 1]));
				}

			}
			if (numericUpDown1.Text == "5")
			{
				double[] X = new double[] { Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtX3.Value), Convert.ToInt32(txtX4.Value), Convert.ToInt32(txtX5.Value) };
				double[] Y = new double[] { Convert.ToInt32(txtY1.Text), Convert.ToInt32(txtY2.Text), Convert.ToInt32(txtY3.Value), Convert.ToInt32(txtY4.Value), Convert.ToInt32(txtY5.Value) };
				t = .1;
				p0 = Math.Pow((1 - t), 4) * X[0];
				p1 = 4 * t * Math.Pow((1 - t), 3) * X[1];
				p2 = 6 * Math.Pow((1 - t), 2) * Math.Pow(t, 2) * X[2];
				p3 = 4 * (1 - t) * Math.Pow(t, 3) * X[3];
				p4 = Math.Pow(t, 4) * X[4];
				int j = 0;


				for (double i = 0; i <= 1; i = i + .001)
				{
					t = 0;
					t = t + i;
					x = Math.Pow((1 - t), 4) * X[0] + 4 * t * Math.Pow((1 - t), 3) * X[1] + 6 * Math.Pow((1 - t), 2) * Math.Pow(t, 2) * X[2] + 4 * (1 - t) * Math.Pow(t, 3) * X[3] + Math.Pow(t, 4) * X[4];
					y = Math.Pow((1 - t), 4) * Y[0] + 4 * t * Math.Pow((1 - t), 3) * Y[1] + 6 * Math.Pow((1 - t), 2) * Math.Pow(t, 2) * Y[2] + 4 * (1 - t) * Math.Pow(t, 3) * Y[3] + Math.Pow(t, 4) * Y[4];

					Resultx[j] = x;
					Resulty[j] = y;

					j++;
				}
				label1.Text = Resultx[1000].ToString();
				label2.Text = Resulty[1000].ToString();
				label3.Text = p2.ToString();
				label4.Text = p3.ToString();



				for (int i = 0; i < 999; i++)
				{
					dibujo.DrawLine(lapiz2, Convert.ToInt32(Resultx[i]), Convert.ToInt32(Resulty[i]), Convert.ToInt32(Resultx[i +1]), Convert.ToInt32(Resulty[i +1]));
				}
			}
		}

		private void Puntos()
		{
			System.Drawing.Graphics dibujo = this.pictureBox1.CreateGraphics();

			int xc = pictureBox1.Width; //Calculamos cordenadas Centrales
			int yc = pictureBox1.Height;
			dibujo.TranslateTransform(0, 0);

			if (numericUpDown1.Text == "2")
			{
				Point[] p =
				{
					new Point(Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtY1.Text)),
					new Point(Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtY2.Text))
				};
				dibujo.DrawLines(lapiz4, p);
			}
			if (numericUpDown1.Text == "3")
			{
				Point[] p =
				{
					new Point(Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtY1.Text)),
					new Point(Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtY2.Text)),
					new Point(Convert.ToInt32(txtX3.Text), Convert.ToInt32(txtY3.Text))
				};
				dibujo.DrawLines(lapiz4, p);
			}
			if (numericUpDown1.Text == "4")
			{
				Point[] p =
				{
					new Point(Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtY1.Text)),
					new Point(Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtY2.Text)),
					new Point(Convert.ToInt32(txtX3.Text), Convert.ToInt32(txtY3.Text)),
					new Point(Convert.ToInt32(txtX4.Text), Convert.ToInt32(txtY4.Text))
				};
				dibujo.DrawLines(lapiz4, p);
			}
			if (numericUpDown1.Text == "5")
			{
				Point[] p =
				{
					new Point(Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtY1.Text)),
					new Point(Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtY2.Text)),
					new Point(Convert.ToInt32(txtX3.Text), Convert.ToInt32(txtY3.Text)),
					new Point(Convert.ToInt32(txtX4.Text), Convert.ToInt32(txtY4.Text)),
					new Point(Convert.ToInt32(txtX5.Text), Convert.ToInt32(txtY5.Text))
				};
				dibujo.DrawLines(lapiz4, p);
			}
		}

		private void BtnGrafica_Click(object sender, EventArgs e)
		{
			Principal();
			Puntos();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void btnPunto_Click(object sender, EventArgs e)
		{
			int numPuntos;
			numPuntos = Convert.ToInt32(numericUpDown1.Value);
			if (numPuntos == 2)
			{
				lblP1.Visible = true;
				lblP2.Visible = true;
				txtX1.Visible = true;
				txtY1.Visible = true;
				txtX2.Visible = true;
				txtY2.Visible = true;
			}
			if (numPuntos == 3)
			{
				lblP1.Visible = true;
				lblP2.Visible = true;
				lblP3.Visible = true;
				txtX1.Visible = true;
				txtY1.Visible = true;
				txtX2.Visible = true;
				txtY2.Visible = true;
				txtX3.Visible = true;
				txtY3.Visible = true;
			}
			if (numPuntos == 4)
			{
				lblP1.Visible = true;
				lblP2.Visible = true;
				lblP3.Visible = true;
				lblP4.Visible = true;
				txtX1.Visible = true;
				txtY1.Visible = true;
				txtX2.Visible = true;
				txtY2.Visible = true;
				txtX3.Visible = true;
				txtY3.Visible = true;
				txtX4.Visible = true;
				txtY4.Visible = true;
			}
			if (numPuntos == 5)
			{
				lblP1.Visible = true;
				lblP2.Visible = true;
				lblP3.Visible = true;
				lblP4.Visible = true;
				lblP5.Visible = true;
				txtX1.Visible = true;
				txtY1.Visible = true;
				txtX2.Visible = true;
				txtY2.Visible = true;
				txtX3.Visible = true;
				txtY3.Visible = true;
				txtX4.Visible = true;
				txtY4.Visible = true;
				txtX5.Visible = true;
				txtY5.Visible = true;
			}
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			int xc = pictureBox1.Width / 2; //Calculamos cordenadas Centrales
			int yc = pictureBox1.Height / 2;
			e.Graphics.TranslateTransform(xc, yc);
			e.Graphics.ScaleTransform(1, -1);
			e.Graphics.DrawLine(lapiz1, xc * -1, 0, xc * 2, 0); //Eje x
																  //Line Vertical
			e.Graphics.DrawLine(lapiz1, 0, yc, 0, yc * -1); //Eje y

			for (int i = -xc; i < xc; i += 8)
			{
				e.Graphics.DrawLine(lapiz1, 2, i, -2, i);
				e.Graphics.DrawLine(lapiz1, i, 2, i, -2);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Manualmente")
			{
				lblPuntos.Visible = true;
				numericUpDown1.Visible = true;
				btnPunto.Visible = true;
				BtnGrafica.Visible = true;
				btnLimpiar.Visible = true;

			}
			if (comboBox1.Text == "Mouse")
			{
				lblPuntos.Visible = true;
				numericUpDown1.Visible = true;
				btnPunto.Visible = true;
				BtnGrafica.Visible = true;
				btnLimpiar.Visible = true;

			}
		}

		int caros = 0;
		int ccccc = 0;
		int click = 0;

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			base.OnMouseClick(e);
			if (comboBox1.Text == "Mouse")
			{
				if (numericUpDown1.Value == 2)
				{
					if (click == 0)
					{
						txtX1.Value = pictureBox1.PointToClient(Cursor.Position).X;
						txtY1.Value = pictureBox1.PointToClient(Cursor.Position).Y;
					}
					if (click == 1)
					{
						txtX2.Value = pictureBox1.PointToClient(Cursor.Position).X;
						txtY2.Value = pictureBox1.PointToClient(Cursor.Position).Y;
					}
				}
				else
				{
					if (numericUpDown1.Value == 3)
					{
						if (click == 0)
						{
							txtX1.Value = pictureBox1.PointToClient(Cursor.Position).X;
							txtY1.Value = pictureBox1.PointToClient(Cursor.Position).Y;


						}
						if (click == 1)
						{
							txtX2.Value = pictureBox1.PointToClient(Cursor.Position).X;
							txtY2.Value = pictureBox1.PointToClient(Cursor.Position).Y;
						}
						if (click == 2)
                        {
                            txtX3.Value = pictureBox1.PointToClient(Cursor.Position).X;
							txtY3.Value = pictureBox1.PointToClient(Cursor.Position).Y;
						}
						base.OnMouseClick(e);

					}
					else
					{
						if (numericUpDown1.Value == 4)
						{
							if (click == 0)
                            {
                                txtX1.Value = pictureBox1.PointToClient(Cursor.Position).X;
								txtY1.Value = pictureBox1.PointToClient(Cursor.Position).Y;
							}
							if (click == 1)
							{
								txtX2.Value = pictureBox1.PointToClient(Cursor.Position).X;
								txtY2.Value = pictureBox1.PointToClient(Cursor.Position).Y;
							}
							if (click == 2)
							{
								txtX3.Value = pictureBox1.PointToClient(Cursor.Position).X;
								txtY3.Value = pictureBox1.PointToClient(Cursor.Position).Y;
							}
							base.OnMouseClick(e);
							if (click == 3)
							{
								txtX4.Value = pictureBox1.PointToClient(Cursor.Position).X;
								txtY4.Value = pictureBox1.PointToClient(Cursor.Position).Y;
							}

						}
						else
						{
							if (numericUpDown1.Value == 5)
							{
								if (click == 0)
								{
									txtX1.Value = pictureBox1.PointToClient(Cursor.Position).X;
									txtY1.Value = pictureBox1.PointToClient(Cursor.Position).Y; 
								}
								if (click == 1)
								{
									txtX2.Value = pictureBox1.PointToClient(Cursor.Position).X;
									txtY2.Value = pictureBox1.PointToClient(Cursor.Position).Y;
								}
								if (click == 2)
								{
									txtX3.Value = pictureBox1.PointToClient(Cursor.Position).X;
									txtY3.Value = pictureBox1.PointToClient(Cursor.Position).Y;
								}
								base.OnMouseClick(e);
								if (click == 3)
								{
									txtX4.Value = pictureBox1.PointToClient(Cursor.Position).X;
									txtY4.Value = pictureBox1.PointToClient(Cursor.Position).Y;
								}
								if (click == 4)
								{
									base.OnMouseClick(e);
									txtX5.Value = pictureBox1.PointToClient(Cursor.Position).X;
									txtY5.Value = pictureBox1.PointToClient(Cursor.Position).Y;
								}

							}
						}
					}
				}
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			click++;
		}

		List<Point> lista = new List<Point>();

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			System.Drawing.Graphics g = this.pictureBox1.CreateGraphics();
			//Color Mouse
			Pen lapiz3 = new Pen(Color.Purple, 3);

			lista.Add(new Point(pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y));

			if (lista.Count > 1 & lista.Count < numericUpDown1.Value + 1)
			{
				g.DrawRectangle(lapiz3, new Rectangle(pictureBox1.PointToClient(Cursor.Position).X, pictureBox1.PointToClient(Cursor.Position).Y, 3, 3));
				g.DrawLine(lapiz3, lista[lista.Count - 1], lista[lista.Count - 2]);
			}
		}

        private void btnAutores_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Gracias Por Utilizar Nuestro Programa.", "Copyright Oficial ©:");
			MessageBox.Show("Arguijo Vazquez Edgar Eduardo - 192310252.", "Copyright Oficial ©: Autor 1");
			MessageBox.Show("Ortiz Godoy Antonio - 192310291.", "Copyright Oficial ©: Autor 2");
		}
    }
}
