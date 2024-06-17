using H2_Clock.Interfaces;
using System;

namespace H2_Clock.Models
{
	internal class Clock
	{
		private DateTime Time { get; set; }

		internal Clock (DateTime time)
		{
			Time = time;
		}

		internal void AddSecondToClock()
		{
			Time = Time.AddSeconds(1);
		}

		public override string ToString()
		{
			return Time.ToString("HH:mm:ss");
		}
	}
}
