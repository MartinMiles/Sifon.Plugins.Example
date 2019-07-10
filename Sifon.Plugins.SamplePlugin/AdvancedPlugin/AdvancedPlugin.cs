using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Sifon.Abstractions.Plugins;
using Sifon.Abstractions.Profiles;

namespace Sifon.Plugins.Example.AdvancedPlugin
{
    public class AdvancedPlugin : IPlugin
    {
        public string Name => "Advanced plugin";

        public void MenuClick(object sender, EventArgs e)
        {
            var tag = ((ToolStripMenuItem) sender).Tag;

            if (tag is IProfile)
            {
                var profile = tag as IProfile;

                var advancedPluginForm = new AdvancedPluginForm
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Parameters = new Dictionary<string, string>
                    {
                        {"Name", profile.Name},
                        {"Webroot", profile.Webroot},
                        {"Website", profile.Website},
                        {"Solr", profile.Solr},
                        {"SqlServer Name", profile.SqlServerRecord.Name},
                        {"SqlServer Instance", profile.SqlServerRecord.SqlServer},
                        {"SqlServer Username", profile.SqlServerRecord.SqlAdminUsername},
                        {"SqlServer Password", profile.SqlServerRecord.SqlAdminPassword}
                    }
                };
                if (advancedPluginForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
