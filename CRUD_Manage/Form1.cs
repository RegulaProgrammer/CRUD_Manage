using DocumentFormat.OpenXml.Packaging;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Manage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddAnimation(Insertbtn);
            AddAnimation(Updatgebtn);
            AddAnimation(Deletebtn);
            AddAnimation(Findbtn);
            AddAnimation(Clearbtn);
            AddAnimation(Getbtn);
            AddAnimation(Savebtn);
        }
        
        public void AddAnimation(Button button) //Metodo para la aniación de los botones//
        {
            var expandTimer = new Timer();
            var contractTimer = new Timer();

            expandTimer.Interval = 10;//can adjust to determine the refresh rate
            contractTimer.Interval = 10;

            DateTime animationStarted = DateTime.Now;

            //TODO update as appropriate or make it a parameter
            TimeSpan animationDuration = TimeSpan.FromMilliseconds(250);
            int initialWidth = 110;
            int endWidth = 130;

            button.MouseHover += (_, args) =>
            {
                button.BringToFront();
                contractTimer.Stop();
                expandTimer.Start();
                animationStarted = DateTime.Now;
                button.BackColor = Color.FromArgb(151, 247, 201);
            };

            button.MouseLeave += (_, args) =>
            {
                expandTimer.Stop();
                contractTimer.Start();
                animationStarted = DateTime.Now;
                button.BackColor = Color.FromArgb(70, 70, 70);
            };

            expandTimer.Tick += (_, args) =>
            {
                double percentComplete = (DateTime.Now - animationStarted).Ticks
                    / (double)animationDuration.Ticks;

                if (percentComplete >= 1)
                {
                    expandTimer.Stop();
                }
                else
                {
                    button.Width = (int)(initialWidth +
                        (endWidth - initialWidth) * percentComplete);
                }
            };

            contractTimer.Tick += (_, args) =>
            {
                double percentComplete = (DateTime.Now - animationStarted).Ticks
                    / (double)animationDuration.Ticks;

                if (percentComplete >= 1)
                {
                    contractTimer.Stop();
                    button.SendToBack();
                }
                else
                {
                    button.Width = (int)(endWidth -
                        (endWidth - initialWidth) * percentComplete);
                }
            };
        }

        //Establece la conección con la base de datos DB//
        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-2NEO5QP; " +
            "Initial Catalog=CRUD_DB;Integrated Security=True;Encrypt=False;");

        private void Insertbtn_Click(object sender, EventArgs e)//Inserta los datos en la DB//
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dataGridView1.DataSource;
                //Verifica si la clave ID ya existe en la tabla//
                bool exs = dt.AsEnumerable().Any(row => int.Parse(IDtbx.Text) == row.Field<int>("ProductoID"));
                
                if (exs != true)
                {
                    if (IDtbx.Text != "" && Nametbx.Text != "" && Disengtbx.Text != ""
                        && Colorcbox.Text != "")//Verifica que los campos de los datos no esten vacios//
                    {
                        conect.Open();
                        SqlCommand command = new SqlCommand("insert into ProductInfo_Tab values ('" + int.Parse(IDtbx.Text) + "','" + Nametbx.Text + "','" + Disengtbx.Text + "','" + Colorcbox.Text + "','" + Preciotbx.Text + "',getdate(),getdate()) ", conect);
                        command.ExecuteNonQuery();
                        conect.Close();
                        MessageBox.Show("Agregado correctamente.", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los datos del producto", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        conect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("El ID que trata de usar ya existe", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    conect.Close();
                }
            }
            catch (FormatException)//Verifica que el formato de los datos sea correcto//
            {
                MessageBox.Show("Datos invalidos", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                conect.Close();
            }
        }

        private void BindData()//Crea la DataTable, la enlaza con la dataView y la actualiza//
        {
            SqlCommand command = new SqlCommand("select * from ProductInfo_Tab", conect);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sd.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoResizeColumn(2);
            dataGridView1.AutoResizeColumn(5);
            dataGridView1.AutoResizeColumn(6);
            dataGridView1.Columns[4].DefaultCellStyle.Format = "$##,##0.00";
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(72, 96, 135);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(72, 96, 135);
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Silver;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)//Carga la tabla al iniciar el programa//
        {
            BindData();
        }

        private void Updatgebtn_Click(object sender, EventArgs e)//Actualiza los datos//
        {
            try
            {
               
                if (IDtbx.Text != "")//Verifica que los campos de los datos no esten vacios//
                {
                    conect.Open();
                    SqlCommand command = new SqlCommand("update ProductInfo_Tab set" +
                            " Nombre = '" + Nametbx.Text + "',Diseño='" + Disengtbx.Text + "'," +
                            " Color = '" + Colorcbox.Text + "',FechaUpdate = getdate()," +
                            "Precio = '" + int.Parse(Preciotbx.Text) + "' where ProductoID = '" + int.Parse(IDtbx.Text) + "'", conect); ;
                    command.ExecuteNonQuery();
                    conect.Close();
                    MessageBox.Show("Actualizado correctamente", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    BindData();
                }
                else
                {
                    MessageBox.Show("Ingrese el ID del producto", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    conect.Close();
                }
            }
            catch (FormatException)//Verifica que el formato de los datos sea correcto//
            {
                MessageBox.Show("Datos invalidos", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                conect.Close();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)//Borra el dato seleccionado//
        {
            try
            {
                if (IDtbx.Text != "")//Verifica que los campos de los datos no esten vacios//
                {
                    DataTable dataTable = new DataTable();
                    dataTable = (DataTable)dataGridView1.DataSource;
                    bool exs = dataTable.AsEnumerable().Any(row => int.Parse(IDtbx.Text) == row.Field<int>("ProductoID"));
                    
                    if (exs)
                    {
                        if (MessageBox.Show("¿Desea eliminar la informacio?", "Borrar información",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            conect.Open();
                            SqlCommand command = new SqlCommand("Delete ProductInfo_Tab " +
                                "where ProductoID= '" + int.Parse(IDtbx.Text) + "'", conect);
                            command.ExecuteNonQuery();
                            conect.Close();
                            MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                            BindData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este ID no existe", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        conect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el ID del producto", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    conect.Close();
                }
            }
            catch (FormatException)//Verifica que el formato de los datos sea correcto//
            {
                MessageBox.Show("Datos invalidos", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                conect.Close();
            }
        }

        private void Findbtn_Click(object sender, EventArgs e)//Busca un dato y lo muetra en la tabla//
        {
            try
            {
                if (IDtbx.Text != "")//Verifica que los campos de los datos no esten vacios//
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)dataGridView1.DataSource;
                    //Verifica si la clave ID ya existe en la tabla//
                    bool exs = dt.AsEnumerable().Any(row => int.Parse(IDtbx.Text) == row.Field<int>("ProductoID"));
                    if (exs)
                    {
                        SqlCommand command = new SqlCommand("select * from ProductInfo_Tab " +
                            "where ProductoID = '" + int.Parse(IDtbx.Text) + "'", conect);
                        SqlDataAdapter sd = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        sd.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Este ID no existe", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el ID del producto", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    conect.Close();
                }
            }
            catch (FormatException)//Verifica que el formato de los datos sea correcto//
            {
                MessageBox.Show("Datos invalidos", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                conect.Close();
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)//Limpia los campos de datos//
        {
            IDtbx.Clear();
            Nametbx.Clear();
            Disengtbx.Clear();
            Preciotbx.Clear();
            Colorcbox.SelectedIndex = -1;
            conect.Close();
        }

        private void Getbtn_Click(object sender, EventArgs e)//Obtiene los datos de la clave especificada//
        {
            try
            {
                if (IDtbx.Text != "")//Verifica que los campos de los datos no esten vacios//
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)dataGridView1.DataSource;
                    //Verifica si la clave ID ya existe en la tabla//
                    bool exs = dt.AsEnumerable().Any(row => int.Parse(IDtbx.Text) == row.Field<int>("ProductoID"));
                    if (exs)
                    {
                        conect.Open();
                        SqlCommand command = new SqlCommand("select Nombre,Diseño, Color,Precio,Fecha from ProductInfo_Tab where ProductoID= '" + int.Parse(IDtbx.Text) + "'", conect);
                        SqlDataReader sqlDR = command.ExecuteReader();
                        while (sqlDR.Read())
                        {
                            Nametbx.Text = sqlDR.GetValue(0).ToString();
                            Disengtbx.Text = sqlDR.GetValue(1).ToString();
                            Colorcbox.Text = sqlDR.GetValue(2).ToString();
                            Preciotbx.Text = sqlDR.GetValue(3).ToString();
                            UPdateTimePicker.Text = sqlDR.GetValue(4).ToString();
                        }
                        conect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este ID no existe", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        conect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el ID del producto", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    conect.Close();
                }
            }
            catch (FormatException)//Verifica que el formato de los datos sea correcto//
            {
                MessageBox.Show("Datos invalidos", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                conect.Close();
            }

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar el archivo?", "Guardar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable table = new DataTable();
                    table = (DataTable)dataGridView1.DataSource;
                    SLDocument sLDocument = new SLDocument();
                    SLStyle style = new SLStyle();
                    SLStyle style1 = new SLStyle();

                    style = sLDocument.CreateStyle();
                    style.FormatCode = "dd/MM/yyyy hh:mm";
                    style1 = sLDocument.CreateStyle();
                    style1.FormatCode = "$##,###0.00";

                    string hora = DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
                    string path = @"C:\Users\pc\Desktop\Info\";
                    string pathFile = @"C:\Users\pc\Desktop\Info\" + string.Format(@"Inventario_{0}.xlsx", hora);
                    sLDocument.ImportDataTable(1, 1, table, true);
                    sLDocument.SetColumnStyle(6, style);
                    sLDocument.SetColumnStyle(7, style);
                    sLDocument.SetColumnStyle(5, style1);
                    sLDocument.AutoFitColumn(1);
                    sLDocument.AutoFitColumn(3);
                    sLDocument.AutoFitColumn(5);
                    sLDocument.AutoFitColumn(6);
                    sLDocument.AutoFitColumn(7);

                    End:
                    if (Directory.Exists(path))
                    {
                        sLDocument.SaveAs(pathFile);

                        MessageBox.Show("Archivo guardado correctamente", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Creando carpeta...", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        Directory.CreateDirectory(path);
                        goto End;

                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error al guardar", "ERROR", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
            
        }
    }
}
