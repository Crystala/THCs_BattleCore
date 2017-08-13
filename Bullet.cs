/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/7/15
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BattleCore
{
    /// <summary>
    /// 弹幕对象的基类
    /// </summary>
    public class Bullet: SingleGridObject, IMovableObject
    {
        #region Variables
        /// 该弹幕的“速度”（移动时的行为模式）
        public BulletVelocity velocity;
        /// 该弹幕的伤害
        public int damage;
        /// 发出该弹幕的对象
        public BoardObject shooter;
        /// 该弹幕已存在的时间（单位暂定为回合数）
        public int existTime;
        /// 该弹幕的最大存在时间
        public int maxExistTime;
        #endregion
        
        public Bullet()
        {
        }
        
        public virtual void MoveTo(Position newPosition) {
            
        }
        
        public override void OnCollision() {
            
        }
        
        public override void OnDead() {
            
        }
        
        public override bool isDead() {
            return existTime > maxExistTime;
        }
        
        /// 该弹幕飞出棋盘边界时的行为
        public virtual void OnOutBoard() {
            
        }
        
        /// <summary>
        /// 用于描述弹幕的“速度”，具体包括弹幕的移动方式、方向和距离
        /// </summary>
        public class BulletVelocity {
            
            public MoveType moveType;
            public List<Position> velocity;
        }
    }
}
