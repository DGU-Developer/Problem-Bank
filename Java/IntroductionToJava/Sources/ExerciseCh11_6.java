class SimpleThread extends Thread{
    public SimpleThread(String name){
        super(name);
    }

    public void run(){
        for (int i=0;i<3;i++){
            System.out.println(i + " " + getName());
            try{
                sleep((int)(Math.random() * 1000));
            }catch(InterruptedException e){}
        }
        System.out.println("DONE! " + getName());
    }
}
public class ExerciseCh11_6 {
    public static void main(String[] args){
        new SimpleThread("Seoul").start();
        new SimpleThread("Pusan").start();
    }
}
