/*
 * Created by SharpDevelop.
 * User: hasee
 * Date: 2017/7/6
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BattleCore
{
    
	class Program
	{
	    private List<int> l = new List<int>();
	    
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			//  Implement Functionality Here
			B b = new B();
			b.F();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		void F(List<Position> lp, Position pos)
		{
            l.Add(1);
			return;
		}
	}
	
	public class A
	{
	    public virtual void F()
	    {
	        return;
	    }
	}
	
	public class B: A
	{
        public override void F()
        {
            base.F();
            Console.WriteLine("Boom!");
        }
	}
}