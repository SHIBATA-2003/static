using System;

public class ma
{
    static void Main()
    {
        float value1=0,value2=0,value3=0;
        Console.WriteLine("直方体");
       value1= InputFloat("幅を入力");
       value2= InputFloat("高さを入力");
       value3= InputFloat("奥行きを入力");
        Console.WriteLine("直方体の表面積 = " + Box.GetSurfaceB(value1,value2,value3) + "体積=" + Box.GetVolumeB(value1,value2,value3));

        Console.WriteLine("円柱");
       value1= InputFloat("底面の半径を入力");
       value2= InputFloat("高さを入力");
        Console.WriteLine("円柱の表面積 = " + Cylinder.GetSurfaceC(value1,value2) + " 体積 = " + Cylinder.GetVolumeC(value1,value2));

        Console.WriteLine("球");
       value1= InputFloat("半径を入力");
        Console.WriteLine("球の表面積 = " + Sphere.GetSurfaceS(value1) + " 体積 = " + Sphere.GetVolumeS(value1));

        Console.WriteLine("三角柱");
        value1 = InputFloat("高さを入力");
        value2 = InputFloat("三角形の高さを入力");
        value3= InputFloat("底辺の長さを入力");
        Console.WriteLine("三角柱の表面積 = " + TriangularPrism.GetSurfaceT(value1,value2,value3) + " 体積 = " + TriangularPrism.GetVolumeT(value1,value2,value3));
    }
    static float InputFloat(string su)
    {
        float input;
        while (true)
        {
            Console.WriteLine(su);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
    static class Box
    {
        public static float GetVolumeB(float width, float height, float depth)
        {
            return width * height * depth;
        }
        public static float GetSurfaceB(float width, float height, float depth)
        {
            return (width * height + height * depth + depth * width) * 2;
        }
    }
    static class Cylinder
    {
        public static float GetVolumeC(float radius,float height)
        {
            return radius * radius * MathF.PI * height;
        }
        public static float GetSurfaceC(float radius,float height)
        {
            return 2 * MathF.PI * radius * radius + 2 * MathF.PI * radius * height;
        }
    }
    static class Sphere
    {
        
        public static float GetSurfaceS(float height)
        {
            return 4 * height * height * MathF.PI;
        }
        public static float GetVolumeS(float height)
        {
            return 4 * MathF.PI * height * height * height / 3;
        }
    }
    static class TriangularPrism
    {
        public static float GetVolumeT(float dept,float side,float height)
        {
            return (dept * side / 2) * height;
        }
        public static float GetSurfaceT(float side,float dept,float height)
        {
            float si = (side * side);
            float de = (dept * dept);
            return (float)((dept * side) + height * ((Math.Sqrt(si + de)) + dept + side));
        }
    }
   

}
