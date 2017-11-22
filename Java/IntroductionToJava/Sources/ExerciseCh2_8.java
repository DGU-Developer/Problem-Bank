public class ExerciseCh2_8 {
	static void magic(int n) {
		int[][] matrix = new int[n][n];
		int nsqr = n * n;
		int i=0, j=n/2;     // start position

		for (int k=1; k<=nsqr; ++k) {
			matrix[i--][j++] = k;
			if (k%n == 0) { i += 2; --j; }
			else if (i<0) i += n;
			else if (j==n) j -= n;
		}
		System.out.println(" ***** magic square of order " + n);
		for (i=0; i<n; ++i) {
			for (j=0; j<n; ++j)
				System.out.print(" " + matrix[i][j]);
			System.out.println();
		}

	} // end of magic
	public static void main(String[] args) throws java.io.IOException {
		int n;

		System.out.print("Enter an odd number from 3 to 9: ");
		n = System.in.read() - '0';
		magic(n);
	} // end of main
}

