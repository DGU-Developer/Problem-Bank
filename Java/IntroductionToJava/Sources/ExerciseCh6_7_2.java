class SuperClass {
    int value;
    SuperClass(int i) {
        value = i;
    }
    void output() {
        System.out.println("SuperClass : " + value);
    }
}
class SubClass extends SuperClass { 
    SubClass(int i) {
        super(i);
    }
    void output() {
        System.out.println("SubClass : " + value);
    }
}
public class ExerciseCh6_7_2 {
    public static void print(SuperClass obj) {
        obj.output();
    }
    public static void main(String[] args) {
        SuperClass obj1 = new SuperClass(1);
        SubClass obj2 = new SubClass(1);
        print(obj1);
        print(obj2);
    }
}