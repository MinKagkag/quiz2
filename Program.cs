class Program {
 static int Max2(int a, int b) {
 if (a > b) {
 return a; 
 } 
 return b;
 }
 static int Max4(int a, int b, int c, int d) {
 int result1 = Max2(a, b);
 int result2 = Max2(c, d);
 return Max2(result1, result2);
 }
}
