﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using DataGridGyakorlas.model;

namespace DataGridGyakorlas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Beteg> betegek;
        public MainWindow()
        {
            InitializeComponent();
            betegek = new List<Beteg>();

        }

        private void ReadDataBase()
        {
            //using ( SQLiteConnection sQLiteconnection = new SQLite.SQLiteConnection(App.dataBasePath))
            //{
            //    sQLiteconnection.CreateTable<Beteg>();
            //    betegek = sQLiteconnection.Table<Beteg>().ToList();

            //}
            //if (betegek != null)
            //{
            //}




    
        }


    }
}