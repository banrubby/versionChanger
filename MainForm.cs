using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
                projectDropdown.Items.Add(path);
                SetVersion("1.0", path);
            }
        }

        private void projectDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var path = projectDropdown.Items[projectDropdown.SelectedIndex];
            oldVersionInput.Text = GetCurrentVersion((string)path);
        }

        private string GetCurrentVersion(string csProjFile)
        {
            var document = XDocument.Load(csProjFile);
            var projectNode = document.Element("Project");

            if (projectNode == null)
            {
                whatHappenedList.Items.Add($"Не смог найти Project ноды для {csProjFile}");
                return string.Empty;
            }

            var versionNode = projectNode
                .Elements("PropertyGroup")
                .SelectMany(it => it.Elements("Version"))
                .FirstOrDefault();

            return versionNode?.Value ?? string.Empty;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (oldVersionInput.Text == newVersionInput.Text)
            {
                whatHappenedList.Items.Add("Старая и новая версии совпадают!");
                return;
            }

            if (newVersionInput.Text == string.Empty)
            {
                whatHappenedList.Items.Add("Нужно указать новую версию!");
            }

            SetVersion(newVersionInput.Text, projectDropdown.Items[projectDropdown.SelectedIndex] as string);
        }

        private void SetVersion(string version, string csprojFile)
        {
            if (version == null) throw new ArgumentNullException(nameof(version));
            if (csprojFile == null) throw new ArgumentNullException(nameof(csprojFile));

            var document = XDocument.Load(csprojFile);
            var projectNode = document.Element("Project");

            if (projectNode == null)
            {
                whatHappenedList.Items.Add($"Не смог найти Project ноды для {csprojFile}");
                return;
            }

            var propertyGroup = projectNode
                .Element("PropertyGroup");

            if (propertyGroup == null)
            {
                whatHappenedList.Items.Add($"Нет элемента PropertyGroup в {csprojFile}");
                return;
            }
            var elemVersion = propertyGroup.Element("Version");

            if (elemVersion == null)
            {
                var xElemVersion = new XElement("Version");
                xElemVersion.SetValue(version);
                projectNode.Add(xElemVersion);
                return;
            }


            if (elemVersion.Value == version)
            {
                whatHappenedList.Items.Add($"Версия уже поменена для {csprojFile}");
                return;
            }

            elemVersion.SetValue(version);
            File.WriteAllText(csprojFile, document.ToString());

            UpdateFormVersion(version);
        }

        private void UpdateFormVersion(string newVersion)
        {
            if (projectDropdown.Text != string.Empty)
            {
                oldVersionInput.Text = newVersion;
            }
        }
    }
}