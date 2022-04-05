namespace CRUD_DB_Empleados
{
    partial class CrudForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tNumeroDocumento = new System.Windows.Forms.TextBox();
            this.tNombres = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.tEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.dataTableGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // tNumeroDocumento
            // 
            this.tNumeroDocumento.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tNumeroDocumento.Location = new System.Drawing.Point(147, 89);
            this.tNumeroDocumento.Name = "tNumeroDocumento";
            this.tNumeroDocumento.Size = new System.Drawing.Size(147, 21);
            this.tNumeroDocumento.TabIndex = 6;
            // 
            // tNombres
            // 
            this.tNombres.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tNombres.Location = new System.Drawing.Point(147, 123);
            this.tNombres.Name = "tNombres";
            this.tNombres.Size = new System.Drawing.Size(147, 21);
            this.tNombres.TabIndex = 7;
            // 
            // tApellidos
            // 
            this.tApellidos.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tApellidos.Location = new System.Drawing.Point(147, 157);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(147, 21);
            this.tApellidos.TabIndex = 8;
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(147, 191);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(147, 23);
            this.tDireccion.TabIndex = 9;
            // 
            // tEdad
            // 
            this.tEdad.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tEdad.Location = new System.Drawing.Point(147, 225);
            this.tEdad.Name = "tEdad";
            this.tEdad.Size = new System.Drawing.Size(147, 21);
            this.tEdad.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "F.Nacimiento";
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(146, 260);
            this.dateTime.MinDate = new System.DateTime(1930, 12, 25, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(148, 21);
            this.dateTime.TabIndex = 12;
            // 
            // dataTableGrid
            // 
            this.dataTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableGrid.Location = new System.Drawing.Point(321, 89);
            this.dataTableGrid.Name = "dataTableGrid";
            this.dataTableGrid.RowTemplate.Height = 25;
            this.dataTableGrid.Size = new System.Drawing.Size(371, 156);
            this.dataTableGrid.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(321, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consult";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Consult_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(417, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Save_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(517, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(617, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 329);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTableGrid);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tEdad);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombres);
            this.Controls.Add(this.tNumeroDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrudForm";
            this.Text = "CRUD Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tNumeroDocumento;
        private TextBox tNombres;
        private TextBox tApellidos;
        private TextBox tDireccion;
        private TextBox tEdad;
        private Label label7;
        private DateTimePicker dateTime;
        private DataGridView dataTableGrid;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}