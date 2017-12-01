public class ExerciseCh5_10_1 {
    static void methodA(long l) {
        System.out.println("Argument type is long");
    }
    static void methodA(double d) {
        System.out.println("Argument type is double");
    }
    public static void main(String[] args) {
        methodA(1);
    }
}