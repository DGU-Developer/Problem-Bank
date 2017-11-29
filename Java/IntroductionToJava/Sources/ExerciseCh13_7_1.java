public class ExerciseCh13_7_1 {
    public static void main(String[] args){
        try{
            Class e = Class.forName("java.lang.RuntimeException");
            Class sc = e.getSuperclass();
            System.out.println("Class     Name = " + e.getName());
            System.out.println("Superclass Name  =" + sc.getName());
        }catch(ClassNotFoundException e){
            System.err.println(e);
        }
    }
}
