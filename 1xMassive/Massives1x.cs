class Massives1x
{
    int[] MyArray;
    int Step;
    int start;
    int Mull;

    public Massives1x(int[] InsideMassive, int StepIn, int Begin, int Mull)
    {
        this.MyArray = InsideMassive;
        this.Step = StepIn;
        this.start =Begin;
        this.Mull = Mull;
    }

    public Massives1x(int x, int y, int z, int mull)
    {
        MyArray = new int[x];
        Step = y;
        start = z;
        MyArray[0] = z;
        Mull = mull;
    }

    public void GetMassive()
    {
        for (int i = 1; i < MyArray.Length; i++)
        {
            MyArray[i] = Step + MyArray[i - 1];
        }
    }
    public void PrintMassive ()
    {
        for (int i = 0; i < MyArray.Length; i++)
        {
            Console.WriteLine(MyArray[i]);
        }
    }

    public int Sum()
    {
        int sum = 0;
        for (int i = 0;i<MyArray.Length ; i++)
        {
            sum += MyArray[i];
        }
        return sum; 
    }

    public int[] Inverse ()
    {
        int[] Inver = new int [MyArray.Length];  
        for (int i = 0;i<MyArray.Length ; i++)
        {
            Inver[i] = -MyArray[i];
        }
        return Inver; 
    }

    public int [] Multi ()
    {
        int [] MultiX = new int [MyArray.Length];
        for ( int i = 0;i < MyArray.Length ; i++)
        {
            MultiX[i] = MyArray[i] * Mull;
        }
        return MultiX;
    }

    //не уверен, нужно было максимальное число элементов или просто самый большой элемент
    public int MaxCount ()
    {
        return MyArray.Length;
    }


}