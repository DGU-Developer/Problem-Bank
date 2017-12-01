import java.util.*;
class Garbage {
    Garbage() {
        new Vector(2000);
    }
    protected void finalize() {
        System.out.println("finalizer() invoked !!!");
    }
}
public class ExerciseCh5_9_4 {
    static void alloc() {
        new Garbage();
    }
    public static void main(String[] args) {
        for (int i = 0; i < 100; i++)
            alloc();
    }
}