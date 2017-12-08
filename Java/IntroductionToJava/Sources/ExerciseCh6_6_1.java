class SuperClass {
    static int supNum = 100;
}
class SubClass extends SuperClass {
    static int subNum = 200;
}
public class ExerciseCh6_6_1 {
    public static void main(String[] args) {
        System.out.print(SuperClass.supNum + ", " + SubClass.supNum);
        System.out.println(", " + SubClass.subNum);
    }
}