interface InterfaceA {
    int MAX_VALUE = 32767;
    int MIN_VALUE = -32768;
    int getMax();
    int getMin();
}
interface InterfaceB {
    int MAX_VALUE = 2147483647;
    int MIN_VALUE = -2147483648;
    int getMax();
    int getMin();
}
class ClassA implements InterfaceA, InterfaceB {
    public int getMax() {
        return InterfaceA.MAX_VALUE;
    }
    public int getMin() {
        return InterfaceA.MIN_VALUE;
    }
}
class ClassB extends ClassA {
    public int getMax() {
        return InterfaceB.MAX_VALUE;
    }
    public int getMin() {
        return InterfaceB.MIN_VALUE;
    }
}
public class ExerciseCh6_8 {
    public static void main(String[] args) {
        ClassA obj = new ClassB();
        System.out.println("Max = " + obj.getMax() + ", Min = " + obj.getMin());
    }
}