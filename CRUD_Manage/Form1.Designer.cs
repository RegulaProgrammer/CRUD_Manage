namespace CRUD_Manage
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtbx = new System.Windows.Forms.TextBox();
            this.Nametbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Disengtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Colorcbox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.UPdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Preciotbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Getbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Findbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatgebtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD Magane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de producto\r\n";
            // 
            // IDtbx
            // 
            this.IDtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtbx.Location = new System.Drawing.Point(178, 86);
            this.IDtbx.Name = "IDtbx";
            this.IDtbx.Size = new System.Drawing.Size(182, 23);
            this.IDtbx.TabIndex = 2;
            // 
            // Nametbx
            // 
            this.Nametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametbx.Location = new System.Drawing.Point(178, 124);
            this.Nametbx.Name = "Nametbx";
            this.Nametbx.Size = new System.Drawing.Size(182, 23);
            this.Nametbx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // Disengtbx
            // 
            this.Disengtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disengtbx.Location = new System.Drawing.Point(178, 162);
            this.Disengtbx.Name = "Disengtbx";
            this.Disengtbx.Size = new System.Drawing.Size(182, 23);
            this.Disengtbx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Diseño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(23, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Color";
            // 
            // Colorcbox
            // 
            this.Colorcbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Colorcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colorcbox.FormattingEnabled = true;
            this.Colorcbox.Items.AddRange(new object[] {
            "Blanco",
            "Rojo",
            "Verde",
            "Azul",
            "Gris",
            "Negro"});
            this.Colorcbox.Location = new System.Drawing.Point(178, 199);
            this.Colorcbox.Name = "Colorcbox";
            this.Colorcbox.Size = new System.Drawing.Size(182, 24);
            this.Colorcbox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(440, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 245);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 157);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(23, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha";
            // 
            // UPdateTimePicker
            // 
            this.UPdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UPdateTimePicker.Location = new System.Drawing.Point(178, 273);
            this.UPdateTimePicker.Name = "UPdateTimePicker";
            this.UPdateTimePicker.Size = new System.Drawing.Size(182, 22);
            this.UPdateTimePicker.TabIndex = 17;
            // 
            // Preciotbx
            // 
            this.Preciotbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preciotbx.Location = new System.Drawing.Point(178, 237);
            this.Preciotbx.Name = "Preciotbx";
            this.Preciotbx.Size = new System.Drawing.Size(182, 23);
            this.Preciotbx.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(23, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio";
            // 
            // Savebtn
            // 
            this.Savebtn.AutoEllipsis = true;
            this.Savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebtn.FlatAppearance.BorderSize = 0;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Image = global::CRUD_Manage.Properties.Resources.icon_guardar_30;
            this.Savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.Location = new System.Drawing.Point(27, 308);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(110, 40);
            this.Savebtn.TabIndex = 21;
            this.Savebtn.Text = "Guardar";
            this.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Getbtn
            // 
            this.Getbtn.AutoEllipsis = true;
            this.Getbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Getbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Getbtn.FlatAppearance.BorderSize = 0;
            this.Getbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Getbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Getbtn.Image = global::CRUD_Manage.Properties.Resources.icon_recieve_30;
            this.Getbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Getbtn.Location = new System.Drawing.Point(401, 201);
            this.Getbtn.Name = "Getbtn";
            this.Getbtn.Size = new System.Drawing.Size(110, 40);
            this.Getbtn.TabIndex = 20;
            this.Getbtn.Text = "Obtener";
            this.Getbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Getbtn.UseVisualStyleBackColor = false;
            this.Getbtn.Click += new System.EventHandler(this.Getbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.AutoEllipsis = true;
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.Image = global::CRUD_Manage.Properties.Resources.icon_broom_30;
            this.Clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbtn.Location = new System.Drawing.Point(401, 283);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(110, 40);
            this.Clearbtn.TabIndex = 15;
            this.Clearbtn.Text = "Limpiar";
            this.Clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Findbtn
            // 
            this.Findbtn.AutoEllipsis = true;
            this.Findbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Findbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Findbtn.FlatAppearance.BorderSize = 0;
            this.Findbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Findbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findbtn.Image = global::CRUD_Manage.Properties.Resources.icon_search_30;
            this.Findbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Findbtn.Location = new System.Drawing.Point(401, 160);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(110, 40);
            this.Findbtn.TabIndex = 14;
            this.Findbtn.Text = "Buscar";
            this.Findbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Findbtn.UseVisualStyleBackColor = false;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.AutoEllipsis = true;
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Image = global::CRUD_Manage.Properties.Resources.icon_delete_30;
            this.Deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebtn.Location = new System.Drawing.Point(401, 242);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(110, 40);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "Borrar";
            this.Deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatgebtn
            // 
            this.Updatgebtn.AutoEllipsis = true;
            this.Updatgebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Updatgebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatgebtn.FlatAppearance.BorderSize = 0;
            this.Updatgebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatgebtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatgebtn.Image = global::CRUD_Manage.Properties.Resources.icon_update_30;
            this.Updatgebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Updatgebtn.Location = new System.Drawing.Point(401, 119);
            this.Updatgebtn.Name = "Updatgebtn";
            this.Updatgebtn.Size = new System.Drawing.Size(110, 40);
            this.Updatgebtn.TabIndex = 12;
            this.Updatgebtn.Text = "Actualizar";
            this.Updatgebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Updatgebtn.UseVisualStyleBackColor = false;
            this.Updatgebtn.Click += new System.EventHandler(this.Updatgebtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.AutoEllipsis = true;
            this.Insertbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Insertbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insertbtn.FlatAppearance.BorderSize = 0;
            this.Insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbtn.Image = global::CRUD_Manage.Properties.Resources.icon_add_30;
            this.Insertbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Insertbtn.Location = new System.Drawing.Point(401, 78);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(110, 40);
            this.Insertbtn.TabIndex = 9;
            this.Insertbtn.Text = "Insertar";
            this.Insertbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Insertbtn.UseVisualStyleBackColor = false;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(68, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 40);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(559, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Getbtn);
            this.Controls.Add(this.Preciotbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UPdateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatgebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.Colorcbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Disengtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nametbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Manage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtbx;
        private System.Windows.Forms.TextBox Nametbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Disengtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Colorcbox;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Updatgebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker UPdateTimePicker;
        private System.Windows.Forms.TextBox Preciotbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Getbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Panel panel2;
    }
}

