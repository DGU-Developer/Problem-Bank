public class ExerciseCh4_8_1 {
    private static final int MAX = 100;
    private static Boolean isPrime(int n){
        for (int i = 2; i < n; i++) {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    public static void main(String[] args) {
        int i;
		for (i=2; i<=MAX; i++)
            if (isPrime(i))
                System.out.print(i + " ");
        System.out.println();
    }
}