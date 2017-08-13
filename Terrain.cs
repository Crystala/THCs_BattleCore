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
    /// Description of Terrain.
    /// </summary>
    public class Terrain
    {
        #region Variables
        public enum TerrainType {
            
        }
        
        public TerrainType type;
        public string name;
        public bool stayable;
        public int movementCost;
        #endregion
        
        public Terrain()
        {
        }
        
        public void OnStepped(Bullet bullet)
        {
            
        }
        
        public void OnStepped(Character character)
        {
            
        }
    }
}
