namespace Katharos.Core
{
    public class Snapshot
    {
        #region Properties

        public string  SiteTitle  { get; set; } = string.empty;
        public Url     Site       { get; set; }
        public bool    IsExplicit { get; set; } = false;

        #endregion
    }
}

