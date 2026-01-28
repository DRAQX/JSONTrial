namespace JSONTrial
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btn_deserialize = new Button();
            btn_serialize = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(343, 165);
            dataGridView1.TabIndex = 0;
            // 
            // btn_deserialize
            // 
            btn_deserialize.Location = new Point(596, 12);
            btn_deserialize.Name = "btn_deserialize";
            btn_deserialize.Size = new Size(75, 96);
            btn_deserialize.TabIndex = 1;
            btn_deserialize.Text = "Deserialize";
            btn_deserialize.UseVisualStyleBackColor = true;
            btn_deserialize.Click += btn_deserialize_Click;
            // 
            // btn_serialize
            // 
            btn_serialize.Location = new Point(596, 153);
            btn_serialize.Name = "btn_serialize";
            btn_serialize.Size = new Size(75, 96);
            btn_serialize.TabIndex = 1;
            btn_serialize.Text = "Serialize";
            btn_serialize.UseVisualStyleBackColor = true;
            btn_serialize.Click += btn_serialize_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(361, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(229, 336);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 183);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(343, 165);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 354);
            listView1.Name = "listView1";
            listView1.Size = new Size(578, 142);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 508);
            Controls.Add(listView1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(btn_serialize);
            Controls.Add(btn_deserialize);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_deserialize;
        private Button btn_serialize;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private ListView listView1;
    }
}
