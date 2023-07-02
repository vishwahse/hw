import java.util.Scanner;
public class Main
{
	public static void main(String[] args) {
	    Scanner in = new Scanner(System.in);
	    System.out.print("Введите первое число: ");
        int a = in.nextInt();
        System.out.print("Введите второе число: ");
        int b = in.nextInt();
        in.nextLine();
        System.out.print("Введите 1, если хотите сложить числа. Введите 2, если хотите вычесть второе число из первого. Введите 3, если хотите умножить числа. Введите 4, если хотите поделить первое число на второе. ");
        String n = in.nextLine();  
        switch (n) {
            case "1":
                System.out.println(a + b);
                break;
            case "2":
                System.out.println(a - b);
                break;
            case "3":
                System.out.println(a * b);
                break;
            case "4":
                System.out.println(a / b);
                break;
        }
	}
}
