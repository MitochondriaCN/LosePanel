using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LosePanel.DataSystem
{
    public class Option<T>
    {
        /// <summary>
        /// 该设置项的名称（唯一标识符）。
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 该设置项的友好名称。
        /// </summary>
        public string FriendlyName { get; private set; }

        /// <summary>
        /// 该设置项的描述。
        /// </summary>
        public string Description { get; private set; }

        private T value;
        /// <summary>
        /// 该设置项的值。
        /// </summary>
        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;

                XDocument xd = XDocument.Load("settings.ini");
                XElement root = xd.Element("LosePanelSettings");
                XElement current = root.Element(Name);
                current.Value = value.ToString();
                xd.Save("settings.ini");
            }
        }

        public Option(string name, string friendlyName, string description, T value)
        {
            Name = name;
            FriendlyName = friendlyName;
            Description = description;
            this.value = value;
        }


    }
}
