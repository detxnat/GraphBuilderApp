namespace GraphBuilder;

// Головний клас застосунку с точкою запуску Main
static class Program
{
    [STAThread]
    static void Main()
    {
        // Завантаження конфігурації
        ApplicationConfiguration.Initialize();
        // Відображення головної форми Form1
        Application.Run(new Form1());
    }    
}