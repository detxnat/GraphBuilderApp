using System.Drawing.Drawing2D;

namespace GraphBuilder;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;


    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }


    private void InitializeComponent()
    {
        //
        // Form 1
        //
        this.components = new System.ComponentModel.Container();

        // Назва заголовку головної форми
        this.Text = "Fast Graph Builder";
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

        // Налаштування розмірів форми(Заборона зміни розміру самостійно та 
        // надання властивості автоматичного розтягування на розмір елементів всередині)
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.AutoSize = true;
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.MinimumSize = this.Size;

        // Колір тексту всередині форми
        this.ForeColor = Color.White;

        //
        // Initialization of elements
        //
        enterFunctionLabel = new System.Windows.Forms.Label();
        functionTextBox = new System.Windows.Forms.TextBox();
        System.Windows.Forms.Label bordersLabel = new System.Windows.Forms.Label();
        bordersListBox = new System.Windows.Forms.ListBox();
        calcFunctionButton = new System.Windows.Forms.Button();
        enterFunctionLabel2 = new System.Windows.Forms.Label();
        functionTextBox2 = new System.Windows.Forms.TextBox();
        calcFunctionButton2 = new System.Windows.Forms.Button();
        canv = new System.Windows.Forms.PictureBox();
        instruction = new System.Windows.Forms.Button();
        clear = new System.Windows.Forms.Button();

        //
        // enterFunctionLabel
        //
        enterFunctionLabel.Text = "Enter f1(x): ";
        enterFunctionLabel.BackColor = Color.FromArgb(0, 0,0,0);
        enterFunctionLabel.Size = new System.Drawing.Size(100, 20);
        enterFunctionLabel.Location = new System.Drawing.Point(3, 59);
        enterFunctionLabel.Font = new Font("Arial", 13, FontStyle.Regular);
        //
        // functionTextBox
        //
        functionTextBox.AutoSize = false;
        functionTextBox.Size = new System.Drawing.Size(240, 34);
        functionTextBox.Location = new System.Drawing.Point(103, 53);
        functionTextBox.BackColor = Color.FromArgb(255, 218, 217, 236);
        functionTextBox.Font = new Font("Arial", 16, FontStyle.Regular);
        //
        // calcFunctionButton
        //
        calcFunctionButton.Text = "Draw1";
        calcFunctionButton.Size = new System.Drawing.Size(67, 36);
        calcFunctionButton.Location = new System.Drawing.Point(413, 53);
        calcFunctionButton.BackColor = Color.FromArgb(255, 218, 217, 236);
        calcFunctionButton.ForeColor = Color.Black;
        calcFunctionButton.Font = new Font("Arial", 11, FontStyle.Regular);
        //
        // bordersLabel
        //
        bordersLabel.Text = "Borders";
        bordersLabel.Size = new System.Drawing.Size(50,20);
        bordersLabel.Location = new System.Drawing.Point(353, 55);
        bordersLabel.BackColor = Color.FromArgb(0, 0,0,0);
        //
        // bordersListBox
        //
        bordersListBox.Size = new System.Drawing.Size(50,60);
        bordersListBox.Location = new System.Drawing.Point(353, 78);
        bordersListBox.BackColor = Color.FromArgb(255, 218, 217, 236);
        string[] bordersRange = {"5", "10", "15", "20", "25"};
        bordersListBox.Items.AddRange(bordersRange);
        //
        // enterFunctionLabel2
        //
        enterFunctionLabel2.Text = "Enter f2(x): ";
        enterFunctionLabel2.Size = new System.Drawing.Size(100, 20);
        enterFunctionLabel2.Location = new System.Drawing.Point(3, 99);
        enterFunctionLabel2.BackColor = Color.FromArgb(0, 0,0,0);
        enterFunctionLabel2.Font = new Font("Arial", 13, FontStyle.Regular);
        //
        // functionTextBox2
        //
        functionTextBox2.AutoSize = false;
        functionTextBox2.Size = new System.Drawing.Size(240, 34);
        functionTextBox2.Location = new System.Drawing.Point(103, 93);
        functionTextBox2.BackColor = Color.FromArgb(255, 218, 217, 236);
        functionTextBox2.Font = new Font("Arial", 16, FontStyle.Regular);
        //
        // calcFunctionButton2
        //
        calcFunctionButton2.Text = "Draw2";
        calcFunctionButton2.Size = new System.Drawing.Size(67, 36);
        calcFunctionButton2.Location = new System.Drawing.Point(413, 93);
        calcFunctionButton2.BackColor = Color.FromArgb(255, 218, 217, 236);
        calcFunctionButton2.ForeColor = Color.Black;
        calcFunctionButton2.Font = new Font("Arial", 11, FontStyle.Regular);
        //
        // canv
        //
        canv.Location = new System.Drawing.Point(3, 150);
        canv.BackColor = Color.FromArgb(255, 218, 217, 236);
        canv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //
        // instruction
        //
        instruction.Text = "Functions";
        instruction.Size = new System.Drawing.Size(80, 36);
        instruction.Location = new System.Drawing.Point(3, 3);
        instruction.BackColor = Color.FromArgb(255, 218, 217, 236);
        instruction.ForeColor = Color.Black;
        instruction.Font = new Font("Arial", 11, FontStyle.Regular);
        //
        // clear
        //
        clear.Text = "Clear";
        clear.Size = new System.Drawing.Size(80, 36);
        clear.Location = new System.Drawing.Point(86, 3);
        clear.BackColor = Color.FromArgb(255, 218, 217, 236);
        clear.ForeColor = Color.Black;
        clear.Font = new Font("Arial", 11, FontStyle.Regular);

        //
        // Adding elements
        //
        this.Controls.Add(enterFunctionLabel);
        this.Controls.Add(functionTextBox);
        this.Controls.Add(bordersLabel);
        this.Controls.Add(bordersListBox);
        this.Controls.Add(calcFunctionButton);
        this.Controls.Add(enterFunctionLabel2);
        this.Controls.Add(functionTextBox2);
        this.Controls.Add(calcFunctionButton2);
        this.Controls.Add(canv);
        this.Controls.Add(instruction);
        this.Controls.Add(clear);

        //
        // Binding functions
        //
        calcFunctionButton.Click += new System.EventHandler(buttonDraw_Click);
        calcFunctionButton2.Click += new System.EventHandler(buttonDraw_Click);
        instruction.Click += new System.EventHandler((object sender, EventArgs e) => {
            Form2 f2 = new Form2();
            f2.Show();
        });
        clear.Click += new System.EventHandler((object sender, EventArgs e) => {
            canv.Width = (int)(25*10*2 + Math.Round(25*1.5));
            canv.Height = (int)(25*10*2 + Math.Round(25*1.5));

            Bitmap bitmap = DrawEmptyGraph(10, 25);

            canv.Refresh();
            canv.Image = bitmap;

            functionTextBox.Text = "";
            functionTextBox2.Text = "";

            function1 = "";
            function2 = "";

            setGradientBg();
        });
        
        //
        // Setting gradient background
        //
        setGradientBg();
    }



    // Метод для створення градіентного фону форми
    private void setGradientBg() 
    {
        LinearGradientBrush gradientBrush = new LinearGradientBrush
        (
            this.ClientRectangle,
            Color.FromArgb(255, 133, 97, 235),
            Color.FromArgb(255, 204, 125, 125),
            LinearGradientMode.Horizontal
        );
        this.BackgroundImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
        Graphics.FromImage(this.BackgroundImage).FillRectangle(gradientBrush, this.ClientRectangle);
    }



    private System.Windows.Forms.Label enterFunctionLabel;
    // Текст з інформацією про те де треба вводити функцію 1
    private System.Windows.Forms.TextBox functionTextBox;
    // Текст бокс для вводу функції 1
    private System.Windows.Forms.Button calcFunctionButton;
    // Кнопка для початку розрахунку і відображення значень функції 1


    private System.Windows.Forms.ListBox bordersListBox;
    // Ліст бокс потрібний для вибору області відображення значень функції(межі x та y)


    private System.Windows.Forms.Label enterFunctionLabel2;
    // Текст з інформацією про те де треба вводити функцію 2
    private System.Windows.Forms.TextBox functionTextBox2;
    // Текст бокс для вводу функції 2
    private System.Windows.Forms.Button calcFunctionButton2;
    // Кнопка для початку розрахунку і відображення значень функції 2


    private System.Windows.Forms.PictureBox canv;
    // Picture Box, що являє собою Canvas для відображень графіків
    private System.Windows.Forms.Button instruction;
    // Кнопка відкриття інструкції користування
    private System.Windows.Forms.Button clear;
    // Кнопка очищення вже намальованих графіків

}


