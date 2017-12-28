class OuterClass {
    void print() {
        System.out.println("main() in Outer$Inner.class");
    }

    public static class ExerciseCh5_10_2 {
        public static void main(String[] args) {
            OuterClass p = new OuterClass();
            p.print();
        }
    }
}