using System;

namespace TongDuongCheoTrongMang
{
    class Program
    {
        static void Main(string[]args)
        {
            int length;            
            int i,j;  
            int sumArray = 0;          
            while(true)
            {
                Console.Write("Nhap vao do dai cua mang: ");
                if (int.TryParse(Console.ReadLine(),out length)&& length >0)
                {
                    break;
                }
                continue;
            }
            
            int [,] array = new int [length,length];
            for(i=0;i<length;i++)
            {
                for(j=0;j<length;j++)
                {                    
                    while(true)
                    {
                        Console.Write("Nhap vao gia tri phan tu array[{0},{1}]: ",i,j);
                        if (int.TryParse(Console.ReadLine(),out array[i,j]))
                        {
                            break;
                        }
                        continue;
                    }
                }
            }
            Console.WriteLine("Mang vua nhap la: ");
            for(i=0;i<length;i++)
            {
                for(j=0;j<length;j++)
                {                    
                    Console.Write("{0,5}",array[i,j]);
                }
                Console.WriteLine();
            }
            //Tổng đường chéo chính
            for(i=0;i<length;i++)
            {
                sumArray+=array[i,i];  
            }
            Console.WriteLine("Gia tri lon nhat trong mang la: "+sumArray);
            //Tổng đường chéo chính hướng còn lại
            // for(i=0;i<length;i++)
            // {
            //     for(j=0;j<length;j++)
            //     {
            //         if (i+j==length-1)
            //         {
            //             sumArray+=array[i,j];
            //         }
            //     }                  
            // }
            // Console.WriteLine("Gia tri lon nhat trong mang la: "+sumArray);
        }
    }
}