/*массив строк из него сделать массив,в котором не больше 3 элементов
*/

string[] M(string message)
{
    Console.WriteLine(message);
    string stroka = Console.ReadLine();
    var M = stroka.Split(' ');
    return M;
}