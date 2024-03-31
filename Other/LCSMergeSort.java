import java.util.Arrays;

public class LCSMergeSort {    
    public static void main(String args[]) {
        int[] res = mergesort(new int[]{3, 2, 1, 4, 5, 6, 7, 8, 9, 10});
        for (int i: res) {
            System.out.println(i);
        }
    }
    public static int lcs(String a, String b) {
        int[][] dp = new int[a.length() + 1][b.length() + 1];
        for (int i = a.length() - 1; i > -1; i--) {
            for (int j = b.length() - 1; j > -1; j--) {
                if (a.charAt(i) == b.charAt(j)) {
                    dp[i][j] = dp[i + 1][j + 1] + 1;
                }
                else {
                    dp[i][j] = Math.max(dp[i + 1][j], dp[i][j + 1]);
                }
            }
        }
        return dp[0][0];
    }
    public static int[] mergesort(int[] arr){
        int n = arr.length;
        if (n < 2) {
            return arr;
        }
        return merge(mergesort(Arrays.copyOfRange(arr, 0, Math.floorDiv(n, 2))), mergesort(Arrays.copyOfRange(arr, Math.floorDiv(n, 2), n)));
    }
    public static int[] merge(int[] a, int[] b) {
        int[] c = new int[a.length + b.length];
        int i = 0;
        int j = 0;
        while (i < a.length && j < b.length) {
            if (a[i] < b[j]) {
                c[i + j] = a[i];
                i++;
            }
            else {
                c[i + j] = b[j];
                j++;
            }
        }
        while (i < a.length) {
            c[i + j] = a[i];
            i++;
        }
        while (j < b.length) {
            c[i + j] = b[j];
            j++;
        }
        return c;
    }
}