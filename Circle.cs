using System;
public class Circle
{
    double rad;
    double x,y;
    public Circle(double a,double b,double r){
        rad=r;
        x=a;
        y=b;
    }
    public double Area (){
        return Math.PI*rad*rad;
    }
    public double Perim (){
        return 2*Math.PI*rad;
    }
    
    
    public double Radius (){
        return rad;
    }

<<<<<<< HEAD
    
=======
    public void Center (){
        System.Console.WriteLine(x+" "+y);
    }
    public double Diameter (){
        return rad*2;
    }
<<<<<<< HEAD
>>>>>>> 045cdfd... Circle-Diameter
=======
    public void Resize (double r){
        rad=r;
    }

>>>>>>> 6049450... Circle-Resize
    public void Move (double a,double b){
        x=a;
        y=b;
    }

}