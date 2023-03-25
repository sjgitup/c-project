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
        }
    }
}