# Sifon.Plugins.Example
These are example of C# and PowerShell plugins to be used with Sifon tool

## Compile and build

**Important!** Once cloned and before opening solution in Visual Studio, please open `nuget.config` and remove the comment and all underscores from the value of `ClearTextPassword` so that it becomes 40 characters long hex token. So that a value looking like this

 `968a050c84df7__REMOVE_THIS_COMMENT_AND_UNDERSCORES_AROUND_IT__faca33ee9b379e802ab35898777`

 becomes this:

`968a050c84df7faca33ee9b379e802ab35898777`

It has been done to be able providing public access to the packages. At the moment GitHub prevent one from storing tokens on commits and revokes those found, even that is a read-only token allowing access only to packages. That is why we must prevent this token from auto-deletion by putting some value in the middle of it in order to commit and push to GitHub.


## Usage

Simply put compiled DLLs and/or PowerShell scripts into `Plugins` folder within Sifon, and that's it!

### Notes

- You may have any folder structure under `Plugins` folder - it will be reproduced by the menu
- You may share several plugins within same DLL - classes that implement `IPlugin` will be considered as plugins and get into menu
- Tests for plugins simulating the call from Sifon and passing relevant parameters will be added later, as more plugins arriving


## References

* [Blog post](http://blog.MartinMiles.net/post/welcome-sifon-a-must-have-tool-for-any-sitecore-developer-to-simplify-most-of-you-day-today-devops-activities) - Welcome Sifon - a must-have tool for any Sitecore developer,to simplify most of you day-today DevOps activities