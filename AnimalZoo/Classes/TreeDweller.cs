namespace Animal_Zoo.Classes
{
    abstract class TreeDweller : Mammal
    {
        public virtual bool IsClimber { get; set; }

        public string TreeDwellerInfo()
        {
            return "\nTreeDweller: Animals that dwells on trees....";
        }
    }
}
