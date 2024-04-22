using UnityEngine;

public static class Points
{
    /*      E ------ F
     *      |        |
     *      | A ------- B
     *      | |      |  |
     *      G | ---- H  |
     *        |         |
     *        C ------- D
     */

    // CORNERS
    public static GridPoint A = null;
    public static GridPoint B = null;
    public static GridPoint C = null;
    public static GridPoint D = null;
    public static GridPoint E = null;
    public static GridPoint F = null;
    public static GridPoint G = null;
    public static GridPoint H = null;

    // HALF-WAY POINTS
    public static Vector3 ab
    {
        get { return C.Position + new Vector3(0.5f, 1f, 0f); }
    }
    public static Vector3 ba
    {
        get { return C.Position + new Vector3(0.5f, 1f, 0f); }
    }
    public static Vector3 bd
    {
        get { return C.Position + new Vector3(1f, 0.5f, 0f); }
    }
    public static Vector3 db
    {
        get { return C.Position + new Vector3(1f, 0.5f, 0f); }
    }
    public static Vector3 dc
    {
        get { return C.Position + new Vector3(0.5f, 0f, 0f); }
    }
    public static Vector3 cd
    {
        get { return C.Position + new Vector3(0.5f, 0f, 0f); }
    }
    public static Vector3 ca
    {
        get { return C.Position + new Vector3(0f, 0.5f, 0f); }
    }
    public static Vector3 ac
    {
        get { return C.Position + new Vector3(0f, 0.5f, 0f); }
    }

    public static Vector3 ef
    {
        get { return C.Position + new Vector3(0.5f, 1f, 1f); }
    }
    public static Vector3 fe
    {
        get { return C.Position + new Vector3(0.5f, 1f, 1f); }
    }
    public static Vector3 fh
    {
        get { return C.Position + new Vector3(1f, 0.5f, 1f); }
    }
    public static Vector3 hf
    {
        get { return C.Position + new Vector3(1f, 0.5f, 1f); }
    }
    public static Vector3 hg
    {
        get { return C.Position + new Vector3(0.5f, 0f, 1f); }
    }
    public static Vector3 gh
    {
        get { return C.Position + new Vector3(0.5f, 0f, 1f); }
    }
    public static Vector3 ge
    {
        get { return C.Position + new Vector3(0f, 0.5f, 1f); }
    }
    public static Vector3 eg
    {
        get { return C.Position + new Vector3(0f, 0.5f, 1f); }
    }

    public static Vector3 fb
    {
        get { return C.Position + new Vector3(1f, 1f, 0.5f); }
    }
    public static Vector3 bf
    {
        get { return C.Position + new Vector3(1f, 1f, 0.5f); }
    }
    public static Vector3 ae
    {
        get { return C.Position + new Vector3(0f, 1f, 0.5f); }
    }
    public static Vector3 ea
    {
        get { return C.Position + new Vector3(0f, 1f, 0.5f); }
    }
    public static Vector3 hd
    {
        get { return C.Position + new Vector3(1f, 0f, 0.5f); }
    }
    public static Vector3 dh
    {
        get { return C.Position + new Vector3(1f, 0f, 0.5f); }
    }
    public static Vector3 cg
    {
        get { return C.Position + new Vector3(0f, 0f, 0.5f); }
    }
    public static Vector3 gc
    {
        get { return C.Position + new Vector3(0f, 0f, 0.5f); }
    }
}