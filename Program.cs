using System;

namespace params__in_named_and_optional_args
{
    class Program
    {
        public static void hezka(params int [] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(Math.Pow(nums[i], i + 1));

            }
        }
        public static void kefel(int a,int b = 1,int c = -1)
        {
            Console.WriteLine(a*b*c);
        }
        public static int  kefel_3(in int num)
        {
            return num * 3;
        }
        static void Main(string[] args)
        {
            //hezka(2, 2, 2, 2);
            //kefel(2);
            //kefel(c: 10, a: 1);
            int num = 1;
            int res = kefel_3(1);
            Console.WriteLine(res);
            Phone a = new Phone(model:"iphonex",screen_size:"1000x2000",camera_qulity:"ok",battery:2000);
            Phone b = new Phone(model: "iphonex", camera_qulity: "good", screen_size: "1080x2580", battery: 4000);
            Phone c = new Phone(screen_size: "1000x2000", model: "iphonex", camera_qulity: "ok", battery: 2000);
            Phone d = new Phone(battery: 1000, camera_qulity: "bad", screen_size: "1020x2000", model: "iphonexr" );
            Console.ReadLine();
        }
    }
}
