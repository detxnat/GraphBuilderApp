namespace GraphBuilder;

class Form2 : Form
{
    public Form2() 
    {
        InitializeComponent();
    }
    private void InitializeComponent()
    {
        this.Text = "Fast Graph Builder Functions";
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Size = new Size(640, 855);
        this.MinimumSize = this.Size;
        this.MaximumSize = this.Size;
        this.Font = new Font("Arial", 12, FontStyle.Regular);
        this.BackColor = Color.FromArgb(255, 133, 97, 235);
        this.ForeColor = Color.White;

        TableLayoutPanel tableLayout = new TableLayoutPanel();
        tableLayout.Dock = DockStyle.Fill;
        tableLayout.ColumnCount = 2;
        tableLayout.RowCount = 17;
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

        tableLayout.Controls.Add(new Label() { Text = "Function", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 0);
        tableLayout.Controls.Add(new Label() { Text = "Description", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 0);
        tableLayout.Controls.Add(new Label() { Text = "Truncate(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 1);
        tableLayout.Controls.Add(new Label() { Text = "Calculates an integral part of a number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 1);
        tableLayout.Controls.Add(new Label() { Text = "Acos(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 2);
        tableLayout.Controls.Add(new Label() { Text = "Returns the angle whose cosine is the specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 2);
        tableLayout.Controls.Add(new Label() { Text = "Asin(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 3);
        tableLayout.Controls.Add(new Label() { Text = "Returns the angle whose sine is the specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 3);
        tableLayout.Controls.Add(new Label() { Text = "Atan(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 4);
        tableLayout.Controls.Add(new Label() { Text = "Returns the angle whose tangent is the specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 4);
        tableLayout.Controls.Add(new Label() { Text = "Ceiling(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 5);
        tableLayout.Controls.Add(new Label() { Text = "Returns the smallest integer greater than or equal to the specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 5);
        tableLayout.Controls.Add(new Label() { Text = "Cos(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 6);
        tableLayout.Controls.Add(new Label() { Text = "Returns the cosine of the specified angle.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 6);
        tableLayout.Controls.Add(new Label() { Text = "Exp(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 7);
        tableLayout.Controls.Add(new Label() { Text = "Returns e raised to the specified power.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 7);
        tableLayout.Controls.Add(new Label() { Text = "Floor(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 8);
        tableLayout.Controls.Add(new Label() { Text = "Returns the largest integer less than or equal to the specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 8);
        tableLayout.Controls.Add(new Label() { Text = "Round(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 9);
        tableLayout.Controls.Add(new Label() { Text = "Rounds a value to the nearest integer or specified number of decimal places. The mid number behavior can be changed by using EvaluateOption.RoundAwayFromZero during construction of the Expression object.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 9);
        tableLayout.Controls.Add(new Label() { Text = "Log(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 10);
        tableLayout.Controls.Add(new Label() { Text = "Returns the logarithm of a specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 10);
        tableLayout.Controls.Add(new Label() { Text = "Log10(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 11);
        tableLayout.Controls.Add(new Label() { Text = "Returns the base 10 logarithm of a specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 11);
        tableLayout.Controls.Add(new Label() { Text = "Max(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 12);
        tableLayout.Controls.Add(new Label() { Text = "Returns the larger of two specified numbers.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 12);
        tableLayout.Controls.Add(new Label() { Text = "Min(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 13);
        tableLayout.Controls.Add(new Label() { Text = "Returns the smaller of two numbers.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 13);
        tableLayout.Controls.Add(new Label() { Text = "Pow(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 14);
        tableLayout.Controls.Add(new Label() { Text = "Returns a specified number raised to the specified power.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 14);
        tableLayout.Controls.Add(new Label() { Text = "Sin(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 15);
        tableLayout.Controls.Add(new Label() { Text = "Returns the sine of the specified angle.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 15);
        tableLayout.Controls.Add(new Label() { Text = "Sqrt(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 16);
        tableLayout.Controls.Add(new Label() { Text = "Returns the square root of a specified number.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 16);
        tableLayout.Controls.Add(new Label() { Text = "Tan(...)", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 0, 17);
        tableLayout.Controls.Add(new Label() { Text = "Returns the tangent of the specified angle.", AutoSize = true, Padding = new Padding(5), BackColor = Color.FromArgb(0, 0,0,0) }, 1, 17);

        this.Controls.Add(tableLayout);
    }
}