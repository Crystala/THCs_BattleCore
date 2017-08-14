/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/8/14
 * Time: 12:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BattleCore
{
    /// <summary>
    /// Description of RandomManager.
    /// </summary>
    public sealed class RandomManager
    {
        private static RandomManager instance = new RandomManager();
        public Random rng;
        public Random RNG {
            get {
                return rng;
            }
        }
        private int seed;
        public int Seed {
            get { return seed;}
            set {
                seed = value;
                rng = new Random(seed);
            }
        }
        
        public static RandomManager Instance {
            get {
                return instance;
            }
        }
        
        private RandomManager()
        {
            seed = new Random().Next();
            rng = new Random(seed);
        }
    }
}
