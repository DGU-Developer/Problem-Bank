public class ExerciseCh4_8_2 {
	public static final int MAX = 500;
	public static void main(String[] args) {
		int i, j;
		int s;
		for (i=1; i<=MAX; i++) {
			s = 0;
			for (j=1; j<=i/2; j++)
				if (i%j == 0) s += j;
			if (i==s)
				System.out.println("*** perfect number : " + s);
		}
	}
}
