# Sifon.Plugins.Example
These are example of C# and PowerShell plugins to be used with Sifon tool

## Usage

Simply put compiled DLLs and/or PowerShell scripts into `Plugins` folder within Sifon, and that's it!

### Notes

- You may have any folder structure under `Plugins` folder - it will be reproduced by the menu
- You may share several plugins within same DLL - classes that implement `IPlugin` will be considered as plugins and get into menu
- Tests for plugins simulating the call from Sifon and passing relevant parameters will be added later, as more plugins arriving


## References

* [Blog post](http://blog.MartinMiles.net/post/welcome-sifon-a-must-have-tool-for-any-sitecore-developer-to-simplify-most-of-you-day-today-devops-activities) - Welcome Sifon - a must-have tool for any Sitecore developer,to simplify most of you day-today DevOps activities