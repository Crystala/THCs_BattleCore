/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/8/12
 * Time: 14:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BattleCore
{
    /// <summary>
    /// Description of ISaveLoad.
    /// </summary>
    public interface ISaveLoad
    {
        string Save();
        string Load();
    }
}
