namespace Sifon.Abstractions.Profiles
{
    public interface ISqlServerRecord
    {
        #region Properties

        string Name { get; set; }

        string SqlServer { get; set; }

        string SqlAdminUsername { get; set; }

        string SqlAdminPassword { get; set; }

        #endregion
    }
}
