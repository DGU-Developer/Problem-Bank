import java.util.*;

public class ExerciseCh13_7_2 {
    public static void print(Collection<String> c)
    {
        for(String i : c)
            System.out.println(i);
    }
    public static void main(String[] args){
        TreeSet<String> strTs = new TreeSet<String>();
        String[] result = "Exercise ch13.7.2) is too simple.".split("\\s");
        for(String i : result)
            strTs.add(i);
        print(strTs);
    }
}
