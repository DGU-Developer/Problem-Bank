import java.io.IOException;

class ExerciseCh3_8 {
    public static void main(String[] args) throws IOException {
        char c;

        System.out.print("Enter a character = ");
        c = (char) System.in.read();
        if (c >= 'A' && c <= 'Z') c += ('a' - 'A');
        else if (c >= 'a' && c <= 'z') c += ('A' - 'a');
        System.out.println("Converted character = " + c);
    }
}