using System;
using System.Collections.Generic;

List<int> intList = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<string> strList = new List<string> { "♠A", "♥K", "♦Q", "♣J" };
List<string> nameList = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };


Console.WriteLine("=== 컬렉션 셔플 테스트 ===");

Console.WriteLine("[숫자 리스트 셔플]");
Console.WriteLine($"원본: {string.Join(", ", intList)}");
intList.ShuffleList();
Console.WriteLine($"셔플: {string.Join(", ", intList)}");


Console.WriteLine("\n[카드 덱 셔플]");
Console.WriteLine($"원본: {string.Join(", ", strList)}");
strList.ShuffleList();
Console.WriteLine($"셔플: {string.Join(", ", strList)}");


Console.WriteLine("\n[학생 순서 무작위 배치]");
Console.WriteLine($"원본: {string.Join(", ", nameList)}");
nameList.ShuffleList();
Console.WriteLine($"셔플: {string.Join(", ", nameList)}");
