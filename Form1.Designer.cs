namespace Parcial_POO2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bSubs = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bAC = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.bMult = new System.Windows.Forms.Button();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFibo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMultiUni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMultiSerie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.bFact = new System.Windows.Forms.Button();
            this.bFib = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bDivi = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(82, 32);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(628, 54);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.MintCream;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b1.Location = new System.Drawing.Point(49, 115);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(137, 59);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(226, 115);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(137, 59);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(419, 115);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(137, 59);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click_1);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(606, 115);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(137, 59);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(42, 207);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(137, 59);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(226, 207);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(137, 59);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(419, 207);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(137, 59);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bSubs
            // 
            this.bSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubs.Location = new System.Drawing.Point(606, 207);
            this.bSubs.Name = "bSubs";
            this.bSubs.Size = new System.Drawing.Size(137, 59);
            this.bSubs.TabIndex = 8;
            this.bSubs.Text = "-";
            this.bSubs.UseVisualStyleBackColor = true;
            this.bSubs.Click += new System.EventHandler(this.bSubs_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(42, 296);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(137, 59);
            this.b7.TabIndex = 9;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(226, 296);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(137, 59);
            this.b8.TabIndex = 10;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(419, 296);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(137, 59);
            this.b9.TabIndex = 11;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.Location = new System.Drawing.Point(606, 296);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(137, 59);
            this.bDiv.TabIndex = 12;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bAC
            // 
            this.bAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAC.Location = new System.Drawing.Point(42, 379);
            this.bAC.Name = "bAC";
            this.bAC.Size = new System.Drawing.Size(137, 59);
            this.bAC.TabIndex = 13;
            this.bAC.Text = "AC";
            this.bAC.UseVisualStyleBackColor = true;
            this.bAC.Click += new System.EventHandler(this.bAC_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(226, 379);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(137, 59);
            this.b0.TabIndex = 14;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bEqual
            // 
            this.bEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEqual.Location = new System.Drawing.Point(419, 379);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(137, 59);
            this.bEqual.TabIndex = 15;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = true;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // bMult
            // 
            this.bMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMult.Location = new System.Drawing.Point(606, 379);
            this.bMult.Name = "bMult";
            this.bMult.Size = new System.Drawing.Size(137, 59);
            this.bMult.TabIndex = 16;
            this.bMult.Text = "*";
            this.bMult.UseVisualStyleBackColor = true;
            this.bMult.Click += new System.EventHandler(this.bMult_Click);
            // 
            // menu1
            // 
            this.menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFibo,
            this.menuFact,
            this.menuMulti,
            this.menuDiv,
            this.cerrarToolStripMenuItem});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(162, 24);
            this.menu1.Text = "Funciones avanzadas.";
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // menuFibo
            // 
            this.menuFibo.Name = "menuFibo";
            this.menuFibo.Size = new System.Drawing.Size(147, 26);
            this.menuFibo.Text = "Fibonacci";
            this.menuFibo.Click += new System.EventHandler(this.menuFibo_Click);
            // 
            // menuFact
            // 
            this.menuFact.Name = "menuFact";
            this.menuFact.Size = new System.Drawing.Size(147, 26);
            this.menuFact.Text = "Factorial";
            this.menuFact.Click += new System.EventHandler(this.menuFact_Click);
            // 
            // menuMulti
            // 
            this.menuMulti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMultiUni,
            this.menuMultiSerie});
            this.menuMulti.Name = "menuMulti";
            this.menuMulti.Size = new System.Drawing.Size(147, 26);
            this.menuMulti.Text = "Multiplos";
            this.menuMulti.Click += new System.EventHandler(this.menuMulti_Click);
            // 
            // menuMultiUni
            // 
            this.menuMultiUni.Name = "menuMultiUni";
            this.menuMultiUni.Size = new System.Drawing.Size(201, 26);
            this.menuMultiUni.Text = "Multiplo unico";
            this.menuMultiUni.Click += new System.EventHandler(this.menuMultiUni_Click);
            // 
            // menuMultiSerie
            // 
            this.menuMultiSerie.Name = "menuMultiSerie";
            this.menuMultiSerie.Size = new System.Drawing.Size(201, 26);
            this.menuMultiSerie.Text = "Multiplos en serie";
            this.menuMultiSerie.Click += new System.EventHandler(this.menuMultiSerie_Click);
            // 
            // menuDiv
            // 
            this.menuDiv.Name = "menuDiv";
            this.menuDiv.Size = new System.Drawing.Size(147, 26);
            this.menuDiv.Text = "Divisores";
            this.menuDiv.Click += new System.EventHandler(this.menuDiv_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // txtFact
            // 
            this.txtFact.Enabled = false;
            this.txtFact.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFact.Location = new System.Drawing.Point(1085, 32);
            this.txtFact.Multiline = true;
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(240, 54);
            this.txtFact.TabIndex = 18;
            this.txtFact.Visible = false;
            this.txtFact.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bFact
            // 
            this.bFact.Enabled = false;
            this.bFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFact.Location = new System.Drawing.Point(804, 115);
            this.bFact.Name = "bFact";
            this.bFact.Size = new System.Drawing.Size(137, 59);
            this.bFact.TabIndex = 19;
            this.bFact.Text = "Factorial";
            this.bFact.UseVisualStyleBackColor = true;
            this.bFact.Visible = false;
            this.bFact.Click += new System.EventHandler(this.bFact_Click);
            // 
            // bFib
            // 
            this.bFib.Enabled = false;
            this.bFib.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFib.Location = new System.Drawing.Point(804, 207);
            this.bFib.Name = "bFib";
            this.bFib.Size = new System.Drawing.Size(137, 59);
            this.bFib.TabIndex = 20;
            this.bFib.Text = "Fibonacci";
            this.bFib.UseVisualStyleBackColor = true;
            this.bFib.Visible = false;
            this.bFib.Click += new System.EventHandler(this.bFib_Click);
            // 
            // bMulti
            // 
            this.bMulti.Enabled = false;
            this.bMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMulti.Location = new System.Drawing.Point(804, 296);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(137, 59);
            this.bMulti.TabIndex = 21;
            this.bMulti.Text = "Multiplos";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Visible = false;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // bDivi
            // 
            this.bDivi.Enabled = false;
            this.bDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDivi.Location = new System.Drawing.Point(804, 379);
            this.bDivi.Name = "bDivi";
            this.bDivi.Size = new System.Drawing.Size(137, 59);
            this.bDivi.TabIndex = 22;
            this.bDivi.Text = "Divisores";
            this.bDivi.UseVisualStyleBackColor = true;
            this.bDivi.Visible = false;
            this.bDivi.Click += new System.EventHandler(this.bDivi_Click);
            // 
            // list1
            // 
            this.list1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 31;
            this.list1.Location = new System.Drawing.Point(1085, 115);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(240, 283);
            this.list1.TabIndex = 23;
            this.list1.Visible = false;
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1337, 466);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.bDivi);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.bFib);
            this.Controls.Add(this.bFact);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.bMult);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bAC);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bSubs);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bSubs;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bAC;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button bMult;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem menuFibo;
        private System.Windows.Forms.ToolStripMenuItem menuFact;
        private System.Windows.Forms.ToolStripMenuItem menuMulti;
        private System.Windows.Forms.ToolStripMenuItem menuDiv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtFact;
        private System.Windows.Forms.Button bFact;
        private System.Windows.Forms.Button bFib;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bDivi;
        private System.Windows.Forms.ToolStripMenuItem menuMultiUni;
        private System.Windows.Forms.ToolStripMenuItem menuMultiSerie;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}

