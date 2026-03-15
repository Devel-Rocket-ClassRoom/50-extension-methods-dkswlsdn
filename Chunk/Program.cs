using System;
using System.Collections.Generic;
using System.Linq;


int[] intList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] students = { "김철수", "이영희", "박민수", "최지연", "정우진" };
int[] pages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };


Console.WriteLine("=== 컬렉션 청킹 테스트 ===");

Console.WriteLine("[숫자를 3개씩 그룹화]");

foreach (var chunk in intList.Chunk<int>(3))
{
    Console.Write('[');

    Console.Write(string.Join(", ", chunk));

    Console.WriteLine(']');
}


Console.WriteLine("\n[학생들을 2명씩 팀 구성]");

int count = 0;
foreach (var chunk in students.Chunk<string>(2))
{
    count++;
    Console.Write($"팀 {count}: {string.Join(", ", chunk)}");
    Console.WriteLine();
}


Console.WriteLine("\n[페이지별로 5개씩 나누기]");

count = 0;
foreach (var chunk in pages.Chunk<int>(5))
{
    count++;
    Console.WriteLine($"페이지 {count}: {string.Join(", ", chunk)}");
}