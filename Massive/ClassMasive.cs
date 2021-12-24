class Massive
{
    int[] m1;

    public Massive(int[] MyArray)
    {
        m1 = MyArray;
    }

    public Massive(int rows)
    {
        m1 = new int[rows];
    }

    public void GetMassive()
    {
        Random r = new Random();
        for (int i = 0; i < m1.Length; i++)
        {
            m1[i] = r.Next(-10000, 10000);
        }
    }
    public void GiveMassive()
    {
        for (int i = 0; i < m1.Length; i++)
        {
            Console.WriteLine($"{m1[i]} \t");
        }
    }
    public void Pair()
    {
        int count=0;
        for (int i = 0; i < m1.Length-1; i++)
        {

            if(m1[i]==0)
            {
                count = count;
            }
            else if (m1[i] % 3 == 0 ^ m1[i + 1] % 3 == 0)
            { 
                count++;
            }
        }
        Console.WriteLine($"============{count}===========");
    }   
}