namespace codewarskatas
{
    
    // You have access to the ship "draft" and "crew". "Draft" is the total ship weight and "crew" is the number of humans on the ship.
    //
    //     Each crew member adds 1.5 units to the ship draft. If after removing the weight of the crew, the draft is still more than 20, then the ship is worth looting. Any ship weighing that much must have a lot of booty!
    //
    // Add the method
    //
    //     IsWorthIt
    // to decide if the ship is worthy to loot. For example:
    //
    // titanic.IsWorthIt() => false
    public class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt()
        {
            double shipWeight = Draft - (Crew * 1.5);
            return shipWeight > 20;
        }
    }
}