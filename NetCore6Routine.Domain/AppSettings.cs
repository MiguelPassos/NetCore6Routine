namespace NetCore6Routine.Domain
{
    public class AppSettings
    {
        public string? Enviroment { get; set; }

        public Parameters? DevParameters { get; set; }

        public Parameters? HmlParameters { get; set; }

        public Parameters? ProdParameters { get; set; }
    }

    public class Parameters
    {
        public string? ConnectionString { get; set; }

        public Configurations? Configurations { get; set; }

        public SecuritySettings? SecuritySettings { get; set; }
    }

    public class ConnectionStrings
    {
        public string? DevConnection { get; set; }

        public string? ProdConnection { get; set; }

        public string? HomolConnection { get; set; }
    }

    public class Configurations
    {
        public string? Configuration1 { get; set; }

        public string? Configuration2 { get; set; }

        public string? Configuration3 { get; set; }
    }

    public class SecuritySettings
    {
        public string? EncryptionKey { get; set; }
    }
}