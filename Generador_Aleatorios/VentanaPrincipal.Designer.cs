
namespace Generador_Aleatorios
{
    partial class VentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btn_link = new System.Windows.Forms.Button();
            this.rb_entrada_automatica = new System.Windows.Forms.RadioButton();
            this.rb_entrada_manual = new System.Windows.Forms.RadioButton();
            this.gb_exit = new System.Windows.Forms.GroupBox();
            this.dgv_output = new System.Windows.Forms.DataGridView();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_aleat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_useless_one = new System.Windows.Forms.Label();
            this.cb_methodlist = new System.Windows.Forms.ComboBox();
            this.btn_exect = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gb_entrada_datos = new System.Windows.Forms.GroupBox();
            this.tab_control_entrada = new System.Windows.Forms.TabControl();
            this.tb_entrada_manual = new System.Windows.Forms.TabPage();
            this.txt_entrada_manual = new System.Windows.Forms.TextBox();
            this.lb_mensaje_entrada = new System.Windows.Forms.Label();
            this.tb_entrada_automatica = new System.Windows.Forms.TabPage();
            this.pb_construccion = new System.Windows.Forms.PictureBox();
            this.tb_entrada_transf_inv = new System.Windows.Forms.TabPage();
            this.txt_rango_superior = new System.Windows.Forms.TextBox();
            this.lb_rango_superior = new System.Windows.Forms.Label();
            this.txt_rango_inferior = new System.Windows.Forms.TextBox();
            this.lb_rango_inferior = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.gb_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gb_entrada_datos.SuspendLayout();
            this.tab_control_entrada.SuspendLayout();
            this.tb_entrada_manual.SuspendLayout();
            this.tb_entrada_automatica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_construccion)).BeginInit();
            this.tb_entrada_transf_inv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_link
            // 
            this.btn_link.Location = new System.Drawing.Point(14, 305);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(338, 29);
            this.btn_link.TabIndex = 3;
            this.btn_link.Text = "Generador de números pseudoaleatorios online";
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // rb_entrada_automatica
            // 
            this.rb_entrada_automatica.AutoSize = true;
            this.rb_entrada_automatica.Location = new System.Drawing.Point(237, 21);
            this.rb_entrada_automatica.Name = "rb_entrada_automatica";
            this.rb_entrada_automatica.Size = new System.Drawing.Size(117, 17);
            this.rb_entrada_automatica.TabIndex = 1;
            this.rb_entrada_automatica.Text = "Entrada automatica";
            this.rb_entrada_automatica.UseVisualStyleBackColor = true;
            // 
            // rb_entrada_manual
            // 
            this.rb_entrada_manual.AutoSize = true;
            this.rb_entrada_manual.Checked = true;
            this.rb_entrada_manual.Location = new System.Drawing.Point(8, 21);
            this.rb_entrada_manual.Name = "rb_entrada_manual";
            this.rb_entrada_manual.Size = new System.Drawing.Size(99, 17);
            this.rb_entrada_manual.TabIndex = 0;
            this.rb_entrada_manual.TabStop = true;
            this.rb_entrada_manual.Text = "Entrada manual";
            this.rb_entrada_manual.UseVisualStyleBackColor = true;
            this.rb_entrada_manual.CheckedChanged += new System.EventHandler(this.rb_entrada_manual_CheckedChanged);
            // 
            // gb_exit
            // 
            this.gb_exit.Controls.Add(this.dgv_output);
            this.gb_exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_exit.Location = new System.Drawing.Point(376, 92);
            this.gb_exit.Name = "gb_exit";
            this.gb_exit.Size = new System.Drawing.Size(460, 262);
            this.gb_exit.TabIndex = 1;
            this.gb_exit.TabStop = false;
            this.gb_exit.Text = "Salida";
            // 
            // dgv_output
            // 
            this.dgv_output.AllowUserToAddRows = false;
            this.dgv_output.AllowUserToDeleteRows = false;
            this.dgv_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.num_aleat});
            this.dgv_output.Location = new System.Drawing.Point(5, 24);
            this.dgv_output.Name = "dgv_output";
            this.dgv_output.ReadOnly = true;
            this.dgv_output.RowTemplate.Height = 25;
            this.dgv_output.Size = new System.Drawing.Size(450, 232);
            this.dgv_output.TabIndex = 0;
            // 
            // iter
            // 
            this.iter.HeaderText = "Iteración";
            this.iter.Name = "iter";
            this.iter.ReadOnly = true;
            // 
            // num_aleat
            // 
            this.num_aleat.HeaderText = "Número aleatorio generado";
            this.num_aleat.Name = "num_aleat";
            this.num_aleat.ReadOnly = true;
            this.num_aleat.Width = 250;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_useless_one);
            this.panel2.Controls.Add(this.cb_methodlist);
            this.panel2.Controls.Add(this.btn_exect);
            this.panel2.Location = new System.Drawing.Point(376, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 76);
            this.panel2.TabIndex = 3;
            // 
            // lb_useless_one
            // 
            this.lb_useless_one.AutoSize = true;
            this.lb_useless_one.Location = new System.Drawing.Point(14, 16);
            this.lb_useless_one.Name = "lb_useless_one";
            this.lb_useless_one.Size = new System.Drawing.Size(263, 13);
            this.lb_useless_one.TabIndex = 2;
            this.lb_useless_one.Text = "Métodos para generar números aleatorios disponibles :";
            // 
            // cb_methodlist
            // 
            this.cb_methodlist.FormattingEnabled = true;
            this.cb_methodlist.Items.AddRange(new object[] {
            "Método de la transformada inversa"});
            this.cb_methodlist.Location = new System.Drawing.Point(35, 42);
            this.cb_methodlist.Name = "cb_methodlist";
            this.cb_methodlist.Size = new System.Drawing.Size(202, 21);
            this.cb_methodlist.TabIndex = 1;
            this.cb_methodlist.Text = "Métodos";
            this.cb_methodlist.SelectedIndexChanged += new System.EventHandler(this.cb_methodlist_SelectedIndexChanged);
            // 
            // btn_exect
            // 
            this.btn_exect.Location = new System.Drawing.Point(321, 16);
            this.btn_exect.Name = "btn_exect";
            this.btn_exect.Size = new System.Drawing.Size(119, 35);
            this.btn_exect.TabIndex = 0;
            this.btn_exect.Text = "Calcular";
            this.btn_exect.UseVisualStyleBackColor = true;
            this.btn_exect.Click += new System.EventHandler(this.btn_exect_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 371);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // gb_entrada_datos
            // 
            this.gb_entrada_datos.Controls.Add(this.tab_control_entrada);
            this.gb_entrada_datos.Controls.Add(this.rb_entrada_manual);
            this.gb_entrada_datos.Controls.Add(this.btn_clean);
            this.gb_entrada_datos.Controls.Add(this.btn_link);
            this.gb_entrada_datos.Controls.Add(this.rb_entrada_automatica);
            this.gb_entrada_datos.Location = new System.Drawing.Point(8, 10);
            this.gb_entrada_datos.Name = "gb_entrada_datos";
            this.gb_entrada_datos.Size = new System.Drawing.Size(363, 343);
            this.gb_entrada_datos.TabIndex = 6;
            this.gb_entrada_datos.TabStop = false;
            this.gb_entrada_datos.Text = "Entrada de datos";
            // 
            // tab_control_entrada
            // 
            this.tab_control_entrada.Controls.Add(this.tb_entrada_manual);
            this.tab_control_entrada.Controls.Add(this.tb_entrada_automatica);
            this.tab_control_entrada.Controls.Add(this.tb_entrada_transf_inv);
            this.tab_control_entrada.Location = new System.Drawing.Point(8, 42);
            this.tab_control_entrada.Name = "tab_control_entrada";
            this.tab_control_entrada.SelectedIndex = 0;
            this.tab_control_entrada.Size = new System.Drawing.Size(347, 223);
            this.tab_control_entrada.TabIndex = 2;
            // 
            // tb_entrada_manual
            // 
            this.tb_entrada_manual.Controls.Add(this.txt_entrada_manual);
            this.tb_entrada_manual.Controls.Add(this.lb_mensaje_entrada);
            this.tb_entrada_manual.Location = new System.Drawing.Point(4, 22);
            this.tb_entrada_manual.Name = "tb_entrada_manual";
            this.tb_entrada_manual.Padding = new System.Windows.Forms.Padding(3);
            this.tb_entrada_manual.Size = new System.Drawing.Size(339, 197);
            this.tb_entrada_manual.TabIndex = 0;
            this.tb_entrada_manual.UseVisualStyleBackColor = true;
            // 
            // txt_entrada_manual
            // 
            this.txt_entrada_manual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_entrada_manual.Location = new System.Drawing.Point(3, 5);
            this.txt_entrada_manual.Multiline = true;
            this.txt_entrada_manual.Name = "txt_entrada_manual";
            this.txt_entrada_manual.Size = new System.Drawing.Size(333, 159);
            this.txt_entrada_manual.TabIndex = 5;
            this.txt_entrada_manual.TextChanged += new System.EventHandler(this.txt_entrada_manual_TextChanged);
            // 
            // lb_mensaje_entrada
            // 
            this.lb_mensaje_entrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mensaje_entrada.Location = new System.Drawing.Point(5, 166);
            this.lb_mensaje_entrada.Name = "lb_mensaje_entrada";
            this.lb_mensaje_entrada.Size = new System.Drawing.Size(330, 29);
            this.lb_mensaje_entrada.TabIndex = 4;
            this.lb_mensaje_entrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_entrada_automatica
            // 
            this.tb_entrada_automatica.Controls.Add(this.pb_construccion);
            this.tb_entrada_automatica.Location = new System.Drawing.Point(4, 22);
            this.tb_entrada_automatica.Name = "tb_entrada_automatica";
            this.tb_entrada_automatica.Padding = new System.Windows.Forms.Padding(3);
            this.tb_entrada_automatica.Size = new System.Drawing.Size(339, 197);
            this.tb_entrada_automatica.TabIndex = 1;
            this.tb_entrada_automatica.UseVisualStyleBackColor = true;
            // 
            // pb_construccion
            // 
            this.pb_construccion.Image = global::Generador_Aleatorios.Properties.Resources.sitio_en_construccion;
            this.pb_construccion.Location = new System.Drawing.Point(5, 5);
            this.pb_construccion.Name = "pb_construccion";
            this.pb_construccion.Size = new System.Drawing.Size(330, 188);
            this.pb_construccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_construccion.TabIndex = 0;
            this.pb_construccion.TabStop = false;
            // 
            // tb_entrada_transf_inv
            // 
            this.tb_entrada_transf_inv.Controls.Add(this.txt_rango_superior);
            this.tb_entrada_transf_inv.Controls.Add(this.lb_rango_superior);
            this.tb_entrada_transf_inv.Controls.Add(this.txt_rango_inferior);
            this.tb_entrada_transf_inv.Controls.Add(this.lb_rango_inferior);
            this.tb_entrada_transf_inv.Location = new System.Drawing.Point(4, 22);
            this.tb_entrada_transf_inv.Name = "tb_entrada_transf_inv";
            this.tb_entrada_transf_inv.Padding = new System.Windows.Forms.Padding(3);
            this.tb_entrada_transf_inv.Size = new System.Drawing.Size(339, 197);
            this.tb_entrada_transf_inv.TabIndex = 2;
            this.tb_entrada_transf_inv.UseVisualStyleBackColor = true;
            // 
            // txt_rango_superior
            // 
            this.txt_rango_superior.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_rango_superior.Location = new System.Drawing.Point(133, 115);
            this.txt_rango_superior.Name = "txt_rango_superior";
            this.txt_rango_superior.Size = new System.Drawing.Size(182, 29);
            this.txt_rango_superior.TabIndex = 3;
            this.txt_rango_superior.TextChanged += new System.EventHandler(this.txt_rango_superior_TextChanged);
            this.txt_rango_superior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rango_superior_KeyPress);
            // 
            // lb_rango_superior
            // 
            this.lb_rango_superior.AutoSize = true;
            this.lb_rango_superior.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_rango_superior.Location = new System.Drawing.Point(7, 118);
            this.lb_rango_superior.Name = "lb_rango_superior";
            this.lb_rango_superior.Size = new System.Drawing.Size(120, 21);
            this.lb_rango_superior.TabIndex = 2;
            this.lb_rango_superior.Text = "Rango superior:";
            // 
            // txt_rango_inferior
            // 
            this.txt_rango_inferior.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_rango_inferior.Location = new System.Drawing.Point(126, 42);
            this.txt_rango_inferior.Name = "txt_rango_inferior";
            this.txt_rango_inferior.Size = new System.Drawing.Size(182, 29);
            this.txt_rango_inferior.TabIndex = 1;
            this.txt_rango_inferior.TextChanged += new System.EventHandler(this.txt_rango_inferior_TextChanged);
            this.txt_rango_inferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rango_inferior_KeyPress);
            // 
            // lb_rango_inferior
            // 
            this.lb_rango_inferior.AutoSize = true;
            this.lb_rango_inferior.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_rango_inferior.Location = new System.Drawing.Point(7, 45);
            this.lb_rango_inferior.Name = "lb_rango_inferior";
            this.lb_rango_inferior.Size = new System.Drawing.Size(113, 21);
            this.lb_rango_inferior.TabIndex = 0;
            this.lb_rango_inferior.Text = "Rango inferior:";
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(14, 270);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(338, 29);
            this.btn_clean.TabIndex = 3;
            this.btn_clean.Text = "Limpiar";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 371);
            this.Controls.Add(this.gb_entrada_datos);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_exit);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de números aleatorios";
            this.gb_exit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gb_entrada_datos.ResumeLayout(false);
            this.gb_entrada_datos.PerformLayout();
            this.tab_control_entrada.ResumeLayout(false);
            this.tb_entrada_manual.ResumeLayout(false);
            this.tb_entrada_manual.PerformLayout();
            this.tb_entrada_automatica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_construccion)).EndInit();
            this.tb_entrada_transf_inv.ResumeLayout(false);
            this.tb_entrada_transf_inv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_entrada_automatica;
        private System.Windows.Forms.RadioButton rb_entrada_manual;
        private System.Windows.Forms.GroupBox gb_exit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.DataGridView dgv_output;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_aleat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exect;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lb_useless_one;
        private System.Windows.Forms.ComboBox cb_methodlist;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.GroupBox gb_entrada_datos;
        private System.Windows.Forms.TabControl tab_control_entrada;
        private System.Windows.Forms.TabPage tb_entrada_manual;
        private System.Windows.Forms.TabPage tb_entrada_automatica;
        private System.Windows.Forms.TextBox txt_entrada_manual;
        private System.Windows.Forms.Label lb_mensaje_entrada;
        private System.Windows.Forms.TabPage tb_entrada_transf_inv;
        private System.Windows.Forms.PictureBox pb_construccion;
        private System.Windows.Forms.TextBox txt_rango_superior;
        private System.Windows.Forms.Label lb_rango_superior;
        private System.Windows.Forms.TextBox txt_rango_inferior;
        private System.Windows.Forms.Label lb_rango_inferior;
    }
}

