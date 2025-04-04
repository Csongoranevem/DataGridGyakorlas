using System.Configuration;
using System.Data;
using System.Windows;

namespace DataGridGyakorlas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string dataBaseName = "Betegek.db";
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static string dataBasePath = System.IO.Path.Combine(folderPath, dataBaseName);

    }

}
