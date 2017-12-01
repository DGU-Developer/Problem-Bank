public class ExerciseCh4_8_4 {
	public static void main(String[] args) {
		int i,j,k;
		int n1, n2;

		for (i=1; i<5; ++i)
			for (j=0; j<=9; ++j)
				for (k=0; k<=9; ++k) {
					n1 = i*100 + j*10 + k;            // number value
					n2 = i*i*i + j*j*j + k*k*k;       // triple power
					if (n1 == n2) System.out.println("Amstrong number = " + n1);
				}
	}	
}