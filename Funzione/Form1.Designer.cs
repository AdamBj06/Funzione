namespace Funzione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenGraph = new System.Windows.Forms.Button();
            this.GenFunc = new System.Windows.Forms.Button();
            this.Function = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CleanGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenGraph
            // 
            this.GenGraph.Location = new System.Drawing.Point(756, 816);
            this.GenGraph.Name = "GenGraph";
            this.GenGraph.Size = new System.Drawing.Size(91, 23);
            this.GenGraph.TabIndex = 0;
            this.GenGraph.Text = "Generate Graph";
            this.GenGraph.UseVisualStyleBackColor = true;
            this.GenGraph.Click += new System.EventHandler(this.GenGraph_Click);
            // 
            // GenFunc
            // 
            this.GenFunc.Location = new System.Drawing.Point(9, 35);
            this.GenFunc.Name = "GenFunc";
            this.GenFunc.Size = new System.Drawing.Size(103, 23);
            this.GenFunc.TabIndex = 1;
            this.GenFunc.Text = "Generate Function";
            this.GenFunc.UseVisualStyleBackColor = true;
            this.GenFunc.Click += new System.EventHandler(this.GenFunc_Click);
            // 
            // Function
            // 
            this.Function.Location = new System.Drawing.Point(32, 9);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(80, 20);
            this.Function.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "y =";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CleanGraph
            // 
            this.CleanGraph.Location = new System.Drawing.Point(756, 787);
            this.CleanGraph.Name = "CleanGraph";
            this.CleanGraph.Size = new System.Drawing.Size(91, 23);
            this.CleanGraph.TabIndex = 4;
            this.CleanGraph.Text = "Clean Graph";
            this.CleanGraph.UseVisualStyleBackColor = true;
            this.CleanGraph.Click += new System.EventHandler(this.CleanGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 851);
            this.Controls.Add(this.CleanGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.GenFunc);
            this.Controls.Add(this.GenGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenGraph;
        private System.Windows.Forms.Button GenFunc;
        private System.Windows.Forms.TextBox Function;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CleanGraph;
    }
}

