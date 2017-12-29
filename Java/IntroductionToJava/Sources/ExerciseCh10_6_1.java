import java.util.*;
class GClass<T>{
    private LinkedList<T> list;
    GClass(){
        list = new LinkedList();
    }
    public String getValue(){
        String str = new String();
        for(T e : list) str += e.toString();
        return str;
    }
    public void setValue(T ... args){
        for (T e : args) list.add(e);
    }
}
public class ExerciseCh10_6_1 {
    public static void main(String[] args){
        GClass<Integer> gInteger = new GClass<Integer>();
        gInteger.setValue(10, 20, 30);
        System.out.println(gInteger.getValue());
    }
}
