using System;
using System.Windows.Forms;
using Sifon.Abstractions.Plugins;

namespace Sifon.Plugins.Example.SamplePlugin
{
    public class SamplePlugin : IPlugin
    {
        public string Name => "Sample plugin";

        public void MenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Plugin perfectly works", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
