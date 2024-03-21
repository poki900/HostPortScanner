namespace HostPortScanner
{
    partial class fMainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bthello = new System.Windows.Forms.Button();
            this.lhello = new System.Windows.Forms.Label();
            this.nudForm = new System.Windows.Forms.NumericUpDown();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.lHost = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            this.SuspendLayout();
            // 
            // bthello
            // 
            this.bthello.Location = new System.Drawing.Point(68, 101);
            this.bthello.Name = "bthello";
            this.bthello.Size = new System.Drawing.Size(75, 23);
            this.bthello.TabIndex = 0;
            this.bthello.Text = "START";
            this.bthello.UseVisualStyleBackColor = true;
            this.bthello.Click += new System.EventHandler(this.Bthello_Click);
            // 
            // lhello
            // 
            this.lhello.AutoSize = true;
            this.lhello.Location = new System.Drawing.Point(297, 182);
            this.lhello.Name = "lhello";
            this.lhello.Size = new System.Drawing.Size(0, 13);
            this.lhello.TabIndex = 2;
            // 
            // nudForm
            // 
            this.nudForm.Location = new System.Drawing.Point(68, 46);
            this.nudForm.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudForm.Name = "nudForm";
            this.nudForm.Size = new System.Drawing.Size(87, 20);
            this.nudForm.TabIndex = 3;
            // 
            // nudTo
            // 
            this.nudTo.Location = new System.Drawing.Point(535, 46);
            this.nudTo.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(108, 20);
            this.nudTo.TabIndex = 4;
            // 
            // lHost
            // 
            this.lHost.AutoSize = true;
            this.lHost.Location = new System.Drawing.Point(158, 106);
            this.lHost.Name = "lHost";
            this.lHost.Size = new System.Drawing.Size(119, 13);
            this.lHost.TabIndex = 5;
            this.lHost.Text = "Currently, the port scan:";
            // 
            // lbHost
            // 
            this.lbHost.Location = new System.Drawing.Point(84, 204);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(659, 199);
            this.lbHost.TabIndex = 6;
            // 
            // fMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.lHost);
            this.Controls.Add(this.nudTo);
            this.Controls.Add(this.nudForm);
            this.Controls.Add(this.lhello);
            this.Controls.Add(this.bthello);
            this.Name = "fMainWindow";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.FMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthello;
        private System.Windows.Forms.Label lhello;
        private System.Windows.Forms.NumericUpDown nudForm;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.Label lHost;
        private System.Windows.Forms.ListBox lbHost;
    }
}

