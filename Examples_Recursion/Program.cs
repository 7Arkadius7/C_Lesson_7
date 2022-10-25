Console.Clear();

// // // // Собрать строку с числами от а до b, a<=b

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// // // //______________Делаем через рекурсию_______________

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// System.Console.WriteLine(NumbersFor(1, 10));
// System.Console.WriteLine(NumbersRec(1, 10));
// System.Console.WriteLine();



// // // // Собрать строку с числами от а до b, a >= b

// // string NumbersFor2(int a, int b)
// // {
// //     string result = String.Empty;
// //     for (int i = a; i >= b; i--)
// //     {
// //         result += $"{i} ";
// //     }
// //     return result;
// // }

// // // //______________Делаем через рекурсию_______________

// string NumbersRec2(int a, int b)
// {
//     if (a <= b) return NumbersRec2(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }
// // System.Console.WriteLine(NumbersFor2(1, 10));
// System.Console.WriteLine(NumbersRec2(1, 10));

// System.Console.WriteLine();




// // // // Собрать строку с суммой чисел от 1 до n

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }


// System.Console.WriteLine(SumFor(10));

// //______________Делаем через рекурсию_______________


// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else if (n == 1) return 1;
//     else return n + SumRec(n - 1);
// }


// System.Console.WriteLine(SumRec(10));
// System.Console.WriteLine();


// // Факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }
// System.Console.WriteLine(FactorialFor(10));

// //______________Делаем через рекурсию_______________

// int FactorialRec(int n)
// {
//     if (n == 1 || n == 0) return 1;
//     else return n * FactorialRec(n - 1);
// }

// System.Console.WriteLine(FactorialRec(10));
// System.Console.WriteLine();




// // Возводим число а в натуральную степень n

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// System.Console.WriteLine(PowerFor(2, 10));

// //______________Делаем через рекурсию_______________

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     // if (n == 0) return 1;
//     // else return PowerRec(a, n - 1) * a;
// }
// System.Console.WriteLine(PowerRec(2, 10));

// //______________Делаем через рекурсию #2_______________

// int PowerRec2(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRec2(a * a, n / 2);
//     else return PowerRec2(a, n - 1) * a;
// }
// System.Console.WriteLine(PowerRec2(2, 10));
// System.Console.WriteLine();




// // Перебор слов

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
//     }
// }
// System.Console.WriteLine();

// // Перебор слов

// n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         System.Console.WriteLine($"{n++} {new string(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[2]); // какая стоит цифра, с таким количеством букв ищем слова из букв, представленных в строке
// System.Console.WriteLine();


// // Поиск в дериктории

// // string path = "/Users/Сергей/Desktop/Geek обучение/3 Знакомство с языком программирования С#";
// // DirectoryInfo di = new DirectoryInfo(path);
// // System.Console.WriteLine(di.CreationTime);
// // FileInfo[] fi = di.GetFiles();

// // for (int i = 0; i < fi.Length; i++)
// // {
// //     System.Console.WriteLine(fi[i].Name);
// // }
// //_______________________________________________________________________



// // void CatalogInfo(string path, string indent = "")
// // {
// //     DirectoryInfo catalog = new DirectoryInfo(path);

// //     DirectoryInfo[] catalogs = catalog.GetDirectories();
// //     for (int i = 0; i < catalogs.Length; i++)
// //     {
// //         System.Console.WriteLine($"{indent}{catalogs[i].Name}");
// //         CatalogInfo(catalogs[i].FullName, indent + " ");
// //     }
// //     FileInfo[] files = catalog.GetFiles();
// //     for (int i = 0; i < files.Length; i++)
// //     {
// //         System.Console.WriteLine($"{indent}{files[i].Name}");
// //     }
// // }
// // string path = @"/Users/Сергей/Desktop/Geek обучение/3 Знакомство с языком программирования С#";
// // CatalogInfo(path);

// //_____________________________________________________________________



// // Пирамидки (Ханоиские башни)

// void Towers(string with = "1", string on = "3", string some = "2", int count = 5) // где with - где находятся все текущие блинцики, 
//                                                                                   // on - куда надо переместить все блинчики
//                                                                                   // some - промежуточная башня
//                                                                                   //count - количество блинчиков для перемещения
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     System.Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();//
// System.Console.WriteLine();


// // Бинарное дерево 

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         System.Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();


// // Подсчет итераций у дискретного метода вычисления чисел Фибоначи и через рекурсию

// decimal fRec = 0;
// decimal fIte = 0;

// decimal FibonacciRecursion(int m)
// {
//     fRec++;
//     return m == 0 || m == 1 ? 1 : FibonacciRecursion(m - 1) + FibonacciRecursion(m - 2);
// }

// decimal FibonacciIntegration(int m)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i < m; i++)
//     {
//         result = f0 + f1;

//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }

// DateTime dt = DateTime.Now;

// for (int m = 10; m < 40; m++)
// {
//     System.Console.WriteLine($"FibonacciIntegration({m}) = {FibonacciIntegration(m)} fIte = {fIte.ToString("### ### ###"),-15}");
//     fIte = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


// DateTime dtR = DateTime.Now;

// for (int m = 10; m < 40; m++)
// {
//     System.Console.WriteLine($"FibonacciRecursion({m}) = {FibonacciRecursion(m)} fRec = {fRec.ToString("### ### ###"),-15}");
//     fRec = 0;
// }
// System.Console.WriteLine((DateTime.Now - dtR).TotalMilliseconds); // Вячисляем сколько понадобилось времени для вычислений




// Закрашивание замкнутой области

int[,] pic = new int[50, 50];
for (int i = 0; i < 50; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 49] = 1;
    pic[49, i] = 1;
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) System.Console.Write($" ");
            else System.Console.Write($"+");
        }
        System.Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);
FillImage(1, 1);
System.Console.WriteLine();
PrintImage(pic);