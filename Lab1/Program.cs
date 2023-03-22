
StringOperate op1 = new StringOperate((word, num) =>
{
    return string.Concat(Enumerable.Repeat(word, num));
});
Console.WriteLine(op1("hello", 2));

StringOperate op2 = new StringOperate((word, num) =>
{
    return word.Remove(word.Length - num);
});
Console.WriteLine(op2("hello", 2));

delegate string StringOperate(string wordArg, int numArg);