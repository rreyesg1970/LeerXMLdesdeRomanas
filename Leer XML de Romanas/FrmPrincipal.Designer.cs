namespace Leer_XML_de_Romanas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.OfdArchivoXML = new System.Windows.Forms.OpenFileDialog();
            this.BtnAbrirArchivoXML = new System.Windows.Forms.Button();
            this.TxtArchivoXMLLeido = new System.Windows.Forms.TextBox();
            this.BtnLimpiarVentana = new System.Windows.Forms.Button();
            this.TxtRutaArchivoXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lvw1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRutaArchivoCSV = new System.Windows.Forms.TextBox();
            this.BtnAbrirArchivoCSV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OfdArchivoXML
            // 
            this.OfdArchivoXML.FileName = "openFileDialog1";
            // 
            // BtnAbrirArchivoXML
            // 
            this.BtnAbrirArchivoXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnAbrirArchivoXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnAbrirArchivoXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirArchivoXML.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrirArchivoXML.Image")));
            this.BtnAbrirArchivoXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrirArchivoXML.Location = new System.Drawing.Point(486, 14);
            this.BtnAbrirArchivoXML.Name = "BtnAbrirArchivoXML";
            this.BtnAbrirArchivoXML.Size = new System.Drawing.Size(127, 23);
            this.BtnAbrirArchivoXML.TabIndex = 0;
            this.BtnAbrirArchivoXML.Text = "Abrir XML";
            this.BtnAbrirArchivoXML.UseVisualStyleBackColor = true;
            this.BtnAbrirArchivoXML.Click += new System.EventHandler(this.BtnAbrirXML_Click);
            // 
            // TxtArchivoXMLLeido
            // 
            this.TxtArchivoXMLLeido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtArchivoXMLLeido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtArchivoXMLLeido.ForeColor = System.Drawing.Color.White;
            this.TxtArchivoXMLLeido.Location = new System.Drawing.Point(12, 322);
            this.TxtArchivoXMLLeido.Multiline = true;
            this.TxtArchivoXMLLeido.Name = "TxtArchivoXMLLeido";
            this.TxtArchivoXMLLeido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtArchivoXMLLeido.Size = new System.Drawing.Size(381, 303);
            this.TxtArchivoXMLLeido.TabIndex = 1;
            // 
            // BtnLimpiarVentana
            // 
            this.BtnLimpiarVentana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnLimpiarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnLimpiarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarVentana.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiarVentana.Image")));
            this.BtnLimpiarVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiarVentana.Location = new System.Drawing.Point(619, 14);
            this.BtnLimpiarVentana.Name = "BtnLimpiarVentana";
            this.BtnLimpiarVentana.Size = new System.Drawing.Size(127, 23);
            this.BtnLimpiarVentana.TabIndex = 2;
            this.BtnLimpiarVentana.Text = "   Limpiar Ventanas";
            this.BtnLimpiarVentana.UseVisualStyleBackColor = true;
            this.BtnLimpiarVentana.Click += new System.EventHandler(this.BtnLimpiarVentana_Click);
            // 
            // TxtRutaArchivoXML
            // 
            this.TxtRutaArchivoXML.Location = new System.Drawing.Point(164, 17);
            this.TxtRutaArchivoXML.Name = "TxtRutaArchivoXML";
            this.TxtRutaArchivoXML.Size = new System.Drawing.Size(307, 20);
            this.TxtRutaArchivoXML.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ruta archivo XML";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(428, 322);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 303);
            this.listBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archivo original XML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Datos leídos en formato texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Datos leídos en formato Excel";
            // 
            // Lvw1
            // 
            this.Lvw1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Lvw1.AllowColumnReorder = true;
            this.Lvw1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lvw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lvw1.ForeColor = System.Drawing.Color.White;
            this.Lvw1.FullRowSelect = true;
            this.Lvw1.GridLines = true;
            this.Lvw1.HideSelection = false;
            this.Lvw1.Location = new System.Drawing.Point(15, 102);
            this.Lvw1.Name = "Lvw1";
            this.Lvw1.Size = new System.Drawing.Size(1299, 191);
            this.Lvw1.TabIndex = 23;
            this.Lvw1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ruta archivo CSV generado";
            // 
            // TxtRutaArchivoCSV
            // 
            this.TxtRutaArchivoCSV.Location = new System.Drawing.Point(164, 45);
            this.TxtRutaArchivoCSV.Name = "TxtRutaArchivoCSV";
            this.TxtRutaArchivoCSV.Size = new System.Drawing.Size(307, 20);
            this.TxtRutaArchivoCSV.TabIndex = 25;
            // 
            // BtnAbrirArchivoCSV
            // 
            this.BtnAbrirArchivoCSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnAbrirArchivoCSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnAbrirArchivoCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirArchivoCSV.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrirArchivoCSV.Image")));
            this.BtnAbrirArchivoCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrirArchivoCSV.Location = new System.Drawing.Point(486, 43);
            this.BtnAbrirArchivoCSV.Name = "BtnAbrirArchivoCSV";
            this.BtnAbrirArchivoCSV.Size = new System.Drawing.Size(127, 23);
            this.BtnAbrirArchivoCSV.TabIndex = 26;
            this.BtnAbrirArchivoCSV.Text = "Abrir CSV";
            this.BtnAbrirArchivoCSV.UseVisualStyleBackColor = true;
            this.BtnAbrirArchivoCSV.Click += new System.EventHandler(this.BtnAbrirArchivoCSV_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(619, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Acerca de";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1326, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAbrirArchivoCSV);
            this.Controls.Add(this.TxtRutaArchivoCSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lvw1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRutaArchivoXML);
            this.Controls.Add(this.BtnLimpiarVentana);
            this.Controls.Add(this.TxtArchivoXMLLeido);
            this.Controls.Add(this.BtnAbrirArchivoXML);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Lector de XML y conversor a CSV";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OfdArchivoXML;
        private System.Windows.Forms.Button BtnAbrirArchivoXML;
        private System.Windows.Forms.TextBox TxtArchivoXMLLeido;
        private System.Windows.Forms.Button BtnLimpiarVentana;
        private System.Windows.Forms.TextBox TxtRutaArchivoXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView Lvw1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRutaArchivoCSV;
        private System.Windows.Forms.Button BtnAbrirArchivoCSV;
        private System.Windows.Forms.Button button1;
    }
}

