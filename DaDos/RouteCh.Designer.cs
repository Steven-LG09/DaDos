namespace DaDos
{
    partial class RouteCh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteCh));
            this.label1 = new System.Windows.Forms.Label();
            this.Routes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.selected = new System.Windows.Forms.Label();
            this.continuar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkerList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.worker = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RefList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.refer = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la Ruta";
            // 
            // Routes
            // 
            this.Routes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Routes.FormattingEnabled = true;
            this.Routes.ItemHeight = 15;
            this.Routes.Items.AddRange(new object[] {
            "Ruta X",
            "Ruta Y",
            "Ruta Z"});
            this.Routes.Location = new System.Drawing.Point(16, 36);
            this.Routes.Name = "Routes";
            this.Routes.Size = new System.Drawing.Size(116, 49);
            this.Routes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selected
            // 
            this.selected.AutoSize = true;
            this.selected.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected.ForeColor = System.Drawing.Color.Transparent;
            this.selected.Location = new System.Drawing.Point(46, 117);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(29, 19);
            this.selected.TabIndex = 3;
            this.selected.Text = "     ";
            // 
            // continuar
            // 
            this.continuar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar.Location = new System.Drawing.Point(480, 132);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(67, 23);
            this.continuar.TabIndex = 4;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Visible = false;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(148, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione el Operario";
            // 
            // WorkerList
            // 
            this.WorkerList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerList.FormattingEnabled = true;
            this.WorkerList.ItemHeight = 15;
            this.WorkerList.Items.AddRange(new object[] {
            "Joaquin Medina",
            "Manuel Franco",
            "Pedro Valles"});
            this.WorkerList.Location = new System.Drawing.Point(152, 36);
            this.WorkerList.Name = "WorkerList";
            this.WorkerList.Size = new System.Drawing.Size(143, 49);
            this.WorkerList.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // worker
            // 
            this.worker.AutoSize = true;
            this.worker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker.ForeColor = System.Drawing.Color.Transparent;
            this.worker.Location = new System.Drawing.Point(182, 117);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(33, 19);
            this.worker.TabIndex = 8;
            this.worker.Text = "      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(317, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione la Referencia";
            // 
            // RefList
            // 
            this.RefList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefList.FormattingEnabled = true;
            this.RefList.ItemHeight = 15;
            this.RefList.Items.AddRange(new object[] {
            "S-R32",
            "S-R33",
            "S-R34"});
            this.RefList.Location = new System.Drawing.Point(321, 36);
            this.RefList.Name = "RefList";
            this.RefList.Size = new System.Drawing.Size(143, 49);
            this.RefList.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(354, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // refer
            // 
            this.refer.AutoSize = true;
            this.refer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refer.ForeColor = System.Drawing.Color.Transparent;
            this.refer.Location = new System.Drawing.Point(359, 117);
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(33, 19);
            this.refer.TabIndex = 12;
            this.refer.Text = "      ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(480, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RouteCh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 157);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.refer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RefList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.worker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WorkerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Routes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(570, 200);
            this.MinimumSize = new System.Drawing.Size(570, 200);
            this.Name = "RouteCh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company\'s Route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Routes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox WorkerList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label worker;
        public System.Windows.Forms.Label selected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox RefList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label refer;
        private System.Windows.Forms.Button button4;
    }
}