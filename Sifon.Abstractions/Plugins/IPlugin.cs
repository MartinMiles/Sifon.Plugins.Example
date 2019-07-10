using System;

namespace Sifon.Abstractions.Plugins
{
    public interface IPlugin
    {
        string Name { get; }
        void MenuClick(object sender, EventArgs e);
    }
}
