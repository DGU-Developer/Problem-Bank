class FinallyClause{
    public int methodA(){
        try{
            return 1;
        }
        catch(Exception e){ return 2; }
    }

    public int methodB(){
        try{
            return 3;
        }
        finally {
            return 4;
        }
    }
}
public class ExerciseCh9_6_2 {
    public static void main(String[] args){
        FinallyClause fc = new FinallyClause();
        System.out.println("methodA returns "+ fc.methodA());
        System.out.println("methondB returns "+ fc.methodB());
    }
}
