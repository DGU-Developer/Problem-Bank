class OuterClass {
	static class InnerClass {
		static String str;
		InnerClass(String s) {
			str = s;
		}
		static void print(String s) {
			str = s;
			System.out.println(s);
		}
		static void staticPrint() {
			print(str);
		}
	}
} // end of OuterClass
public class ExerciseCh5_10_3 {
	public static void main(String[] args) {
		String s = "ExerciseCh5_12";
		OuterClass.InnerClass p = new OuterClass.InnerClass(s);
		p.staticPrint();
		OuterClass.InnerClass.staticPrint();
	}
}
