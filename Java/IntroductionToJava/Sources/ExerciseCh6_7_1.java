class SuperClass {
    String greeting() { return "Good Bye"; }
    String name() { return "Oak"; }
}
class SubClass extends SuperClass {
    String greeting() { return "Hello"; }
    String name() { return "Java"; }
}
public class ExerciseCh6_7_1 {
    public static void main(String[] args) {
        SubClass s = new SubClass();
        System.out.println(s.greeting() + ", " + s.name());
    }
}