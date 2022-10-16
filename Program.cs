// Калинин Павел 15-16.10.2022 
// Знакомство с языками программирования (семинары)
// Урок 5. Функции продолжение
// Домашняя работа

bool isRepeat = true; 
string s = "";
string taskName = "";

// if(false) { // выборочно отключить для отладки

taskName = "Задание  №1. Найти точку пересечения двух прямых заданных уравнениями: y=k1*x+b1, y=k2*x+b2.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.WriteLine("Решение: из системы уравнений выражены координаты точки пересечения"
                        +" x=(b2-b1)/(k1-k2), y=k1*x+b1.");
    Console.Write("Введите действующее число коэффициент k1: ");
    double k1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите действующее число коэффициент b1: ");
    double b1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите действующее число коэффициент k2: ");
    double k2 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите действующее число коэффициент b2: ");
    double b2 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    if (k1 == k2 && b1 == b2) {
        Console.WriteLine("Прямые совпадают.");
    } else if (k1 == k2) {
        Console.WriteLine("Прямые не имеют точки пересечения.");
    } else {
        double x=(b2-b1)/(k1-k2), y=k1*x+b1;
        Console.WriteLine($"({x};{y})");
    }
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


taskName = "Задание  №2. Написать программу масштабирования фигуры.";
// функция определения точек из строки в формате (-0,2;-12)(0;1)(1,5;-1)(18;20)(-5,6;8)
double[][] getPoints(string s) {
    s = s.Replace(" ","");
    string[] ss = s.Split(")(");
    int len = ss.Length;
    double[][] points = new double[len][];
    for(int i=0; i<len; i++) {
        ss[i]=ss[i].Replace(")","").Replace("(","");
        string[] ss2 = ss[i].Split(";");
        points[i] = new double[2];
        points[i][0]=double.Parse(ss2[0]);
        points[i][1]=double.Parse(ss2[1]);
    }
    return points;
}

isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.WriteLine("Введите действующее числа координаты точек фигуры в формате"
                   + "(-0,2;-12)(0;1)(1,5;-1)(18;20)(-5,6;8): ");
    Console.Write(">");
    s = Console.ReadLine() ?? "0";
    double[][] points = getPoints(s);
    Console.WriteLine("После преобразования строки в координаты точек:");
    Console.Write("<");
    foreach(double[] el in points) Console.Write("("+el[0]+";"+el[1]+")"); 
    Console.WriteLine("");

    Console.WriteLine("Введите действующее числа координаты точки в формате (x;y), "
                      + "относительно которой будет масштабироваться фигура:");
    Console.Write(">");
    s = Console.ReadLine() ?? "0";
    double[][] pointRelative = getPoints(s);
    Console.WriteLine("После преобразования строки в координаты точек:");
    Console.Write("<");
    foreach(double[] el in pointRelative) Console.Write("("+el[0]+";"+el[1]+")"); 
    Console.WriteLine("");

    Console.WriteLine("Введите действующее число коэффициент масштабирования:");
    Console.Write(">");
    double k = double.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Решение:");
    Console.WriteLine("Масштабированием фигуры относительно указанной точки является"
                      + " определение новых координат точек по формуле \n"
                      + " x'=x*k-x0*(k-1), y'=y*k-y0*(k-1), где к-коэф. масш-ия, "
                      + " (x0;y0) - точка относительно которой будет масшт. фигура.");
    double[][] pointsNew = new double[points.Length][];
    double x0 = pointRelative[0][0], y0 = pointRelative[0][1];
    for(int i=0; i<points.Length; i++) {
        double x = points[i][0];
        double y = points[i][1];
        pointsNew[i] = new double[2];
        pointsNew[i][0]=x*k-x0*(k-1);
        pointsNew[i][1]=y*k-y0*(k-1);
    }
    Console.WriteLine("Ответ:");
    foreach(double[] el in pointsNew) Console.Write("("+el[0]+";"+el[1]+")"); 
    Console.WriteLine("");

    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


taskName = "Задание  №3. Написать программу копирования массива.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    int[] ar = {0,1,2,3,4,5,6,7,8,9};
    int[] ar2 = new int[ar.Length];
    Console.WriteLine("Решение: копия создана через Array.Copy()");
    Array.Copy(ar,ar2,ar.Length);
    Console.WriteLine("Ответ:");
    Console.WriteLine("Хэш массива начального: "+ar.GetHashCode());
    Console.WriteLine("Хэш массива копии:      "+ar2.GetHashCode());
    Console.Write("Массив начальный: ");
    foreach(int el in ar) Console.Write(el+" "); 
    Console.WriteLine("");
    Console.Write("Массив копия:     ");
    foreach(int el in ar2) Console.Write(el+" "); 
    Console.WriteLine("");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    
 

// }

