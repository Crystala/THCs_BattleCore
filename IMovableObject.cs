/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/7/15
 * Time: 14:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BattleCore
{
    /// <summary>
    /// 可在棋盘上移动的物体的接口
    /// </summary>
    public interface IMovableObject
    {
        /// 该对象移动至指定位置时的行为
        void MoveTo(Position newPosition);
    }
    
    /// 移动方式的枚举，现有普通和传送两种
    public enum MoveType {
        Normal = 0,
        Warp = 1
    };
}
