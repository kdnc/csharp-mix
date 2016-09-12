namespace _02_generics_new_constraint
{
    internal class NewIntList : MyList<int>, IMyList<int>
    {
        private NewIntList(int capacity) : base(capacity)
        {
        }
    }
}