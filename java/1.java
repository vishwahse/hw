public class MyClass {
    public static void main(String args[]) {
      int n = Integer.parseInt(System.console().readLine());
      int triangle = 0;
      int fact = 1;
      for (int i = 1; i <= n; i++) {
          triangle += i;
          fact *= i;
      }
      System.out.println(triangle);
      System.out.println(fact);
    }
}
