using System;
namespace danhsach{
    class program{
        static void Main(string[] Args){
            string[] hocsinh = {"hoang","nam","kiem","tai","thang"};

            Console.WriteLine("nhap ten hoc sinh");
            string tenhocsinh = Console.ReadLine();

            bool danghi = false;
            for(int i = 0; i < hocsinh.Length; i++){
                if(hocsinh[i] == tenhocsinh){
                    Console.WriteLine("ten cua hoc sinh trong danh sach: " + tenhocsinh + "o so: " + (i + 1));
                    danghi = true;
                    break;
                }
            }
            if(!danghi){
                Console.WriteLine("khong tim thay: " + tenhocsinh);
                
            }
        }
    }
}