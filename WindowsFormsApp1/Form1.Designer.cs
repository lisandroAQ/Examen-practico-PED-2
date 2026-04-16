namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNodos = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.listRecorrido = new System.Windows.Forms.ListBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.labelSeccion1 = new System.Windows.Forms.Label();
            this.labelSeccion2 = new System.Windows.Forms.Label();
            this.labelSeccion3 = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(12, 73);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(215, 45);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar Nodo";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(135)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(10, 184);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(215, 38);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Nodo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(10, 288);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(215, 44);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Nodo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(254, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 555);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(533, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desafío 3 — Librería UDB";
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.Color.White;
            this.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDato.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtDato.Location = new System.Drawing.Point(10, 36);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(215, 31);
            this.txtDato.TabIndex = 1;
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.White;
            this.txtEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtEliminar.Location = new System.Drawing.Point(10, 147);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(215, 31);
            this.txtEliminar.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtBuscar.Location = new System.Drawing.Point(9, 251);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(211, 31);
            this.txtBuscar.TabIndex = 5;
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblNodos.Location = new System.Drawing.Point(8, 8);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(156, 23);
            this.lblNodos.TabIndex = 0;
            this.lblNodos.Text = "📦  Total nodos: 0";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblAltura.Location = new System.Drawing.Point(8, 28);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(114, 23);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "📏  Altura: 0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblPromedio.Location = new System.Drawing.Point(8, 50);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(184, 23);
            this.lblPromedio.TabIndex = 2;
            this.lblPromedio.Text = "📊  Promedio nivel: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.rbInOrden);
            this.groupBox1.Controls.Add(this.rbPreOrden);
            this.groupBox1.Controls.Add(this.rbPostOrden);
            this.groupBox1.Controls.Add(this.btnRecorrer);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 140);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de recorrido";
            // 
            // rbInOrden
            // 
            this.rbInOrden.AutoSize = true;
            this.rbInOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.rbInOrden.Location = new System.Drawing.Point(8, 22);
            this.rbInOrden.Name = "rbInOrden";
            this.rbInOrden.Size = new System.Drawing.Size(100, 27);
            this.rbInOrden.TabIndex = 0;
            this.rbInOrden.TabStop = true;
            this.rbInOrden.Text = "InOrden";
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.rbPreOrden.Location = new System.Drawing.Point(8, 48);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(111, 27);
            this.rbPreOrden.TabIndex = 1;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "PreOrden";
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.rbPostOrden.Location = new System.Drawing.Point(8, 74);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(118, 27);
            this.rbPostOrden.TabIndex = 2;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "PostOrden";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.btnRecorrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecorrer.FlatAppearance.BorderSize = 0;
            this.btnRecorrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecorrer.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnRecorrer.ForeColor = System.Drawing.Color.White;
            this.btnRecorrer.Location = new System.Drawing.Point(8, 103);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(202, 28);
            this.btnRecorrer.TabIndex = 12;
            this.btnRecorrer.Text = "▶  Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // listRecorrido
            // 
            this.listRecorrido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.listRecorrido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listRecorrido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRecorrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.listRecorrido.FormattingEnabled = true;
            this.listRecorrido.ItemHeight = 38;
            this.listRecorrido.Location = new System.Drawing.Point(1152, 40);
            this.listRecorrido.Name = "listRecorrido";
            this.listRecorrido.Size = new System.Drawing.Size(100, 572);
            this.listRecorrido.TabIndex = 13;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.panelLateral.Controls.Add(this.labelSeccion1);
            this.panelLateral.Controls.Add(this.txtDato);
            this.panelLateral.Controls.Add(this.btnInsertar);
            this.panelLateral.Controls.Add(this.labelSeccion2);
            this.panelLateral.Controls.Add(this.txtEliminar);
            this.panelLateral.Controls.Add(this.btnEliminar);
            this.panelLateral.Controls.Add(this.labelSeccion3);
            this.panelLateral.Controls.Add(this.txtBuscar);
            this.panelLateral.Controls.Add(this.btnBuscar);
            this.panelLateral.Controls.Add(this.groupBox1);
            this.panelLateral.Controls.Add(this.panelStats);
            this.panelLateral.Location = new System.Drawing.Point(8, 8);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Padding = new System.Windows.Forms.Padding(8);
            this.panelLateral.Size = new System.Drawing.Size(238, 622);
            this.panelLateral.TabIndex = 1;
            // 
            // labelSeccion1
            // 
            this.labelSeccion1.AutoSize = true;
            this.labelSeccion1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelSeccion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.labelSeccion1.Location = new System.Drawing.Point(10, 15);
            this.labelSeccion1.Name = "labelSeccion1";
            this.labelSeccion1.Size = new System.Drawing.Size(149, 23);
            this.labelSeccion1.TabIndex = 0;
            this.labelSeccion1.Text = "➕  Insertar ISBN";
            // 
            // labelSeccion2
            // 
            this.labelSeccion2.AutoSize = true;
            this.labelSeccion2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelSeccion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.labelSeccion2.Location = new System.Drawing.Point(10, 121);
            this.labelSeccion2.Name = "labelSeccion2";
            this.labelSeccion2.Size = new System.Drawing.Size(154, 23);
            this.labelSeccion2.TabIndex = 2;
            this.labelSeccion2.Text = "🗑️  Eliminar ISBN";
            // 
            // labelSeccion3
            // 
            this.labelSeccion3.AutoSize = true;
            this.labelSeccion3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelSeccion3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.labelSeccion3.Location = new System.Drawing.Point(10, 225);
            this.labelSeccion3.Name = "labelSeccion3";
            this.labelSeccion3.Size = new System.Drawing.Size(140, 23);
            this.labelSeccion3.TabIndex = 4;
            this.labelSeccion3.Text = "🔍  Buscar ISBN";
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.panelStats.Controls.Add(this.lblNodos);
            this.panelStats.Controls.Add(this.lblAltura);
            this.panelStats.Controls.Add(this.lblPromedio);
            this.panelStats.Location = new System.Drawing.Point(10, 508);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(220, 75);
            this.panelStats.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1260, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listRecorrido);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.Name = "Form1";
            this.Text = "Desafío 3 — Librería UDB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbInOrden;
        private System.Windows.Forms.ListBox listRecorrido;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label labelSeccion1;
        private System.Windows.Forms.Label labelSeccion2;
        private System.Windows.Forms.Label labelSeccion3;
    }
}