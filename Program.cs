using System;
using System.Collections.Generic;


class Program
{
	static Osaihu osaihu = new(100);
	static Dictionary<string, Guzai> supermarket = loadSuper();
	static Dictionary<string, List<string>> recipe = loadRecipes();
	static Nabe Main(string[] args)
	{
		Console.WriteLine("お料理開始！");
		if (args.Length == 0) return null;
		if (recipe.TryGetValue(args[0], out var list))
		{
			var bag = shopping(list, osaihu);
			Nabe nabe = new();
			nabe.AddAll(bag);
			nabe.Nikomu(100);
			return nabe;
		}
		return null;
	}
	static List<Guzai> shopping(List<string> list, Osaihu osaihu)
	{
		List<Guzai> cart = new();
		foreach (var item in list)
		{
			if (supermarket.TryGetValue(item, out var guzai))
			{
				cart.Add(guzai);
			}
			else
			{
				cart.Add(null);
			}
		}
		List<Guzai> bag = new();
		int sum = 0;
		foreach (var item in cart)
		{
			sum += item.price;
			bag.Add(item);
		}
		osaihu.Withdraw(sum);
		return bag;
	}
}
