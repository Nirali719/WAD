Console.Write("enter marks : ");
int[] arr = new int[5];

for (int i = 0; i < 5; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}
double percentage;
percentage = (sum / 5.0);

Console.WriteLine($"total marks : {sum}");
Console.WriteLine($"percentage : {percentage}");

String grade = percentage switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    >= 50 => "E",
    _ => "Fail"
};
Console.WriteLine($"grade : {grade}");
