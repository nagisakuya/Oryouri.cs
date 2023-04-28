using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Nabe
{
	List<Guzai> contents = new();
	public void Add(Guzai guzai)
	{
		contents.Add(guzai);
	}
	public void AddAll(List<Guzai> guzais)
	{
		contents = guzais;
	}
	public void Nikomu(double min)
	{
		foreach (var item in contents)
		{
			item.tempreture += min * 1.5;
		}
	}
}

