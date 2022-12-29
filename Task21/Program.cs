// координаты двух точек в 3д пространстве
double Location(string name)
{
    System.Console.WriteLine(name);
    double Ax= Convert.ToDouble(Console.ReadLine());
    return Ax;
}
double Ax=Location("Введите Ax");
double Ay=Location("Введите Ay");
double Az=Location("Введите Az");
double Bx=Location("Введите Bx");
double By=Location("Введите By");
double Bz=Location("Введите Bz");

double AB= Math.Sqrt(Math.Pow((Bx-Ax),2)+Math.Pow((By-Ay),2)+Math.Pow((Bz-Az),2));
Console.WriteLine(AB);