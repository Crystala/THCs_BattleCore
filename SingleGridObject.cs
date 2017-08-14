/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/7/15
 * Time: 19:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BattleCore
{
    /// <summary>
    /// 在棋盘上只占用一个格子的对象的基类
    /// </summary>
    public class SingleGridObject: BoardObject
    {
        #region Variables
        /// 所占用的格子
        public Grid grid;
        #endregion
        
        public SingleGridObject()
        {
        }
    }
}
