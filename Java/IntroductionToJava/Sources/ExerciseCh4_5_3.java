public class ExerciseCh4_5_3 {
    public static void main(String[] args) {
        int i = 0;
        String s = new String("string");
        char c='r'; int sw=0;

        while (s.charAt(i) != '\0')
            if (c == s.charAt(i)) {
                sw=1;
                System.out.println("Position of " + c + " = " + (i++));
                break;
            } else i++;
        if (sw == 0)
            System.out.println("Not found");
    }
}