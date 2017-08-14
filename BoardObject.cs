/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/7/15
 * Time: 19:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BattleCore
{
    /// <summary>
    /// 所有可以出现在棋盘上的对象(角色与地形)的基类，定义了一些基本的属性和方法
    /// </summary>
    public class BoardObject
    {
//        #region value keys
//        public const string ID_INT_KEY = "id";
//        public const string FACTION_INT_KEY = "faction";
//        public const string NAME_STRING_KEY = "name";
//        #endregion
        
        #region Variables
        private Position pos = new Position(0, 0);
        /// 该对象的序号，理论上不同对象的序号应互不相同。由于序号本身还没有派上用场，所以什么都没写。
        public int id;
        /// 该对象所属的势力，-1代表无所属
        public int faction;
        /// 该对象的名称，用于游戏中的显示，与逻辑基本无关
        public string name;
        /// 描述（元素）属性的枚举，属性0~6为金木水火土光暗
        public enum ElementType {
            Metal = 0,
            Wood = 1,
            Water = 2,
            Fire = 3,
            Earth = 4,
            Light = 5,
            Dark = 6
        }
        /// 对象的（元素）属性
        public ElementType elementType;
        #endregion
        
        public BoardObject()
        {
        }
        
        /// 检测到碰撞时的行为，应由游戏管理器在碰撞时调用
        public virtual void OnCollision() {
            
        }
        
        /// 进入棋盘时的行为，应由游戏管理器在入场时调用
        public virtual void OnEntry() {
            
        }
        
        /// 仆街时的行为，应由游戏管理器在仆街时调用
        public virtual void OnDead() {
            
        }

        /// 检测是否扑街
        public virtual bool isDead() {
            return false;
        }
    }
}
