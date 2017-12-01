import java.io.IOException;

public class ExerciseCh4_7_1 {
    static int readInt() throws IOException {
        char ch;
        int n=0;

        // skip non-digit characters
        while (!Character.isDigit(ch = (char)System.in.read()));

        do {
            n = n*10 + (ch - '0');
            ch = (char) System.in.read();
        } while (Character.isDigit(ch));
        return n;
    }
    public static void main(String[] args) throws java.io.IOException {
        int i;

        System.out.print("*** input data : ");
        i = readInt();
        if ((i%4==0 && i%100!=0) || i%400==0)
            System.out.println("leap");
        else
            System.out.println("non-leap");
    }
}