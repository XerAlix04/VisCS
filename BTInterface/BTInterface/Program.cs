using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car car = new Car(0);
            car.Drive();
            System.Console.WriteLine("Xin nhap luong xang:");
            int refuel = int.Parse(Console.ReadLine());
            car.Refuel(refuel);
            car.Drive();
            Console.ReadLine();*/
            int a, b, thuong;
            Console.WriteLine("Nhap a,b");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            try
            {
                thuong = a / b;
                Console.WriteLine("Thuong {0}/{1}={2}", a, b, thuong);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ban phai nhap so nguyen");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("b phai khac 0");
            }
            catch
            {
                Console.WriteLine("Loi chua xac dinh, co the do tran bo nho hoac do phan cung ...");
            }
            finally
            {
                Console.WriteLine("Ket thuc");
            }
            Console.ReadLine();
        }
    }
}
