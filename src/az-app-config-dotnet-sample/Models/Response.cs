namespace unleash_dotnet_sample.Models
{
    public class Response
    {
        public string FeatureToggle { get; set; }
        public bool Value { get; set; }

        public Response(string featureToggle, bool value)
        {
            FeatureToggle = featureToggle;
            Value = value;
        }
    }
}