Console.WriteLine("Введите первое число");
int pervoe = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите второе число");
int vtoroe = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int tretie = int.Parse(Console.ReadLine ());
int Max = pervoe;
if (pervoe > vtoroe)
 {
  if (pervoe > tretie)
  Max = pervoe;
  else
  Max = tretie;
}
if (pervoe < vtoroe)
 {
  if (vtoroe > tretie)
   Max = vtoroe;
   else 
   Max = tretie;
 }
 Console.WriteLine("Максимальное число равно " + Max );
