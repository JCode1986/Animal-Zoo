namespace Animal_Zoo.Classes
{
    public abstract class TreeDweller : Mammal
    {
        public virtual bool IsClimber { get; set; }

        /// <summary>
        /// Returns a string of what a tree dweller is defined as.
        /// </summary>
        /// <returns></returns>
        public string TreeDwellerInfo()
        {
            return "\nTreeDweller: Animals that dwells on trees....";
        }
    }
}
