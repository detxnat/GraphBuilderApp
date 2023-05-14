namespace GraphBuilder;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // Встановлення початкових розмірів canv, де 25 px - відстань між пунктами на вісях X та Y, а 10 - кількість ділянок 
        canv.Width = (int)(25*10*2 + Math.Round(25*1.5));
        canv.Height = (int)(25*10*2 + Math.Round(25*1.5));

        // Початкова розмітка canv
        Bitmap bitmap = DrawEmptyGraph(10, 25);

        canv.Refresh();
        // Встановлення початкової розмітки canv
        canv.Image = bitmap;

        setGradientBg();
    }

    // Метод малювання графіка
    private void DrawGraph(string function, int borders, int scale, Pen pen, Bitmap bitmap)
    {
        try {
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen blackPen = new Pen(Color.Black, 2);

            int xCenter = canv.Width / 2;
            int yCenter = canv.Height / 2;

            var expression = new NCalc.Expression(function);
            Point previousPoint = new Point(0, 0);
            bool isFirstPixel = true;
            for (int i = -xCenter; i <= xCenter; i++)
            {
                expression.Parameters["x"] = i / (double)scale;
                double y = (double)expression.Evaluate();
                int pixelX = i + xCenter;
                int pixelY = yCenter - (int)(y * scale);
                if (pixelY >= 0 && pixelY <= canv.Height)
                {
                    if(isFirstPixel) {
                        previousPoint = new Point(pixelX, pixelY);
                        isFirstPixel = false;
                    }
                    else {
                        graphics.DrawLine(pen, previousPoint, new Point(pixelX, pixelY));
                        previousPoint = new Point(pixelX, pixelY);
                    }
                }
            }
        }
        catch {
            MessageBox.Show("Incorrect entered functions!");
        }
        finally {
            canv.Image = bitmap;
        }
    }

    // Метод відображення пустого графіка з вісями кординат
    private Bitmap DrawEmptyGraph(int borders, int scale)
    {
        Bitmap bitmap = new Bitmap(canv.Width, canv.Height);
        Graphics graphics = Graphics.FromImage(bitmap);

        Pen blackPen = new Pen(Color.Black, 2);

        
        int fontS;
        if(borders == 20 || borders == 25) fontS = 6;
        else fontS = 8;

        canv.Width = (int)(scale *borders*2 + Math.Round(scale*1.5));
        canv.Height = (int)(scale*borders*2 + Math.Round(scale*1.5));

        int xCenter = canv.Width / 2;
        int yCenter = canv.Height / 2;

        // вісь X
        canv.Refresh();
        graphics.DrawLine(blackPen, new Point(0, yCenter), new Point(canv.Width, yCenter));
        for (int i = xCenter; i <= canv.Width; i += scale) {
            graphics.DrawLine(blackPen, new Point(i, yCenter - 5), new Point(i, yCenter + 5));
            graphics.DrawString(((i - xCenter) / scale).ToString(), new Font("Arial", fontS), Brushes.Black, new Point(i - 10, yCenter + 10));
        }
        for (int i = xCenter; i >= 0; i -= scale) {
            graphics.DrawLine(blackPen, new Point(i, yCenter - 5), new Point(i, yCenter + 5));
            graphics.DrawString(((i - xCenter) / scale).ToString(), new Font("Arial", fontS), Brushes.Black, new Point(i - 10, yCenter + 10));
        }

        // вісь Y
        graphics.DrawLine(blackPen, new Point(xCenter, 0), new Point(xCenter, canv.Height));
        for (int i = yCenter; i <= canv.Height; i += scale) {
            graphics.DrawLine(blackPen, new Point(xCenter - 5, i), new Point(xCenter + 5, i));
            graphics.DrawString((-(i - yCenter) / scale).ToString(), new Font("Arial", fontS), Brushes.Black, new Point(xCenter + 10, i - 10));
        }
        for (int i = yCenter; i >= 0; i -= scale) {
            graphics.DrawLine(blackPen, new Point(xCenter - 5, i), new Point(xCenter + 5, i));
            graphics.DrawString((-(i - yCenter) / scale).ToString(), new Font("Arial", fontS), Brushes.Black, new Point(xCenter + 10, i - 10));
        }

        return bitmap;
    }

    private void buttonDraw_Click(object sender, EventArgs e)
    {
        canv.Refresh();

        var btn = (Button)sender;
        string function;
        string previousFunction;
        Pen pen;
        Pen previousPen;
        int selectedBorders;
        var selectedBordersValue = bordersListBox.SelectedItem as string;


        if(selectedBordersValue == null) {
            MessageBox.Show("Borders not selected!");
            return;
        }
        else {
            selectedBorders = Int32.Parse(selectedBordersValue);
        }

        if(btn.Text[btn.Text.Length-1].ToString() == "1") {
            function = functionTextBox.Text;
            pen = new Pen(Color.FromArgb(255, 10, 88, 255), 2);
            previousPen = new Pen(Color.FromArgb(255, 255, 116, 116), 2);
            function1 = function;
            previousFunction = function2;
        }
        else {
            function = functionTextBox2.Text;
            pen = new Pen(Color.FromArgb(255, 255, 116, 116), 2);
            previousPen = new Pen(Color.FromArgb(255, 10, 88, 255), 2);
            function2 = function;
            previousFunction = function1;
        }


        int scale;
        if(selectedBorders == 20 || selectedBorders == 25){
            scale = 15;
        }
        else {
            scale = 25;
        }
        canv.Width = (int)(scale *selectedBorders*2 + Math.Round(scale*1.5));
        canv.Height = (int)(scale*selectedBorders*2 + Math.Round(scale*1.5));
        
        
        Bitmap bitmap = DrawEmptyGraph(selectedBorders, scale);
        if(function != "" && previousFunction != "") {
            DrawGraph(function, selectedBorders, scale, pen, bitmap);
            DrawGraph(previousFunction, selectedBorders, scale, previousPen, bitmap);
        }
        else if(function != "") {
            DrawGraph(function, selectedBorders, scale, pen, bitmap);
        }
        else if(previousFunction != "") {
            DrawGraph(previousFunction, selectedBorders, scale, previousPen, bitmap);
        }
        else 
        {
            canv.Image = bitmap;
        }

        setGradientBg();
        
    }


    private string function1 = "";
    private string function2 = "";
}

