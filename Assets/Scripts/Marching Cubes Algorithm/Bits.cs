using UnityEngine;

public static class Bits
{
    // TO CHECK IF BIT IS ON OR OFF
    public static int A = (int)Mathf.Pow(2, 0);
    public static int B = (int)Mathf.Pow(2, 1);
    public static int C = (int)Mathf.Pow(2, 2);
    public static int D = (int)Mathf.Pow(2, 3);
    public static int E = (int)Mathf.Pow(2, 4);
    public static int F = (int)Mathf.Pow(2, 5);
    public static int G = (int)Mathf.Pow(2, 6);
    public static int H = (int)Mathf.Pow(2, 7);

    public static string BinaryForm(int config)
    {
        string A = ((config & (1 << 0)) != 0) ? "A" : "-";
        string B = ((config & (1 << 1)) != 0) ? "B" : "-";
        string C = ((config & (1 << 2)) != 0) ? "C" : "-";
        string D = ((config & (1 << 3)) != 0) ? "D" : "-";
        string E = ((config & (1 << 4)) != 0) ? "E" : "-";
        string F = ((config & (1 << 5)) != 0) ? "F" : "-";
        string G = ((config & (1 << 6)) != 0) ? "G" : "-";
        string H = ((config & (1 << 7)) != 0) ? "H" : "-";

        return H + G + F + E + D + C + B + A;
    }
    public static bool isBitSet(int config, string letter)
    {
        bool ret = false;

        switch (letter)
        {
            case "A":
                ret = ((config & (1 << 0)) != 0);
                break;
            case "B":
                ret = ((config & (1 << 1)) != 0);
                break;
            case "C":
                ret = ((config & (1 << 2)) != 0);
                break;
            case "D":
                ret = ((config & (1 << 3)) != 0);
                break;
            case "E":
                ret = ((config & (1 << 4)) != 0);
                break;
            case "F":
                ret = ((config & (1 << 5)) != 0);
                break;
            case "G":
                ret = ((config & (1 << 6)) != 0);
                break;
            case "H":
                ret = ((config & (1 << 7)) != 0);
                break;
        }

        return ret;
    }
}