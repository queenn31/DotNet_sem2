 while (true)
 {
    int day;
    Console.WriteLine("Введите число дня недели: ");
    day=int.Parse(Console.ReadLine());

    if(day<=5){

    Console.WriteLine("рабочий");

    }

    else{

    Console.WriteLine("выходной");

    }
}
Console.ReadLine();