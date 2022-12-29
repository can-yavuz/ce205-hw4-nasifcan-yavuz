namespace ce205_hw4_gui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AlignmentNeedleman = new System.Windows.Forms.Button();
            this.NeedlemanTextBox2 = new System.Windows.Forms.TextBox();
            this.NeedlemanRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NeedlemanTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SmithrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SmithAlignment = new System.Windows.Forms.Button();
            this.SmithtextBox2 = new System.Windows.Forms.TextBox();
            this.SmithtextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.HuntrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HuntAlignment = new System.Windows.Forms.Button();
            this.HunttextBox2 = new System.Windows.Forms.TextBox();
            this.HunttextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.KnuthrichTextBox = new System.Windows.Forms.RichTextBox();
            this.KnuthtextBox = new System.Windows.Forms.TextBox();
            this.SearchKnuth = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.HorspoolrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HorspooltextBox = new System.Windows.Forms.TextBox();
            this.SearchHorspool = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.BoyerrichTextBox = new System.Windows.Forms.RichTextBox();
            this.BoyertextBox = new System.Windows.Forms.TextBox();
            this.SearchBoyer = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InsertTrie = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SearchTrie = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1828, 785);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.AlignmentNeedleman);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox2);
            this.tabPage1.Controls.Add(this.NeedlemanRichTextBox);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1820, 756);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Needleman-Wunsch";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 60);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "Random";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(786, 465);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Needleman-Wunsch";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AlignmentNeedleman
            // 
            this.AlignmentNeedleman.Location = new System.Drawing.Point(912, 30);
            this.AlignmentNeedleman.Margin = new System.Windows.Forms.Padding(4);
            this.AlignmentNeedleman.Name = "AlignmentNeedleman";
            this.AlignmentNeedleman.Size = new System.Drawing.Size(100, 52);
            this.AlignmentNeedleman.TabIndex = 4;
            this.AlignmentNeedleman.Text = "Alignment";
            this.AlignmentNeedleman.UseVisualStyleBackColor = true;
            this.AlignmentNeedleman.Click += new System.EventHandler(this.AlignmentNeedleman_Click);
            // 
            // NeedlemanTextBox2
            // 
            this.NeedlemanTextBox2.Location = new System.Drawing.Point(61, 60);
            this.NeedlemanTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.NeedlemanTextBox2.Name = "NeedlemanTextBox2";
            this.NeedlemanTextBox2.Size = new System.Drawing.Size(735, 22);
            this.NeedlemanTextBox2.TabIndex = 3;
            // 
            // NeedlemanRichTextBox
            // 
            this.NeedlemanRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedlemanRichTextBox.Location = new System.Drawing.Point(61, 108);
            this.NeedlemanRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NeedlemanRichTextBox.Name = "NeedlemanRichTextBox";
            this.NeedlemanRichTextBox.Size = new System.Drawing.Size(951, 350);
            this.NeedlemanRichTextBox.TabIndex = 2;
            this.NeedlemanRichTextBox.Text = "";
            // 
            // NeedlemanTextBox1
            // 
            this.NeedlemanTextBox1.Location = new System.Drawing.Point(61, 30);
            this.NeedlemanTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.NeedlemanTextBox1.Name = "NeedlemanTextBox1";
            this.NeedlemanTextBox1.Size = new System.Drawing.Size(735, 22);
            this.NeedlemanTextBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.SmithrichTextBox);
            this.tabPage2.Controls.Add(this.SmithAlignment);
            this.tabPage2.Controls.Add(this.SmithtextBox2);
            this.tabPage2.Controls.Add(this.SmithtextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1820, 756);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Smith-Waterman";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(758, 465);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Smith-Waterman";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(804, 60);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 22);
            this.button4.TabIndex = 6;
            this.button4.Text = "Random";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(804, 30);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "Random";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SmithrichTextBox
            // 
            this.SmithrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SmithrichTextBox.Location = new System.Drawing.Point(61, 108);
            this.SmithrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SmithrichTextBox.Name = "SmithrichTextBox";
            this.SmithrichTextBox.Size = new System.Drawing.Size(951, 350);
            this.SmithrichTextBox.TabIndex = 3;
            this.SmithrichTextBox.Text = "";
            // 
            // SmithAlignment
            // 
            this.SmithAlignment.Location = new System.Drawing.Point(912, 30);
            this.SmithAlignment.Margin = new System.Windows.Forms.Padding(4);
            this.SmithAlignment.Name = "SmithAlignment";
            this.SmithAlignment.Size = new System.Drawing.Size(100, 52);
            this.SmithAlignment.TabIndex = 2;
            this.SmithAlignment.Text = "Alignment";
            this.SmithAlignment.UseVisualStyleBackColor = true;
            this.SmithAlignment.Click += new System.EventHandler(this.SmithAlignment_Click);
            // 
            // SmithtextBox2
            // 
            this.SmithtextBox2.Location = new System.Drawing.Point(61, 60);
            this.SmithtextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.SmithtextBox2.Name = "SmithtextBox2";
            this.SmithtextBox2.Size = new System.Drawing.Size(735, 22);
            this.SmithtextBox2.TabIndex = 1;
            // 
            // SmithtextBox1
            // 
            this.SmithtextBox1.Location = new System.Drawing.Point(61, 30);
            this.SmithtextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SmithtextBox1.Name = "SmithtextBox1";
            this.SmithtextBox1.Size = new System.Drawing.Size(735, 22);
            this.SmithtextBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.HuntrichTextBox);
            this.tabPage3.Controls.Add(this.HuntAlignment);
            this.tabPage3.Controls.Add(this.HunttextBox2);
            this.tabPage3.Controls.Add(this.HunttextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1820, 756);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hunt–Szymanski";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(786, 465);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 22);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Hunt-Szymanski";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(804, 60);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 22);
            this.button6.TabIndex = 6;
            this.button6.Text = "Random";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(804, 30);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 22);
            this.button5.TabIndex = 5;
            this.button5.Text = "Random";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // HuntrichTextBox
            // 
            this.HuntrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.HuntrichTextBox.Location = new System.Drawing.Point(61, 108);
            this.HuntrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HuntrichTextBox.Name = "HuntrichTextBox";
            this.HuntrichTextBox.Size = new System.Drawing.Size(951, 350);
            this.HuntrichTextBox.TabIndex = 3;
            this.HuntrichTextBox.Text = "";
            // 
            // HuntAlignment
            // 
            this.HuntAlignment.Location = new System.Drawing.Point(912, 30);
            this.HuntAlignment.Margin = new System.Windows.Forms.Padding(4);
            this.HuntAlignment.Name = "HuntAlignment";
            this.HuntAlignment.Size = new System.Drawing.Size(100, 52);
            this.HuntAlignment.TabIndex = 2;
            this.HuntAlignment.Text = "Alignment";
            this.HuntAlignment.UseVisualStyleBackColor = true;
            this.HuntAlignment.Click += new System.EventHandler(this.HuntAlignment_Click);
            // 
            // HunttextBox2
            // 
            this.HunttextBox2.Location = new System.Drawing.Point(61, 60);
            this.HunttextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.HunttextBox2.Name = "HunttextBox2";
            this.HunttextBox2.Size = new System.Drawing.Size(735, 22);
            this.HunttextBox2.TabIndex = 1;
            // 
            // HunttextBox1
            // 
            this.HunttextBox1.Location = new System.Drawing.Point(61, 30);
            this.HunttextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.HunttextBox1.Name = "HunttextBox1";
            this.HunttextBox1.Size = new System.Drawing.Size(735, 22);
            this.HunttextBox1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.KnuthrichTextBox);
            this.tabPage4.Controls.Add(this.KnuthtextBox);
            this.tabPage4.Controls.Add(this.SearchKnuth);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1820, 756);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Knuth-Morris-Pratt";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(786, 465);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(226, 22);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Knuth-Morris-Pratt";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KnuthrichTextBox
            // 
            this.KnuthrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KnuthrichTextBox.Location = new System.Drawing.Point(61, 108);
            this.KnuthrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KnuthrichTextBox.Name = "KnuthrichTextBox";
            this.KnuthrichTextBox.Size = new System.Drawing.Size(951, 350);
            this.KnuthrichTextBox.TabIndex = 2;
            this.KnuthrichTextBox.Text = resources.GetString("KnuthrichTextBox.Text");
            // 
            // KnuthtextBox
            // 
            this.KnuthtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KnuthtextBox.Location = new System.Drawing.Point(169, 48);
            this.KnuthtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KnuthtextBox.Multiline = true;
            this.KnuthtextBox.Name = "KnuthtextBox";
            this.KnuthtextBox.Size = new System.Drawing.Size(843, 52);
            this.KnuthtextBox.TabIndex = 1;
            // 
            // SearchKnuth
            // 
            this.SearchKnuth.Location = new System.Drawing.Point(61, 48);
            this.SearchKnuth.Margin = new System.Windows.Forms.Padding(4);
            this.SearchKnuth.Name = "SearchKnuth";
            this.SearchKnuth.Size = new System.Drawing.Size(100, 52);
            this.SearchKnuth.TabIndex = 0;
            this.SearchKnuth.Text = "Search";
            this.SearchKnuth.UseVisualStyleBackColor = true;
            this.SearchKnuth.Click += new System.EventHandler(this.SearchKnuth_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.HorspoolrichTextBox);
            this.tabPage5.Controls.Add(this.HorspooltextBox);
            this.tabPage5.Controls.Add(this.SearchHorspool);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1820, 756);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Horspool";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(786, 465);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(226, 22);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Horspool";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HorspoolrichTextBox
            // 
            this.HorspoolrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HorspoolrichTextBox.Location = new System.Drawing.Point(61, 108);
            this.HorspoolrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HorspoolrichTextBox.Name = "HorspoolrichTextBox";
            this.HorspoolrichTextBox.Size = new System.Drawing.Size(951, 350);
            this.HorspoolrichTextBox.TabIndex = 2;
            this.HorspoolrichTextBox.Text = resources.GetString("HorspoolrichTextBox.Text");
            this.HorspoolrichTextBox.TextChanged += new System.EventHandler(this.HorspoolrichTextBox_TextChanged);
            // 
            // HorspooltextBox
            // 
            this.HorspooltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HorspooltextBox.Location = new System.Drawing.Point(169, 48);
            this.HorspooltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HorspooltextBox.Multiline = true;
            this.HorspooltextBox.Name = "HorspooltextBox";
            this.HorspooltextBox.Size = new System.Drawing.Size(843, 52);
            this.HorspooltextBox.TabIndex = 1;
            // 
            // SearchHorspool
            // 
            this.SearchHorspool.Location = new System.Drawing.Point(61, 48);
            this.SearchHorspool.Margin = new System.Windows.Forms.Padding(4);
            this.SearchHorspool.Name = "SearchHorspool";
            this.SearchHorspool.Size = new System.Drawing.Size(100, 52);
            this.SearchHorspool.TabIndex = 0;
            this.SearchHorspool.Text = "Search";
            this.SearchHorspool.UseVisualStyleBackColor = true;
            this.SearchHorspool.Click += new System.EventHandler(this.SearchHorspool_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage6.Controls.Add(this.textBox8);
            this.tabPage6.Controls.Add(this.BoyerrichTextBox);
            this.tabPage6.Controls.Add(this.BoyertextBox);
            this.tabPage6.Controls.Add(this.SearchBoyer);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(1820, 756);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Boyer-Moore";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(786, 465);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(226, 22);
            this.textBox8.TabIndex = 6;
            this.textBox8.Text = "Boyer-Moore";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BoyerrichTextBox
            // 
            this.BoyerrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoyerrichTextBox.Location = new System.Drawing.Point(61, 108);
            this.BoyerrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BoyerrichTextBox.Name = "BoyerrichTextBox";
            this.BoyerrichTextBox.Size = new System.Drawing.Size(951, 350);
            this.BoyerrichTextBox.TabIndex = 2;
            this.BoyerrichTextBox.Text = resources.GetString("BoyerrichTextBox.Text");
            // 
            // BoyertextBox
            // 
            this.BoyertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoyertextBox.Location = new System.Drawing.Point(169, 48);
            this.BoyertextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BoyertextBox.Multiline = true;
            this.BoyertextBox.Name = "BoyertextBox";
            this.BoyertextBox.Size = new System.Drawing.Size(843, 52);
            this.BoyertextBox.TabIndex = 1;
            // 
            // SearchBoyer
            // 
            this.SearchBoyer.Location = new System.Drawing.Point(61, 48);
            this.SearchBoyer.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBoyer.Name = "SearchBoyer";
            this.SearchBoyer.Size = new System.Drawing.Size(100, 52);
            this.SearchBoyer.TabIndex = 0;
            this.SearchBoyer.Text = "Search";
            this.SearchBoyer.UseVisualStyleBackColor = true;
            this.SearchBoyer.Click += new System.EventHandler(this.SearchBoyer_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage7.Controls.Add(this.textBox9);
            this.tabPage7.Controls.Add(this.button7);
            this.tabPage7.Controls.Add(this.richTextBox2);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Controls.Add(this.InsertTrie);
            this.tabPage7.Controls.Add(this.richTextBox1);
            this.tabPage7.Controls.Add(this.SearchTrie);
            this.tabPage7.Controls.Add(this.textBox2);
            this.tabPage7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(1820, 756);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Trie";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(797, 473);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(226, 22);
            this.textBox9.TabIndex = 10;
            this.textBox9.Text = "Trie";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button7.Location = new System.Drawing.Point(133, 24);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 52);
            this.button7.TabIndex = 9;
            this.button7.Text = "Random";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(550, 87);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(473, 379);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 52);
            this.textBox1.TabIndex = 7;
            // 
            // InsertTrie
            // 
            this.InsertTrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.InsertTrie.Location = new System.Drawing.Point(25, 24);
            this.InsertTrie.Margin = new System.Windows.Forms.Padding(4);
            this.InsertTrie.Name = "InsertTrie";
            this.InsertTrie.Size = new System.Drawing.Size(100, 52);
            this.InsertTrie.TabIndex = 6;
            this.InsertTrie.Text = "Insert";
            this.InsertTrie.UseVisualStyleBackColor = true;
            this.InsertTrie.Click += new System.EventHandler(this.InsertTrie_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 87);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(473, 379);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // SearchTrie
            // 
            this.SearchTrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SearchTrie.Location = new System.Drawing.Point(550, 24);
            this.SearchTrie.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTrie.Name = "SearchTrie";
            this.SearchTrie.Size = new System.Drawing.Size(100, 52);
            this.SearchTrie.TabIndex = 4;
            this.SearchTrie.Text = "Search";
            this.SearchTrie.UseVisualStyleBackColor = true;
            this.SearchTrie.Click += new System.EventHandler(this.SearchTrie_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(658, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 49);
            this.textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1064, 539);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button SearchTrie;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button InsertTrie;
        public System.Windows.Forms.TextBox NeedlemanTextBox2;
        public System.Windows.Forms.RichTextBox NeedlemanRichTextBox;
        public System.Windows.Forms.TextBox NeedlemanTextBox1;
        public System.Windows.Forms.Button AlignmentNeedleman;
        public System.Windows.Forms.TextBox KnuthtextBox;
        public System.Windows.Forms.Button SearchKnuth;
        public System.Windows.Forms.RichTextBox KnuthrichTextBox;
        public System.Windows.Forms.RichTextBox BoyerrichTextBox;
        public System.Windows.Forms.TextBox BoyertextBox;
        public System.Windows.Forms.Button SearchBoyer;
        private System.Windows.Forms.RichTextBox HorspoolrichTextBox;
        private System.Windows.Forms.TextBox HorspooltextBox;
        private System.Windows.Forms.Button SearchHorspool;
        private System.Windows.Forms.RichTextBox SmithrichTextBox;
        private System.Windows.Forms.Button SmithAlignment;
        private System.Windows.Forms.TextBox SmithtextBox2;
        private System.Windows.Forms.TextBox SmithtextBox1;
        private System.Windows.Forms.RichTextBox HuntrichTextBox;
        private System.Windows.Forms.Button HuntAlignment;
        private System.Windows.Forms.TextBox HunttextBox2;
        private System.Windows.Forms.TextBox HunttextBox1;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}

