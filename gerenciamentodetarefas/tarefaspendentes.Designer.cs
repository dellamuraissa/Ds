namespace gerenciamentodetarefas
{
    partial class tarefaspendentes
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
            textBoxtarefa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            namebox = new TextBox();
            descbox = new TextBox();
            button5 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // textBoxtarefa
            // 
            textBoxtarefa.Location = new Point(44, 39);
            textBoxtarefa.Multiline = true;
            textBoxtarefa.Name = "textBoxtarefa";
            textBoxtarefa.Size = new Size(254, 256);
            textBoxtarefa.TabIndex = 2;
            textBoxtarefa.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 117);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 13;
            label3.Text = "Descrição";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 58);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome da Tarefa";
            // 
            // namebox
            // 
            namebox.Location = new Point(320, 76);
            namebox.Name = "namebox";
            namebox.Size = new Size(248, 23);
            namebox.TabIndex = 11;
            // 
            // descbox
            // 
            descbox.Location = new Point(320, 135);
            descbox.Multiline = true;
            descbox.Name = "descbox";
            descbox.Size = new Size(248, 63);
            descbox.TabIndex = 10;
            // 
            // button5
            // 
            button5.BackColor = Color.Pink;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(366, 204);
            button5.Name = "button5";
            button5.Size = new Size(70, 37);
            button5.TabIndex = 14;
            button5.Text = "<Anterior";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(442, 204);
            button1.Name = "button1";
            button1.Size = new Size(68, 37);
            button1.TabIndex = 15;
            button1.Text = "Próximo>";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(359, 284);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Pendente";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(358, 307);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Atrasado";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(357, 336);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(81, 19);
            checkBox3.TabIndex = 18;
            checkBox3.Text = "Concluido";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // tarefaspendentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(791, 450);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(namebox);
            Controls.Add(descbox);
            Controls.Add(textBoxtarefa);
            Name = "tarefaspendentes";
            Text = "tarefaspendentes";
            Load += tarefaspendentes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxClientes;
        private Label label3;
        private Label label2;
        private TextBox namebox;
        private TextBox descbox;
        private Button button5;
        private Button button1;
        private TextBox textBoxtarefa;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}