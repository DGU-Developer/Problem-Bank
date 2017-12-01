public class ExerciseCh4_8_8 {
	public static void main(String[] args) throws java.io.IOException {
		int i,j;

		for (j=1; j<10; j++) {
			for (i=2; i<=5; i++)
				System.out.print("\t" + i + " * " + j + " = " + i*j + ",");
			System.out.println();
		}
		System.out.println();
		for (j=1; j<10; j++) {
			for (i=6; i<=9; i++) {
				System.out.print("\t" + i + " * " + j + " = " + i*j);
				if (i != 9 || j != 9) System.out.print(",");
			}
			System.out.println();
		}
		System.in.read();
	}
}