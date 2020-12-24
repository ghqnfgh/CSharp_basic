﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Use_method
    {
        static void Main()
        {
            // 기본 출력 방식
            // System : namespace. root namespace는 global이며 System namespace는 원래 global::System임.
            // System.Console : .NET Framework 클래스
            // System.Console.WriteLine("Hello World...");

            // 클래스 선언 시에는 new를 이용해 새로운 객체 할당


            // 1) Datatype
            // Practice_Datatype PDtmp = new Practice_Datatype();
            // PDtmp.Method();

            // 2) Variable
            // Practice_Variable PVtmp = new Practice_Variable();
            // PVtmp.Method();

            // 3) Array
            // Practice_Array PAtmp = new Practice_Array();
            // PAtmp.Method();

            // 4) String
            Practice_String PStmp = new Practice_String();
            // PStmp.StringMethod();
            PStmp.StringBuilderMethod();

            // Q) obj로 새로운 클래스를 그대로 받아올 수 있지만 해당 클래스의
            // Method나 property에는 접근할 수 없는 이유..?
            Object obj = PStmp;
            // Console.WriteLine(obj.GetType());
            
                        

            // Console 자동 종료 방지
            // Console.ReadLine() : 엔터 키 입력 시 콘솔 종료
            Console.ReadKey(); //  아무 키 입력 시 콘솔 종료
        }
    }
}
