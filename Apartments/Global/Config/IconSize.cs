using System.Configuration;

namespace Apartments.Global.Config
{
    public class IconSizesConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("iconSizes")]
        public IconSizesCollection IconSizes
        {
            get
            {
                return this["iconSizes"] as IconSizesCollection;
            }
        }
    }

    public class IconSizesCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new IconSize();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((IconSize)element).Name;
        }
    }

    public class IconSize : ConfigurationElement         //  https://habr.com/ru/post/176069/
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return this["name"] as string;
            }
        }

        [ConfigurationProperty("width", IsRequired = false, DefaultValue = "48")]
        public int Width
        {
            get
            {
                return (int)this["width"];
            }
        }

        [ConfigurationProperty("height", IsRequired = false, DefaultValue = "48")]
        public int Height
        {
            get
            {
                return (int)this["height"];
            }
        }
    }
}