using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("메뉴를 선택하시오.");
                Console.WriteLine("1.double, 2.float, 3.long, 4.int, 5.char, 6.종료");
                Console.Write("입력:");
                int input = int.Parse(Console.ReadLine());

                switch (input) // input 값 입력시 아래내용을 선택
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("double 값 2개를 입력하시오.");

                        Console.Write("입력 1: ");
                        double d1 = double.Parse(Console.ReadLine());
                        Console.Write("입력 2: ");
                        double d2 = double.Parse(Console.ReadLine());

                        Console.WriteLine();

                        while (true)
                        {
                            Console.Write("연산 종류를 입력하시오.(+,-,*,/,%):");
                            char c1 = char.Parse(Console.ReadLine());

                            double sum;
                            switch (c1)
                            {
                                case '+':
                                    sum = d1 + d2;
                                    break;
                                case '-':
                                    sum = d1 - d2;
                                    break;
                                case '*':
                                    sum = d1 * d2;
                                    break;
                                case '/':
                                    sum = d1 / d2;
                                    break;
                                case '%':
                                    sum = d1 % d2;
                                    break;
                                default:
                                    Console.WriteLine("잘못된 연산 기호입니다.\n");
                                    continue;
                            }


                            Console.Write("결과의 type을 선택하시오.");
                            int s1 = int.Parse(Console.ReadLine());

                            while (true)
                            {
                                switch (s1)
                                {
                                    case 1:
                                        Console.WriteLine("원 결과: Double: " + sum);
                                        Console.WriteLine("형 변환 결과: Double:" + (double)sum);
                                        Console.WriteLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("원 결과: Double: " + sum);
                                        Console.WriteLine("형 변환 결과: Float:" + (float)sum);
                                        Console.WriteLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("원 결과: Double: " + sum);
                                        Console.WriteLine("형 변환 결과: Long:" + (long)sum);
                                        Console.WriteLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("원 결과: Double: " + sum);
                                        Console.WriteLine("형 변환 결과: Int:" + (int)sum);
                                        Console.WriteLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("원 결과: Double: " + sum);
                                        Console.WriteLine("형 변환 결과: Char:" + (char)sum);
                                        Console.WriteLine();
                                        break;
                                    default:
                                        Console.WriteLine("잘못된 타입 입니다.\n");
                                        continue;
                                }
                                break; // s1 스위치
                            }
                            break; // c1 스위치
                        }
                        break;
                    // case 1번

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("float 값 2개를 입력하시오.");

                        Console.Write("입력 1: ");
                        float f1 = float.Parse(Console.ReadLine());
                        Console.Write("입력 2: ");
                        float f2 = float.Parse(Console.ReadLine());

                        Console.WriteLine();

                        while (true)
                        {
                            Console.Write("연산 종류를 입력하시오.(+,-,*,/,%):");
                            char c1 = char.Parse(Console.ReadLine());

                            float sum;
                            switch (c1)
                            {
                                case '+':
                                    sum = f1 + f2;
                                    break;
                                case '-':
                                    sum = f1 - f2;
                                    break;
                                case '*':
                                    sum = f1 * f2;
                                    break;
                                case '/':
                                    sum = f1 / f2;
                                    break;
                                case '%':
                                    sum = f1 % f2;
                                    break;
                                default:
                                    Console.WriteLine("잘못된 연산 기호입니다.\n");
                                    continue;
                            }


                            Console.Write("결과의 type을 선택하시오.");
                            int s1 = int.Parse(Console.ReadLine());

                            while (true)
                            {
                                switch (s1)
                                {
                                    case 1:
                                        Console.WriteLine("원 결과: Float: " + sum);
                                        Console.WriteLine("형 변환 결과: Double:" + (double)sum);
                                        Console.WriteLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("원 결과: Float: " + sum);
                                        Console.WriteLine("형 변환 결과: Float:" + (float)sum);
                                        Console.WriteLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("원 결과: Float: " + sum);
                                        Console.WriteLine("형 변환 결과: Long:" + (long)sum);
                                        Console.WriteLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("원 결과: Float: " + sum);
                                        Console.WriteLine("형 변환 결과: Int:" + (int)sum);
                                        Console.WriteLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("원 결과: Float: " + sum);
                                        Console.WriteLine("형 변환 결과: Char:" + (char)sum);
                                        Console.WriteLine();
                                        break;
                                    default:
                                        Console.WriteLine("잘못된 타입 입니다.\n");
                                        continue;
                                }
                                break; // s1 스위치
                            }
                            break; // c1 스위치
                        }
                        break;
                    // case 2번

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("long 값 2개를 입력하시오.");

                        Console.Write("입력 1: ");
                        long l1 = long.Parse(Console.ReadLine());
                        Console.Write("입력 2: ");
                        long l2 = long.Parse(Console.ReadLine());

                        Console.WriteLine();

                        while (true)
                        {
                            Console.Write("연산 종류를 입력하시오.(+,-,*,/,%):");
                            char c1 = char.Parse(Console.ReadLine());

                            long sum;
                            switch (c1)
                            {
                                case '+':
                                    sum = l1 + l2;
                                    break;
                                case '-':
                                    sum = l1 - l2;
                                    break;
                                case '*':
                                    sum = l1 * l2;
                                    break;
                                case '/':
                                    sum = l1 / l2;
                                    break;
                                case '%':
                                    sum = l1 % l2;
                                    break;
                                default:
                                    Console.WriteLine("잘못된 연산 기호입니다.\n");
                                    continue;
                            }


                            Console.Write("결과의 type을 선택하시오.");
                            int s1 = int.Parse(Console.ReadLine());

                            while (true)
                            {
                                switch (s1)
                                {
                                    case 1:
                                        Console.WriteLine("원 결과: Long: " + sum);
                                        Console.WriteLine("형 변환 결과: Double:" + (double)sum);
                                        Console.WriteLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("원 결과: Long: " + sum);
                                        Console.WriteLine("형 변환 결과: Float:" + (float)sum);
                                        Console.WriteLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("원 결과: Long: " + sum);
                                        Console.WriteLine("형 변환 결과: Long:" + (long)sum);
                                        Console.WriteLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("원 결과: Long: " + sum);
                                        Console.WriteLine("형 변환 결과: Int:" + (int)sum);
                                        Console.WriteLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("원 결과: Long: " + sum);
                                        Console.WriteLine("형 변환 결과: Char:" + (char)sum);
                                        Console.WriteLine();
                                        break;
                                    default:
                                        Console.WriteLine("잘못된 타입 입니다.\n");
                                        continue;
                                }
                                break; // s1 스위치
                            }
                            break; // c1 스위치
                        }
                        break;
                    // case 3번

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Int 값 2개를 입력하시오.");

                        Console.Write("입력 1: ");
                        int i1 = int.Parse(Console.ReadLine());
                        Console.Write("입력 2: ");
                        int i2 = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        while (true)
                        {
                            Console.Write("연산 종류를 입력하시오.(+,-,*,/,%):");
                            char c1 = char.Parse(Console.ReadLine());

                            long sum;
                            switch (c1)
                            {
                                case '+':
                                    sum = i1 + i2;
                                    break;
                                case '-':
                                    sum = i1 - i2;
                                    break;
                                case '*':
                                    sum = i1 * i2;
                                    break;
                                case '/':
                                    sum = i1 / i2;
                                    break;
                                case '%':
                                    sum = i1 % i2;
                                    break;
                                default:
                                    Console.WriteLine("잘못된 연산 기호입니다.\n");
                                    continue;
                            }


                            Console.Write("결과의 type을 선택하시오.");
                            int s1 = int.Parse(Console.ReadLine());

                            while (true)
                            {
                                switch (s1)
                                {
                                    case 1:
                                        Console.WriteLine("원 결과: Int: " + sum);
                                        Console.WriteLine("형 변환 결과: Double:" + (double)sum);
                                        Console.WriteLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("원 결과: Int: " + sum);
                                        Console.WriteLine("형 변환 결과: Float:" + (float)sum);
                                        Console.WriteLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("원 결과: Int: " + sum);
                                        Console.WriteLine("형 변환 결과: Long:" + (long)sum);
                                        Console.WriteLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("원 결과: Int: " + sum);
                                        Console.WriteLine("형 변환 결과: Int:" + (int)sum);
                                        Console.WriteLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("원 결과: Int: " + sum);
                                        Console.WriteLine("형 변환 결과: Char:" + (char)sum);
                                        Console.WriteLine();
                                        break;
                                    default:
                                        Console.WriteLine("잘못된 타입 입니다.\n");
                                        continue;
                                }
                                break; // s1 스위치
                            }
                            break; // c1 스위치
                        }
                        break;
                    // case 4번

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Int 값 2개를 입력하시오.");

                        Console.Write("입력 1: ");
                        char ch1 = char.Parse(Console.ReadLine());
                        Console.Write("입력 2: ");
                        char ch2 = char.Parse(Console.ReadLine());

                        Console.WriteLine();

                        while (true)
                        {
                            Console.Write("연산 종류를 입력하시오.(+,-,*,/,%):");
                            char c1 = char.Parse(Console.ReadLine());

                            long sum;
                            switch (c1)
                            {
                                case '+':
                                    sum = ch1 + ch2;
                                    break;
                                case '-':
                                    sum = ch1 - ch2;
                                    break;
                                case '*':
                                    sum = ch1 * ch2;
                                    break;
                                case '/':
                                    sum = ch1 / ch2;
                                    break;
                                case '%':
                                    sum = ch1 % ch2;
                                    break;
                                default:
                                    Console.WriteLine("잘못된 연산 기호입니다.\n");
                                    continue;
                            }


                            Console.Write("결과의 type을 선택하시오.");
                            int s1 = int.Parse(Console.ReadLine());

                            while (true)
                            {
                                switch (s1)
                                {
                                    case 1:
                                        Console.WriteLine("원 결과: Char: " + sum);
                                        Console.WriteLine("형 변환 결과: Double:" + (double)sum);
                                        Console.WriteLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("원 결과: Char: " + sum);
                                        Console.WriteLine("형 변환 결과: Float:" + (float)sum);
                                        Console.WriteLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("원 결과: Char: " + sum);
                                        Console.WriteLine("형 변환 결과: Long:" + (long)sum);
                                        Console.WriteLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("원 결과: Char: " + sum);
                                        Console.WriteLine("형 변환 결과: Int:" + (int)sum);
                                        Console.WriteLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("원 결과: Char: " + sum);
                                        Console.WriteLine("형 변환 결과: Char:" + (char)sum);
                                        Console.WriteLine();
                                        break;
                                    default:
                                        Console.WriteLine("잘못된 타입 입니다.\n");
                                        continue;
                                }
                                break; // s1 스위치
                            }
                            break; // c1 스위치
                        }
                        break;
                    // case 5번

                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("프로그램을 종료합니다.\n");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("잘못된 메뉴 번호입니다.\n");
                        continue;
                }

                if (input == 6) // case 6을 선택 시 case 6에서만 반복문 탈출
                    break;
            }
        }
    }
}