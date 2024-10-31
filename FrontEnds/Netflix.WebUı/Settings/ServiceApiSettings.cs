namespace Netflix.WebUı.Settings
{
    public class ServiceApiSettings
    {
        public string OcelotUrl { get; set; }
        public ServiceApi Content { get; set; }
        public ServiceApi Comment { get; set; }
        public ServiceApi Genre { get; set; }
        public ServiceApi Movie { get; set; }
        public ServiceApi Language { get; set; }
    }
    public class ServiceApi
    {
        public string Path { get; set; }
    }
}
