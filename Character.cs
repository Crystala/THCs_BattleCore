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
    /// 玩家和AI可控制的对象的基类，称为角色
    /// </summary>
    public class Character: SingleGridObject, IMovableObject
    {
        #region Variables
        /// 当前生命值
        public int hp;
        /// 最大生命值
        public int maxHp;
        /// 当前残机
        public int life;
        /// 最大残机
        public int maxLife;
        /// 
        public int mp;
        public int maxMp;
        public class MoveAbility {
            public MoveType moveType;
            public int movePoint;
        }
        public int commandCost;
        public List<SpellCard> spellCardList;
        public Dictionary<string, bool> availableAction;
        #endregion
        
        public Character()
        {
            
        }
        
        public virtual void MoveTo(Position newPosition) {
            
        }
        
        public override void OnCollision() {
            
        }
        
        public override bool isDead()
        {
            return hp < 0;
        }
    }
}
