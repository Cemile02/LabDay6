namespace Labday6.Models
{
    public class CustomList<T>
    {
        public T[] Values;
        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return Capacity;
            }

            set
            {
                if (value < Count)
                {
                    throw new Exception("Current capacity can not be less than size");
                }
                else
                {
                    Console.WriteLine( "worked");
                    Capacity = value;
                }

            }
            //get; set;
        }
        public CustomList()
        {
            Values = new T[0];
            Count = 0;
            Capacity = 0;   
        }

        public void Add(T value)
        {
            if (Values.Length == 0 && Capacity==0)
            {

                Capacity = 4;  
            }
            else
            {
              
                if (Count == Capacity)
                {
                    Capacity = Capacity * 2;
                }
            }
            Array.Resize(ref Values, Capacity);
            Values[Count] = value;
            Count++;
        }
    }
}
