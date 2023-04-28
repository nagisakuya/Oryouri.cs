using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Osaihu
{
	int money;
	public Osaihu(int m)
	{
		money = m;
	}
	public void Add(int m)
	{
		money += m;
	}
	public void Withdraw(int m)
	{
		money -= m;
	}
}

