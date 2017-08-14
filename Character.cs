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
        /// 当前法力值
        public int mp;
        /// 最大法力值
        public int maxMp;
        /// 定义移动能力，包括移动方式与移动点数
        public class MoveAbility {
            public MoveType moveType;
            public int movePoint;
        }
        /// 操纵该角色需花费的点数
        public int commandCost;
        /// 角色持有的符卡
        public List<SpellCard> spellCardList;
        /// 当前该角色可进行的行动
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
