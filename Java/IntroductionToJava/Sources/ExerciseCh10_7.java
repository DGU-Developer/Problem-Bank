class ISwap{
    public int x,y;
    public void swap(){
        int temp;
        temp=x;
        x=y;
        y=temp;
    }
}
class DSwap{
    public double x,y;
    public void swap(){
        double temp;
        temp=x;
        x=y;
        y=temp;
    }
}
public class ExerciseCh10_7 {
    public static void main(String[] args){
        ISwap i = new ISwap();
        i.x = 1; i.y=2;
        System.out.println("x : "+ i.x + "y : "+i.y);
        i.swap();
    }
}
