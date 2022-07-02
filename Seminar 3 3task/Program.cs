
void printGipotenuza(double ax, double ay, double bx, double by)
{
    double deltaX = ax - bx;
    double deltaY = ay - by;
    double c = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    System.Console.WriteLine(c);
}
printGipotenuza(7,-5,1,-1);