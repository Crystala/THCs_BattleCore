using System;

namespace BattleCore
{
	/// <summary>
	/// 简单的二维坐标（也可作为二维向量使用），横纵坐标均为整数
	/// 不使用c#自带的Vector2是要限制坐标为整数以避免一些可能的问题
	/// </summary>
    public class Position
    {
        #region Variables
        /// 两个坐标的封装
        public int x {
            get;
            set;
        }
        public int y {
            get;
            set;
        }
        #endregion

        ///构造函数
        public Position(int x, int y) {
            this.x = x;
            this.y = y;
        }
        
        ///ToString，调试用
		public override string ToString() {
			return string.Format("[Position X={0}, Y={1}]", x, y);
		}

		///重载运算符和Equals，方便判断坐标是否相同
        #region Equals and GetHashCode implementation
        public override bool Equals(object obj) {
            Position other = obj as Position;
                if (other == null)
                    return false;
                        return this.x == other.x && this.y == other.y;
        }

        public override int GetHashCode() {
            int hashCode = 0;
            unchecked {
                hashCode += 1000000007 * x.GetHashCode();
                hashCode += 1000000009 * y.GetHashCode();
            }
            return hashCode;
        }

        public static bool operator ==(Position lhs, Position rhs) {
            if (ReferenceEquals(lhs, rhs))
                return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
                return false;
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Position lhs, Position rhs) {
            return !(lhs == rhs);
        }
        #endregion
        
        /// 重载另一些用于运算的运算符
        /// 包括加减乘，除法因可能调整舍入方式不统一重载
        /// 包括大小比较，仅当全部坐标均大于/小于另一者时才会返回真
        #region Calculation Override
        public static Position operator +(Position lhs, Position rhs) {
            if (ReferenceEquals(lhs, null)) {
                if (ReferenceEquals(rhs,null)) {
                    return null;
                }
                else {
                    return rhs.MemberwiseClone() as Position;
                }
            }
            else {
                if (ReferenceEquals(rhs,null)) {
                    return lhs.MemberwiseClone() as Position;
                }
                else {
                    return new Position(lhs.x + rhs.x, lhs.y + rhs.y);
                }
            }
        }
        
        public static Position operator -(Position lhs, Position rhs) {
            if (ReferenceEquals(lhs, null)) {
                if (ReferenceEquals(rhs,null)) {
                    return null;
                }
                else {
                    return rhs.MemberwiseClone() as Position;
                }
            }
            else {
                if (ReferenceEquals(rhs,null)) {
                    return lhs.MemberwiseClone() as Position;
                }
                else {
                    return new Position(lhs.x - rhs.x, lhs.y - rhs.y);
                }
            }
        }
        
        public static Position operator *(Position pos, int i) {
            if (ReferenceEquals(pos, null)) {
                return null;
            }
            
            return new Position(pos.x * i, pos.y * i);
        }
        
        public static Position operator *(int i, Position pos) {
            if (ReferenceEquals(pos, null)) {
                return null;
            }
            
            return new Position(pos.x * i, pos.y * i);
        }
        
        public static bool operator >(Position lhs, Position rhs) {
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) {
                return false;
            }
            
            return (lhs.x > rhs.x && lhs.y > rhs.y);
        }
        
        public static bool operator <(Position lhs, Position rhs) {
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) {
                return false;
            }
            
            return (lhs.x < rhs.x && lhs.y < rhs.y);
        }
        
        public static bool operator >=(Position lhs, Position rhs) {
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) {
                return false;
            }
            
            return (lhs.x >= rhs.x && lhs.y >= rhs.y);
        }
        
        public static bool operator <=(Position lhs, Position rhs) {
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) {
                return false;
            }
            
            return (lhs.x <= rhs.x && lhs.y <= rhs.y);
        }
        #endregion
    }
}