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
            this.btnInsertar    = new System.Windows.Forms.Button();
            this.btnEliminar    = new System.Windows.Forms.Button();
            this.btnBuscar      = new System.Windows.Forms.Button();
            this.panel1         = new System.Windows.Forms.Panel();
            this.label1         = new System.Windows.Forms.Label();
            this.txtDato        = new System.Windows.Forms.TextBox();
            this.txtNombre      = new System.Windows.Forms.TextBox();
            this.txtAutor       = new System.Windows.Forms.TextBox();
            this.txtEliminar    = new System.Windows.Forms.TextBox();
            this.txtBuscar      = new System.Windows.Forms.TextBox();
            this.lblNodos       = new System.Windows.Forms.Label();
            this.lblAltura      = new System.Windows.Forms.Label();
            this.lblPromedio    = new System.Windows.Forms.Label();
            this.groupBox1      = new System.Windows.Forms.GroupBox();
            this.rbInOrden      = new System.Windows.Forms.RadioButton();
            this.rbPreOrden     = new System.Windows.Forms.RadioButton();
            this.rbPostOrden    = new System.Windows.Forms.RadioButton();
            this.btnRecorrer    = new System.Windows.Forms.Button();
            this.listRecorrido  = new System.Windows.Forms.ListBox();
            this.panelLateral   = new System.Windows.Forms.Panel();
            this.labelSeccion1  = new System.Windows.Forms.Label();
            this.lblNombre      = new System.Windows.Forms.Label();
            this.lblAutor       = new System.Windows.Forms.Label();
            this.labelSeccion2  = new System.Windows.Forms.Label();
            this.labelSeccion3  = new System.Windows.Forms.Label();
            this.panelStats     = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color textoOscuro = System.Drawing.Color.FromArgb(80, 50, 70);
            System.Drawing.Color blanco      = System.Drawing.Color.White;

            // ── btnInsertar ───────────────────────────────────────────────
            this.btnInsertar.BackColor                 = System.Drawing.Color.FromArgb(100, 160, 210);
            this.btnInsertar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.ForeColor                 = blanco;
            this.btnInsertar.Location                  = new System.Drawing.Point(12, 155);
            this.btnInsertar.Name                      = "btnInsertar";
            this.btnInsertar.Size                      = new System.Drawing.Size(215, 40);
            this.btnInsertar.TabIndex                  = 0;
            this.btnInsertar.Text                      = "Insertar Nodo";
            this.btnInsertar.UseVisualStyleBackColor   = false;
            this.btnInsertar.Click                    += new System.EventHandler(this.btnInsertar_Click);

            // ── btnEliminar ───────────────────────────────────────────────
            this.btnEliminar.BackColor                 = System.Drawing.Color.FromArgb(255, 105, 135);
            this.btnEliminar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor                 = blanco;
            this.btnEliminar.Location                  = new System.Drawing.Point(10, 265);
            this.btnEliminar.Name                      = "btnEliminar";
            this.btnEliminar.Size                      = new System.Drawing.Size(215, 38);
            this.btnEliminar.TabIndex                  = 1;
            this.btnEliminar.Text                      = "Eliminar Nodo";
            this.btnEliminar.UseVisualStyleBackColor   = false;
            this.btnEliminar.Click                    += new System.EventHandler(this.btnEliminar_Click);

            // ── btnBuscar ─────────────────────────────────────────────────
            this.btnBuscar.BackColor                 = System.Drawing.Color.FromArgb(130, 190, 160);
            this.btnBuscar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor                 = blanco;
            this.btnBuscar.Location                  = new System.Drawing.Point(10, 368);
            this.btnBuscar.Name                      = "btnBuscar";
            this.btnBuscar.Size                      = new System.Drawing.Size(215, 38);
            this.btnBuscar.TabIndex                  = 2;
            this.btnBuscar.Text                      = "Buscar Nodo";
            this.btnBuscar.UseVisualStyleBackColor   = false;
            this.btnBuscar.Click                    += new System.EventHandler(this.btnBuscar_Click);

            // ── panel1 ────────────────────────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
            this.panel1.Location  = new System.Drawing.Point(254, 75);
            this.panel1.Name      = "panel1";
            this.panel1.Size      = new System.Drawing.Size(890, 555);
            this.panel1.TabIndex  = 3;
            this.panel1.Paint    += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            // ── label1 ────────────────────────────────────────────────────
            this.label1.AutoSize  = true;
            this.label1.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = textoOscuro;
            this.label1.Location  = new System.Drawing.Point(533, 23);
            this.label1.Name      = "label1";
            this.label1.Text      = "Desafío 3 — Librería UDB";

            // ── txtDato (ISBN) ────────────────────────────────────────────
            this.txtDato.BackColor   = blanco;
            this.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDato.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDato.ForeColor   = textoOscuro;
            this.txtDato.Location    = new System.Drawing.Point(10, 36);
            this.txtDato.Name        = "txtDato";
            this.txtDato.Size        = new System.Drawing.Size(215, 28);
            this.txtDato.TabIndex    = 1;

            // ── lblNombre + txtNombre ─────────────────────────────────────
            this.lblNombre.AutoSize  = true;
            this.lblNombre.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNombre.ForeColor = textoOscuro;
            this.lblNombre.Location  = new System.Drawing.Point(10, 70);
            this.lblNombre.Name      = "lblNombre";
            this.lblNombre.Text      = "Título del libro:";

            this.txtNombre.BackColor   = blanco;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.ForeColor   = textoOscuro;
            this.txtNombre.Location    = new System.Drawing.Point(10, 88);
            this.txtNombre.Name        = "txtNombre";
            this.txtNombre.Size        = new System.Drawing.Size(215, 28);
            this.txtNombre.TabIndex    = 2;

            // ── lblAutor + txtAutor ───────────────────────────────────────
            this.lblAutor.AutoSize  = true;
            this.lblAutor.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAutor.ForeColor = textoOscuro;
            this.lblAutor.Location  = new System.Drawing.Point(10, 120);
            this.lblAutor.Name      = "lblAutor";
            this.lblAutor.Text      = "Autor:";

            this.txtAutor.BackColor   = blanco;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutor.ForeColor   = textoOscuro;
            this.txtAutor.Location    = new System.Drawing.Point(10, 138);
            this.txtAutor.Name        = "txtAutor";
            this.txtAutor.Size        = new System.Drawing.Size(215, 28);
            this.txtAutor.TabIndex    = 3;

            // ── txtEliminar ───────────────────────────────────────────────
            this.txtEliminar.BackColor   = blanco;
            this.txtEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEliminar.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEliminar.ForeColor   = textoOscuro;
            this.txtEliminar.Location    = new System.Drawing.Point(10, 228);
            this.txtEliminar.Name        = "txtEliminar";
            this.txtEliminar.Size        = new System.Drawing.Size(215, 28);
            this.txtEliminar.TabIndex    = 5;

            // ── txtBuscar ─────────────────────────────────────────────────
            this.txtBuscar.BackColor   = blanco;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.ForeColor   = textoOscuro;
            this.txtBuscar.Location    = new System.Drawing.Point(10, 332);
            this.txtBuscar.Name        = "txtBuscar";
            this.txtBuscar.Size        = new System.Drawing.Size(215, 28);
            this.txtBuscar.TabIndex    = 6;

            // ── panelStats ────────────────────────────────────────────────
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(173, 216, 230);
            this.panelStats.Location  = new System.Drawing.Point(10, 508);
            this.panelStats.Name      = "panelStats";
            this.panelStats.Size      = new System.Drawing.Size(220, 75);
            this.panelStats.TabIndex  = 12;

            this.lblNodos.AutoSize  = true;
            this.lblNodos.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNodos.ForeColor = textoOscuro;
            this.lblNodos.Location  = new System.Drawing.Point(8, 8);
            this.lblNodos.Name      = "lblNodos";
            this.lblNodos.Text      = "📦  Total nodos: 0";

            this.lblAltura.AutoSize  = true;
            this.lblAltura.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAltura.ForeColor = textoOscuro;
            this.lblAltura.Location  = new System.Drawing.Point(8, 28);
            this.lblAltura.Name      = "lblAltura";
            this.lblAltura.Text      = "📏  Altura: 0";

            this.lblPromedio.AutoSize  = true;
            this.lblPromedio.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPromedio.ForeColor = textoOscuro;
            this.lblPromedio.Location  = new System.Drawing.Point(8, 50);
            this.lblPromedio.Name      = "lblPromedio";
            this.lblPromedio.Text      = "📊  Promedio nivel: 0";

            // ── groupBox1 ─────────────────────────────────────────────────
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(250, 235, 245);
            this.groupBox1.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = textoOscuro;
            this.groupBox1.Location  = new System.Drawing.Point(10, 420);
            this.groupBox1.Name      = "groupBox1";
            this.groupBox1.Size      = new System.Drawing.Size(220, 80);
            this.groupBox1.TabIndex  = 11;
            this.groupBox1.TabStop   = false;
            this.groupBox1.Text      = "Tipo de recorrido";

            this.rbInOrden.AutoSize  = true;
            this.rbInOrden.ForeColor = textoOscuro;
            this.rbInOrden.Location  = new System.Drawing.Point(8, 22);
            this.rbInOrden.Name      = "rbInOrden";
            this.rbInOrden.TabIndex  = 0;
            this.rbInOrden.TabStop   = true;
            this.rbInOrden.Text      = "InOrden";

            this.rbPreOrden.AutoSize  = true;
            this.rbPreOrden.ForeColor = textoOscuro;
            this.rbPreOrden.Location  = new System.Drawing.Point(8, 48);
            this.rbPreOrden.Name      = "rbPreOrden";
            this.rbPreOrden.TabIndex  = 1;
            this.rbPreOrden.TabStop   = true;
            this.rbPreOrden.Text      = "PreOrden";

            this.rbPostOrden.AutoSize  = true;
            this.rbPostOrden.ForeColor = textoOscuro;
            this.rbPostOrden.Location  = new System.Drawing.Point(110, 22);
            this.rbPostOrden.Name      = "rbPostOrden";
            this.rbPostOrden.TabIndex  = 2;
            this.rbPostOrden.TabStop   = true;
            this.rbPostOrden.Text      = "PostOrden";

            this.btnRecorrer.BackColor                 = System.Drawing.Color.FromArgb(200, 140, 180);
            this.btnRecorrer.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnRecorrer.FlatAppearance.BorderSize = 0;
            this.btnRecorrer.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecorrer.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnRecorrer.ForeColor                 = blanco;
            this.btnRecorrer.Location                  = new System.Drawing.Point(110, 42);
            this.btnRecorrer.Name                      = "btnRecorrer";
            this.btnRecorrer.Size                      = new System.Drawing.Size(100, 28);
            this.btnRecorrer.TabIndex                  = 12;
            this.btnRecorrer.Text                      = "▶ Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor   = false;
            this.btnRecorrer.Click                    += new System.EventHandler(this.btnRecorrer_Click);

            // ── listRecorrido ─────────────────────────────────────────────
            this.listRecorrido.BackColor         = System.Drawing.Color.FromArgb(255, 240, 248);
            this.listRecorrido.BorderStyle       = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listRecorrido.Font              = new System.Drawing.Font("Segoe UI", 14F);
            this.listRecorrido.ForeColor         = textoOscuro;
            this.listRecorrido.FormattingEnabled = true;
            this.listRecorrido.ItemHeight        = 38;
            this.listRecorrido.Location          = new System.Drawing.Point(1152, 40);
            this.listRecorrido.Name              = "listRecorrido";
            this.listRecorrido.Size              = new System.Drawing.Size(100, 572);
            this.listRecorrido.TabIndex          = 13;

            // ── Labels sección ────────────────────────────────────────────
            this.labelSeccion1.AutoSize  = true;
            this.labelSeccion1.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelSeccion1.ForeColor = textoOscuro;
            this.labelSeccion1.Location  = new System.Drawing.Point(10, 15);
            this.labelSeccion1.Name      = "labelSeccion1";
            this.labelSeccion1.Text      = "➕  Insertar ISBN";

            this.labelSeccion2.AutoSize  = true;
            this.labelSeccion2.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelSeccion2.ForeColor = textoOscuro;
            this.labelSeccion2.Location  = new System.Drawing.Point(10, 205);
            this.labelSeccion2.Name      = "labelSeccion2";
            this.labelSeccion2.Text      = "🗑️  Eliminar ISBN";

            this.labelSeccion3.AutoSize  = true;
            this.labelSeccion3.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelSeccion3.ForeColor = textoOscuro;
            this.labelSeccion3.Location  = new System.Drawing.Point(10, 310);
            this.labelSeccion3.Name      = "labelSeccion3";
            this.labelSeccion3.Text      = "🔍  Buscar ISBN";

            // ── panelLateral ──────────────────────────────────────────────
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(240, 220, 230);
            this.panelLateral.Location  = new System.Drawing.Point(8, 8);
            this.panelLateral.Name      = "panelLateral";
            this.panelLateral.Padding   = new System.Windows.Forms.Padding(8);
            this.panelLateral.Size      = new System.Drawing.Size(238, 622);
            this.panelLateral.TabIndex  = 1;

            // ── Ensamblar ─────────────────────────────────────────────────
            this.panelStats.Controls.Add(this.lblNodos);
            this.panelStats.Controls.Add(this.lblAltura);
            this.panelStats.Controls.Add(this.lblPromedio);

            this.groupBox1.Controls.Add(this.rbInOrden);
            this.groupBox1.Controls.Add(this.rbPostOrden);
            this.groupBox1.Controls.Add(this.rbPreOrden);
            this.groupBox1.Controls.Add(this.btnRecorrer);

            this.panelLateral.Controls.Add(this.labelSeccion1);
            this.panelLateral.Controls.Add(this.txtDato);
            this.panelLateral.Controls.Add(this.lblNombre);
            this.panelLateral.Controls.Add(this.txtNombre);
            this.panelLateral.Controls.Add(this.lblAutor);
            this.panelLateral.Controls.Add(this.txtAutor);
            this.panelLateral.Controls.Add(this.btnInsertar);
            this.panelLateral.Controls.Add(this.labelSeccion2);
            this.panelLateral.Controls.Add(this.txtEliminar);
            this.panelLateral.Controls.Add(this.btnEliminar);
            this.panelLateral.Controls.Add(this.labelSeccion3);
            this.panelLateral.Controls.Add(this.txtBuscar);
            this.panelLateral.Controls.Add(this.btnBuscar);
            this.panelLateral.Controls.Add(this.groupBox1);
            this.panelLateral.Controls.Add(this.panelStats);

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(253, 245, 248);
            this.ClientSize          = new System.Drawing.Size(1260, 680);
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

        private System.Windows.Forms.Button      btnInsertar;
        private System.Windows.Forms.Button      btnEliminar;
        private System.Windows.Forms.Button      btnBuscar;
        private System.Windows.Forms.Panel       panel1;
        private System.Windows.Forms.Label       label1;
        private System.Windows.Forms.TextBox     txtDato;
        private System.Windows.Forms.TextBox     txtNombre;
        private System.Windows.Forms.TextBox     txtAutor;
        private System.Windows.Forms.TextBox     txtEliminar;
        private System.Windows.Forms.TextBox     txtBuscar;
        private System.Windows.Forms.Label       lblNodos;
        private System.Windows.Forms.Label       lblAltura;
        private System.Windows.Forms.Label       lblPromedio;
        private System.Windows.Forms.Label       lblNombre;
        private System.Windows.Forms.Label       lblAutor;
        private System.Windows.Forms.GroupBox    groupBox1;
        private System.Windows.Forms.Button      btnRecorrer;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbInOrden;
        private System.Windows.Forms.ListBox     listRecorrido;
        private System.Windows.Forms.Panel       panelLateral;
        private System.Windows.Forms.Panel       panelStats;
        private System.Windows.Forms.Label       labelSeccion1;
        private System.Windows.Forms.Label       labelSeccion2;
        private System.Windows.Forms.Label       labelSeccion3;
    }
}
