public class ExerciseCh7_6 {
    public static void main(String[] args) {
        System.out.println("Input String is " + args[0]);
        System.out.println("Byte is         " + Byte.parseByte(args[0]));
        System.out.println("Short is        " + Short.parseShort(args[0]));
        System.out.println("Float is        " + new Float(args[0]).floatValue());
        System.out.println("Integer is      " + Integer.parseInt(args[0]));
        System.out.println("Long is         " + Long.parseLong(args[0]));
    }
}