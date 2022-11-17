using Приемная_комиссия.Models;
namespace Nuget
{
    public class AbiturientNuget<T> where T : class
    {
        private List<T> Abitur = new List<T>();

        public AbiturientNuget() { }
        public List<T> Get()
        {
            return Abitur;
        }

        public void Add(T data)
        {
            Abitur.Add(data);
        }
        public void Remove(T data)
        {
            Abitur.Remove(data);
        }

        public void Update(int index, T data)
        {
            Abitur[index] = data;
        }
    }
}