class ExerciseCh4_8_3 {
	static int readInt() throws java.io.IOException 
	{
		char ch;
		int n = 0;
		
		// skip non-digit characters
		while (!Character.isDigit(ch = (char)System.in.read()));
		
		do 
		{
			n = n * 10 + (ch - '0');
			ch = (char)System.in.read();
		} while (Character.isDigit(ch));
		return n;
	}
	
	public static void main(String[] args) throws java.io.IOException {

        int o, r;  // o: origin, r: reverse
        int i, j;

        System.out.print(" Enter a number : ");
        o = readInt();

        i = o; r = 0;
        while (i != 0) {
            j = i % 10;
            r = r * 10 + j;
            i = i / 10;
        }
        if (r == o) System.out.println(" *** palindrome ***");
           else System.out.println("*** non-palindrome ***");
	}
}