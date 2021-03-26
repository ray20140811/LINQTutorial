<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

var n1 = numbers.Where(x => x < 5);
n1.Dump();

var n2 = numbers.Where(x=>x < 5).Select(x=>x);
n2.Dump();
