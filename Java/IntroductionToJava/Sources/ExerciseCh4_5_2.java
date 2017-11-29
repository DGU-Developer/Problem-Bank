public class ExerciseCh4_5_2 {
    public static void main(String[] args) {
        int i, n;
        char[] s = {'3', '5', '6', '\0'};
        n = 0;
        
        i = 0;
        // while (s[i] >= '0' && s[i] <= '9') {
        //     n = 10 * n + (s[i] - '0');
        //     i++;
        // }
        do {
            n = 10 * n + (s[i] - '0');
            i++;
        } while (s[i] >= '0' && s[i] <= '9');
        // for (i = 0; s[i] >= '0' && s[i] <= '9'; i++)
        //     n = 10 * n + (s[i] - '0');
        System.out.println("N = " + n);
    }
}