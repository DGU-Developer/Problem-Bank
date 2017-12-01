class Sort {
    void swap(int v[], int i, int j) {
        int temp;
        temp = v[i];
        v[i] = v[j];
        v[j] = temp;
    }
    public void Qsort(int a[], int left, int right) {
        int pe;
        int i, last;

        if (left >= right) return;
        pe = (left+right)/2;
        swap(a, left, pe);
        last = left;
        for (i=left+1; i<=right; i++)
            if (a[i] < a[left]) swap(a, ++last, i);
        swap(a, left, last);
        Qsort(a, left, last-1);
        Qsort(a, left+1, right);
    }
}

public class ExerciseCh5_10_4 {
    private static void printArray(int a[]) {
        System.out.println("Array : ");
        for (int n: a)
            System.out.print(n + "\t");
        System.out.println();
    }
    public static void main(String[] args) {
        int[] arr = { 10, 1, 2, 7, 5, 4, 9, 0 };
        Sort sort = new Sort();

        printArray(arr);
        sort.Qsort(arr, 0, arr.length-1);
        printArray(arr);
    }
}