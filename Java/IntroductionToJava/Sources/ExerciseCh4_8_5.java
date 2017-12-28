public class ExerciseCh4_8_5 {
    // greatest common divisor
    private static int gcd(int n, int m) {
        int result = 1;
        for (int i = 1; i <= n && i <= m; i++) {
            if ((n % i == 0) && (m % i == 0))
                result = i;
        }
        return result;
    }

    // least common multiple
    private static int lcm(int n, int m) {
        int i = n >= m ? m : n;
        while (true){
            if (i % n == 0 && i % m == 0)
                return i;
            i++;
        }
    }

    public static void main(String[] args) {
        int n, m;
        System.out.print(" Enter a number 1 : ");
        n = Integer.parseInt(System.console().readLine());
        System.out.print(" Enter a number 2 : ");
        m = Integer.parseInt(System.console().readLine());

        System.out.println("GCD : " + gcd(n, m));
        System.out.println("LCM : " + lcm(n, m));
    }
}