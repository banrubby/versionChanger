using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VersionChanger
{
    public partial class VersionChanger : Form
    {
        public VersionChanger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            whatHappenedList.Items.Add("Доброго времени суток, дорогие друзья!");
            string rootDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            whatHappenedList.Items.Add($"root-directory: {rootDirectory}");
            var filePaths = Directory.GetFiles(rootDirectory, "*.csproj", SearchOption.AllDirectories).Where(x => !x.Contains("VersionChanger"));
            foreach (var path in filePaths)
            {
                whatHappenedList.Items.Add($"найден проект {path}");
            }
        }
    }
}