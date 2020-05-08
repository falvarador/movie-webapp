namespace MovieWeb.WebApp.Model
{
    public struct MultiSelectorViewModel
    {
        public MultiSelectorViewModel(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
