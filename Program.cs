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
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Dice d = new Dice(6);
			Console.WriteLine(d);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}