int A(int m, int n ) 
{ 
      if (m == 0) 
          return (n + 1);
     else if ((m != 0) && (n == 0))
          return A( m - 1, 1); 
      else  
          return A( m - 1, A(m, n-1));
}
Console.Clear(); 
Console.Write("Введите число m: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число n: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(A(m, n)); 

