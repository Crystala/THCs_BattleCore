/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/8/14
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BattleCore
{
    /// <summary>
    /// Description of Dice.
    /// </summary>
    public class Dice
    {
        #region Variables
        private readonly List<DiceFace> faces;
        
        #endregion
            
        #region Definitions
        public enum DiceFace{
            empty = 0,
            attack = 1,
            defend = 2,
            bullet = 3,
            move = 4,
            element = 5,
            critical =6
        }
        #endregion
        
        public Dice()
        {
            faces = new List<DiceFace>();
        }
        
        public Dice(int faceCount)
        {
            faces = new List<DiceFace>();
            int faceVariety = Enum.GetValues(typeof(DiceFace)).Length;
            for (int i = 0; i < faceCount; i++)
            {
                faces.Add((DiceFace)RandomManager.Instance.RNG.Next(0, faceVariety));
            }
        }
        
        public Dice(List<DiceFace> faces)
        {
            this.faces = faces;
        }
        
        public Dice(List<int> faces)
        {
            this.faces = new List<DiceFace>();
            for (int i = 0; i < faces.Count; i++)
            {
                this.faces.Add((DiceFace)faces[i]);
            }
        }
        
        public DiceFace GetFace(int serial)
        {
            return serial < faces.Count ? faces[serial] : DiceFace.empty;
        }
        
        public bool SetFace(int serial, DiceFace value)
        {
            if (serial < faces.Count)
            {
                faces[serial] = value;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public DiceFace Throw()
        {
            return faces[RandomManager.Instance.RNG.Next(0, faces.Count)];
        }
        
        public override string ToString()
        {
            string ret = String.Empty;
            for (int i = 0; i < faces.Count; i++)
            {
                ret += faces[i].ToString() + ' ';
            }
            return ret;
        }
    }
}
