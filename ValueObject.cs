/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/8/12
 * Time: 14:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BattleCore
{
    /// <summary>
    /// 一个能较为灵活地在运行时增减变量的基类，已完成
    /// 现在尚未决定是否使用，暂时搁置
    /// </summary>
    public class ValueObject
    {
        #region variables        
        private readonly Dictionary<string, int> intValues = new Dictionary<string, int>();
        private readonly Dictionary<string, float> floatValues = new Dictionary<string, float>();
        private readonly Dictionary<string, string> stringValues = new Dictionary<string, string>();
        #endregion
        
        public int GetIntValue(string name, int defaultValue = int.MinValue)
        {
            return intValues.ContainsKey(name) ? intValues[name] : defaultValue;
        }
        
        public float GetFloatValue(string name, float defaultValue = float.NaN)
        {
            return floatValues.ContainsKey(name) ? floatValues[name] : defaultValue;
        }
        
        public string GetStringValue(string name, string defaultValue = "")
        {
            return stringValues.ContainsKey(name) ? stringValues[name] : defaultValue;
        }
        
        public void SetIntValue(string name, int value)
        {
            intValues[name] = value;
        }
        
        public void SetFloatValue(string name, float value)
        {
            floatValues[name] = value;
        }
        
        public void SetStringValue(string name, string value)
        {
            stringValues[name] = value;
        }
    }
}
