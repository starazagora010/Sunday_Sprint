namespace _00_TheoryChecker
{
    public class Doggy
    {
        public Doggy()
        {
            
        }

        public Doggy(string name)
        {
            
        }

        public Doggy(int age)
        {
            
        }

        public Doggy(int age,string name = "Pesho"):this(age) 
        // AGE takes the ctor without default for age; age can be PRE-SET: this(10)
        // NAME defaulted like this becomes an OPTIONAL parameter (opt-par are declared last in the ctor)
        {
            
        }
    }
}