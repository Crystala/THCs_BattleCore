using System;
using System.Collections.Generic;

namespace BattleCore
{
	/// <summary>
	/// 描述一个棋盘，包括其大小与位于其上的棋子与地形
	/// </summary>
    public class Board
    {
        ///记录棋盘大小，棋盘中有效位置的横纵坐标均小于该坐标的值。
        ///改变其值时，棋盘变大的部分将会变为NULL，变小的部分将会被删除（List体积变化）
        private readonly Position boardSize = new Position(0, 0);
        public Position BoardSize {
            get {
            	//直接返回
            	return boardSize;
            }
            set {
            	//检测非法设置
            	if (value.x < 0 || value.y < 0) {
            		return;
            	}
            	
            	//根据新的棋盘大小填充或删除grid的内容
            	if (grid == null) {
            		grid = new List<List<Grid> >();
            	}
            	
            	if (value.x > grid.Count) {
            		while (value.x > grid.Count) {
            			grid.Add(new List<Grid>());
            		}
            	}
            	if (value.x < grid.Count) {
            		grid.RemoveRange(value.x, grid.Count - value.x);
            	}
            	
            	for (int i = 0; i < grid.Count; i++) {
            		if (value.y > grid[i].Count) {
            			while (value.y > grid[i].Count) {
                			grid.Add(new List<Grid>());
                		}
	            	}
            		if (value.y < grid[i].Count) {
            			grid.RemoveRange(value.x, grid[i].Count - value.y);
	            	}
            	}
            	
            	//修改boardSize的值
            	boardSize.x = value.x;
            	boardSize.y = value.y;
            }
        }
        
        ///储存棋盘中的格子，其两级下标为格子对应的横纵坐标。
        ///因使用List记录，维护起来有点麻烦，故不开放直接访问的接口。
        ///空格子记为NULL
        private List<List<Grid>> grid;

        ///返回指定位置的格子信息，若位置非法则返回NULL
        public Grid GetGrid(Position pos) {
            if (pos.x >= boardSize.x || pos.y >= boardSize.y || pos.x < 0 || pos.y < 0 || pos.x > grid.Count || pos.y > grid[pos.x].Count) {
                return null;
            }

            return grid[pos.x][pos.y];
        }
        
        ///将指定坐标的格子的值设为参数grid
        ///返回值代表是否成功设置
        public bool SetGrid(Position pos, Grid grid) {
        	if (pos.x >= boardSize.x || pos.y >= boardSize.y || pos.x < 0 || pos.y < 0 || pos.x > this.grid.Count || pos.y > this.grid[pos.x].Count) {
                return false;
            }
        	
        	this.grid[pos.x][pos.y] = new Grid(grid);
        	return true;
        }


    }
}