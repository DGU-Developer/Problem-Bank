public class ExerciseCh3_9_3 {
    public static void main(String[] args) {
        System.out.println("number of bits = " + f(037));
    }
    public static int f(int n) {
        int m;
        for (m=0; n!=0; n>>=1)
            if ((n & 1) == 1) m++;
        return m;
    }
}