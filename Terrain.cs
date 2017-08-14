/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/7/15
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BattleCore
{
    /// <summary>
    /// 地形的基类
    /// </summary>
    public class Terrain: SingleGridObject
    {
        #region Variables
        /// 地形种类的枚举
        public enum TerrainType {
            
        }
        
        /// 地形种类
        public TerrainType type;
        /// 是否可停留
        public bool stayable;
        /// 移动消耗
        public int movementCost;
        #endregion
        
        public Terrain()
        {
        }
        
        /// 弹幕停止于该地形时调用
        public virtual void OnStepped(Bullet bullet)
        {
            
        }
        
        /// 角色停止于该地形时调用
        public virtual void OnStepped(Character character)
        {
            
        }
        
        /// 弹幕经过该地形时调用
        public virtual void OnPassed(Bullet bullet)
        {
            
        }
        
        /// 角色经过该地形时调用
        public virtual void OnPassed(Character character)
        {
            
        }
    }
}
