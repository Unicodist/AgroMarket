using AgroMarket.Shared.Exception;

namespace AgroMarket.Shared.BaseType
{
    public class Name
    {
        private string name;

        public Name(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new IllegalNameException();
            name = name.Trim();
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
