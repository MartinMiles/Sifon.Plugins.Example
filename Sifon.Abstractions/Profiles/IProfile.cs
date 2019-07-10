namespace Sifon.Abstractions.Profiles
{
    public interface IProfile
    {
        string Name { get; set; }

        bool Selected { get; set; }

        bool Empty { get; set; }

        string Website { get; set; }

        string Solr { get; set; }

        string Webroot { get; set; }

        ISqlServerRecord SqlServerRecord { get; }
    }
}
