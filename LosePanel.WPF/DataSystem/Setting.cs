using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosePanel.WPF.DataSystem
{
    /// <summary>
    /// 单项设置
    /// </summary>
    public class Setting
    {
        public enum SettingType
        {
            String,
            Integer,
            Double,
            Bool
        }

        /// <summary>
        /// 本设置的类型
        /// </summary>
        public SettingType Type { get; private set; }

        /// <summary>
        /// 本设置的名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 本设置的描述
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 设置值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 实例化一个设置对象
        /// </summary>
        /// <param name="name">设置项名称</param>
        /// <param name="type">设置项类型</param>
        /// <param name="description">设置项描述</param>
        public Setting(string name, SettingType type, string description)
        {
            Name = name;
            Type = type;
            Description = description;
        }
    }
}
