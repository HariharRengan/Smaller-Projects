#include <iostream>
#include <algorithm>

using namespace std;

int lcs(string a, string b) {
    int n = a.length();
    int m = b.length();
    int dp[n + 1][m + 1];
    for (int k = 0; k < n + 1; k++) {
        for (int l = 0; l < m + 1; l++) {
            dp[k][l] = 0;
        }
    }
    for (int i = n - 1; i > -1; i--) {
        for (int j = m - 1; j > -1; j--) {
            if (a[i] == b[j]) {
                dp[i][j] = 1 + dp[i + 1][j + 1];
            }
            else {
                dp[i][j] = max(dp[i + 1][j], dp[i][j + 1]);
            }
        }
    }
    return dp[0][0];
}
int main() {
    // Test LCS function
    cout << lcs("abcde", "ace") << endl;
	return 1;
}