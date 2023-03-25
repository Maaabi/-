﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double firstValue, secondValue;
			string action;

			Console.WriteLine("Введите число 1:");
			firstValue = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите число 2:");
			secondValue = double.Parse(Console.ReadLine());

			Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");

			action = Console.ReadLine();

			switch(action)
			{
				case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;

			    case "-":
                    Console.WriteLine(firstValue - secondValue);
					break;

				case "*":
					Console.WriteLine(firstValue * secondValue);
					break;

			    case "/":
					if(secondValue == 0)
					{
                        Console.WriteLine(0);
                    }
					else
					{
                        Console.WriteLine(firstValue / secondValue);
                    }
					break;

				default: Console.WriteLine("Неизвестная команда!");
					break;
			}
			Console.ReadKey();
		}
	}
}
