/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/7/7
 * Time: 18:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BattleCore
{
	/// <summary>
	/// 描述棋盘上的一个格子，包括其位置和内容等信息
	/// </summary>
	public class Grid
	{
	    #region Variables
	    /// 所处棋盘
        public Board Board = null;
        /// 在棋盘上的位置
	    private readonly Position position = new Position(0, 0);
	    /// 该格子上的地形、人物与弹幕
	    public Terrain terrain;
	    public Character character;
	    public Bullet bullet;
	    #endregion
	    
	    // TODO: Grid constructor
	    #region Constructors
        public Grid() {
            
        }
        
        public Grid(Grid g) {
            
        }
	    #endregion
	    
	}
}
