using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU
{
    public class Functions
    {
		//Đếm số ngày làm việc trong tháng
		public static int demSoNgayLamViecTrongThang(int thang, int nam)
		{
			int dem = 0;
			DateTime f = new DateTime(nam, thang, 01);
			int x = f.Month + 1;
			while (f.Month < x)
			{
				dem = dem + 1;
				if (f.DayOfWeek == DayOfWeek.Sunday)
				{
					dem = dem - 1;
				}
				f = f.AddDays(1);
			}
			return dem;
		}
		public static int laySoNgayCuaThang(int thang, int nam)
		{
			return DateTime.DaysInMonth(nam, thang);
		}
	}
}
