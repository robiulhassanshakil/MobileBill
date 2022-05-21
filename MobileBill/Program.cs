
var callstart = DateTime.Now;
var pt = TimeCal(callstart);

var callEnd = DateTime.Now;

var ot = TimeCal(callstart);


(int hour, int minute, int second, int mm, string tt) TimeCal(DateTime time)
{

    var hour = Convert.ToInt32(time.ToString("hh"));
    var minute = Convert.ToInt32(time.ToString("mm"));
    var second = Convert.ToInt32(time.ToString("ss"));
    var mm = Convert.ToInt32(time.ToString("fff"));
    var tt = time.ToString("tt");

    return (hour, minute, second, mm, tt);
}
if(pt.tt == "AM")
{
    pt.hour += 12;
}
if (pt.hour < 9 && pt.hour > 23)
{
    double totalST = 0;
    totalST = ((ot.second - pt.second)/20)*.30;
    double totalMT = 0;
    totalMT = (ot.minute - pt.minute)*.90;
    double totalHT = 0;
    totalHT = ((ot.hour - pt.hour)*60)*90;

    var total = (totalST + totalMT + totalHT) / 100;
    Console.WriteLine($"cost is : {total}");
}
else
{
    double totalST = 0;
    totalST = ((ot.second - pt.second) / 20) * .20;
    double totalMT = 0;
    totalMT = (ot.minute - pt.minute) * .60;
    double totalHT = 0;
    totalHT = ((ot.hour - pt.hour) * 60) * 60;

    var total = (totalST + totalMT + totalHT) / 100;
    Console.WriteLine($"cost is : {total}");
}
