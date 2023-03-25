namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade = 'S';
            int health = 100;
            float attack = 36.5f;

            // console.writeLine( ) : 특정한 문자열을 출력하는 함수
            Console.WriteLine("grade 변수의 값 : " + grade);
            Console.WriteLine("Hello, World!");

            // console.write ( ) : 특정한 문자열을 출력하는 함수 ( 개행이 실행되지 않는다.)
            Console.Write("health 변수의 값 : " + health + " / ");
            Console.Write("attach 변수의 값 : " + attack);
            Console.WriteLine("Hello, World!");


            #region 변수의 이름 규칙
            // 1. 변수의 이름은 숫자로 시작할 수 없다.
            //ex) int 1count = 0;

            // 2. 변수의 이름으로 키워드를 사용할 수 없다
            // int int 

            // 3. 변수의 이름에 공백이 포함될 수 없다.
            //ex) int league of

            // 4. 변수의 이름으로 특수문자, "_"만 가능합니다.
            //ex) int count_down = 50;

            // 5. 변수의 이름은 대소문자를 구분합니다.

            //int value = 99;
            //int VALUE = 20; 다른 변수이다.

            // 6. 변수의 이름은 중복될 수 없다.
            #endregion

            #region 프로그램 실행 순서

            //true(참) 1 
            //false(거짓) 0
            bool condition = true;
            condition = false;

            int data = 100;
            data = 999;

            float pi = 3.141592f;
            pi = 5.5f;
            //이런식으로 이름가지고 값을 저장하면 됨
            //"변수"이기때문에 변할 수 있는 숫자임
            #endregion
        }
    }
} 