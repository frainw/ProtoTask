using ProtoTask.Persistence;
using ProtoTask.Entity;
using ProtoTask.GUI;


namespace ProtoTask
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
            //new Repository();

            //Tarefa t = new Tarefa
            //{
            //    Concluida = false,
            //    Descricao = "Codificar lista de tarefas",
            //    Limite = (DateTime.Now.AddDays(2))
            //};

            //new TarefaRepository().Save(t);
        }
    }
}