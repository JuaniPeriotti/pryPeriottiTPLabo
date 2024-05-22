namespace pryPeriottiTPLabo
{
    partial class frmAdministrarUbicaciones
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
            if (disposing && (components != null))
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbQuenaken = new System.Windows.Forms.RadioButton();
            this.rbOnas = new System.Windows.Forms.RadioButton();
            this.rbTobas = new System.Windows.Forms.RadioButton();
            this.rbAreaAzul = new System.Windows.Forms.RadioButton();
            this.rbAreaVerde = new System.Windows.Forms.RadioButton();
            this.cbReservas = new System.Windows.Forms.ComboBox();
            this.dgvMostrarUbicaiones = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarUbicaiones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTobas);
            this.groupBox1.Controls.Add(this.rbOnas);
            this.groupBox1.Controls.Add(this.rbQuenaken);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar local";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAreaVerde);
            this.groupBox2.Controls.Add(this.rbAreaAzul);
            this.groupBox2.Location = new System.Drawing.Point(131, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar area";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbReservas);
            this.groupBox3.Location = new System.Drawing.Point(255, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 129);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reservas";
            // 
            // rbQuenaken
            // 
            this.rbQuenaken.AutoSize = true;
            this.rbQuenaken.Location = new System.Drawing.Point(20, 32);
            this.rbQuenaken.Name = "rbQuenaken";
            this.rbQuenaken.Size = new System.Drawing.Size(79, 19);
            this.rbQuenaken.TabIndex = 0;
            this.rbQuenaken.TabStop = true;
            this.rbQuenaken.Text = "Quenaken";
            this.rbQuenaken.UseVisualStyleBackColor = true;
            // 
            // rbOnas
            // 
            this.rbOnas.AutoSize = true;
            this.rbOnas.Location = new System.Drawing.Point(20, 57);
            this.rbOnas.Name = "rbOnas";
            this.rbOnas.Size = new System.Drawing.Size(52, 19);
            this.rbOnas.TabIndex = 1;
            this.rbOnas.TabStop = true;
            this.rbOnas.Text = "Onas";
            this.rbOnas.UseVisualStyleBackColor = true;
            // 
            // rbTobas
            // 
            this.rbTobas.AutoSize = true;
            this.rbTobas.Location = new System.Drawing.Point(20, 82);
            this.rbTobas.Name = "rbTobas";
            this.rbTobas.Size = new System.Drawing.Size(55, 19);
            this.rbTobas.TabIndex = 2;
            this.rbTobas.TabStop = true;
            this.rbTobas.Text = "Tobas";
            this.rbTobas.UseVisualStyleBackColor = true;
            // 
            // rbAreaAzul
            // 
            this.rbAreaAzul.AutoSize = true;
            this.rbAreaAzul.Location = new System.Drawing.Point(20, 46);
            this.rbAreaAzul.Name = "rbAreaAzul";
            this.rbAreaAzul.Size = new System.Drawing.Size(73, 19);
            this.rbAreaAzul.TabIndex = 0;
            this.rbAreaAzul.TabStop = true;
            this.rbAreaAzul.Text = "Area azul";
            this.rbAreaAzul.UseVisualStyleBackColor = true;
            // 
            // rbAreaVerde
            // 
            this.rbAreaVerde.AutoSize = true;
            this.rbAreaVerde.Location = new System.Drawing.Point(20, 71);
            this.rbAreaVerde.Name = "rbAreaVerde";
            this.rbAreaVerde.Size = new System.Drawing.Size(81, 19);
            this.rbAreaVerde.TabIndex = 1;
            this.rbAreaVerde.TabStop = true;
            this.rbAreaVerde.Text = "Area verde";
            this.rbAreaVerde.UseVisualStyleBackColor = true;
            // 
            // cbReservas
            // 
            this.cbReservas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservas.FormattingEnabled = true;
            this.cbReservas.Items.AddRange(new object[] {
            "Reservados",
            "No reservados"});
            this.cbReservas.Location = new System.Drawing.Point(6, 57);
            this.cbReservas.Name = "cbReservas";
            this.cbReservas.Size = new System.Drawing.Size(121, 23);
            this.cbReservas.TabIndex = 0;
            // 
            // dgvMostrarUbicaiones
            // 
            this.dgvMostrarUbicaiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarUbicaiones.Location = new System.Drawing.Point(12, 147);
            this.dgvMostrarUbicaiones.Name = "dgvMostrarUbicaiones";
            this.dgvMostrarUbicaiones.RowTemplate.Height = 25;
            this.dgvMostrarUbicaiones.Size = new System.Drawing.Size(376, 212);
            this.dgvMostrarUbicaiones.TabIndex = 3;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 365);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // frmAdministrarUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 396);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvMostrarUbicaiones);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdministrarUbicaciones";
            this.Text = "Administrar ubicaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarUbicaiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbTobas;
        private RadioButton rbOnas;
        private RadioButton rbQuenaken;
        private GroupBox groupBox2;
        private RadioButton rbAreaVerde;
        private RadioButton rbAreaAzul;
        private GroupBox groupBox3;
        private ComboBox cbReservas;
        private DataGridView dgvMostrarUbicaiones;
        private Button btnMostrar;
    }
}