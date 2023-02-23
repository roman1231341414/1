/*массив строк из него сделать массив,в котором не больше 3 элементов
*/

string[] M(string message)
{
    Console.WriteLine(message);
    string stroka = Console.ReadLine();
    var M = stroka.Split(' ');
    return M;
}

void M1(string[] M)
{
    var result = new string[M.Length];
    var realSize = 0;
    foreach (var value in M)
    {
        if (value.Length <= 3)
        {
            result[realSize] = value;
            realSize++;
        }
    }
    Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
}
string[] MM = M("Введите массив строк через пробел");
M1(MM);