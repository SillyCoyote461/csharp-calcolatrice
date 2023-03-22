using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class CalcoliHelper
{
    //sum
    public static double GetSum(double x, double y) => x + y;
    public static int GetSum(int x, int y) => x + y;

    //sub
    public static double GetSub(double x, double y) => x - y;
    public static int GetSub(int x, int y) => x - y;

    //multiplication
    public static double GetForTimes(double x, double y) => x * y;
    public static int GetForTimes(int x, int y) => x * y;

    //absolute
    public static double GetAbsolute(double x)
    {
        if (x < 0) return x * (-1);
        return x;
    }
    public static int GetAbsolute(int x)
    {
        if (x < 0) return x * (-1);
        return x;
    }

    //min
    public static double GetMin(double x, double y)
    {
        if (x<y) return x;
        return y;
    }
    public static int GetMin(int x, int y)
    {
        if (x < y) return x;
        return y;
    }

    //max
    public static double GetMax(double x, double y)
    {
        if (x > y) return x;
        return y;
    }
    public static int GetMax(int x, int y)
    {
        if (x > y) return x;
        return y;
    }

    //ringraziamo il polimorfismo per cotanta flessibilitá

    //nth power
    public static double GetPow(double x, double y)
    {
        if(x is 0 && y is 0) return 0;

    }
}

