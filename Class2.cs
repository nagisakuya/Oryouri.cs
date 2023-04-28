using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum GuzaiState
{
	packed,
	unpacked,
	cutted,
}
class Guzai
{
	public string name { get; }
	public int price { get; }
	public double tempreture { get; set; }
	const double DEFAULT_TEMPRETURE = 10;
	GuzaiState state = GuzaiState.packed;
	public Guzai(string name, int price, double tempreture = DEFAULT_TEMPRETURE)
	{
		this.name = name;
		this.price = price;
		this.tempreture = tempreture;
	}
}

