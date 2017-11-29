class MyThread extends Thread{
    MyThread(String name){
        super(name);
    }
    public void run(){
        while(true){
            System.out.println(getName() + " is now running");
            try {
                sleep(5 * 1000);
            }catch(InterruptedException e){
                System.out.println("Interrupted is received");
                break;
            }
        }
    }
}
public class ExerciseCh11_7 {
    public static void main(String[] args){
        MyThread t1 = new MyThread("ThreadOne");
        MyThread t2 = new MyThread("ThreadTwo");
        t1.start();
        t2.start();
        try{
            Thread.sleep(30*1000);
        }catch(Exception e){}
        t1.interrupt();
        t2.interrupt();
    }
}
