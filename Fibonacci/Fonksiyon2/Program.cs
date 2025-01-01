public class Fonksiyon2
{
    public static void Main(string[] args)
    {

   dongu(1,1,11);//1 e 1 den 11. fobinacci sayısına kadar gider

    }
    public static int dongu(int i,int x,int n)
    {
     

        if (n<=0)
        {
            return 0;
        }
        else
        {
            if (n != 1)
            {
                Console.Write(i + " " + x + " ");
            }
            else
            {
                Console.Write(i);
            }

            i = i + x;
            x = i + x;

          
            return dongu(i,x,n-2);
        }
       
    }
}


