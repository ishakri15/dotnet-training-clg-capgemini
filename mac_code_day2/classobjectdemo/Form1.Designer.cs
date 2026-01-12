namespace classobjectdemo;

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
        button1 = new Button();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.Yellow;
        button1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(276, 460);
        button1.Name = "button1";
        button1.Size = new Size(366, 164);
        button1.TabIndex = 0;
        button1.Text = "click me ";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        textBox1.Location = new Point(374, 229);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(150, 37);
        textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        textBox2.Location = new Point(374, 347);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(150, 37);
        textBox2.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        label1.Location = new Point(192, 242);
        label1.Name = "label1";
        label1.Size = new Size(75, 30);
        label1.TabIndex = 3;
        label1.Text = "salary";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        label2.Location = new Point(194, 347);
        label2.Name = "label2";
        label2.Size = new Size(76, 30);
        label2.TabIndex = 4;
        label2.Text = "bonus";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 192, 192);
        ClientSize = new Size(1143, 753);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private Button button1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private Label label2;

    #endregion
}
