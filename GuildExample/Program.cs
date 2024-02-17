namespace GuildExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guild = new Guild();
            var welcomer = new MemberWelcomer();
            var hall = new GuildHall();

            //guild.NewMemberAdded += welcomer.WelcomeMember;
            //guild.NewMemberAdded += hall.AddBedroom;
            guild.AddMember("Knight");

        }
    }
    public class Guild
    {
        // static action event is delegate
        public static event Action<string> NewMemberAdded;

        private readonly List<string> _members = new List<string>();
        public void AddMember(string memberName) 
        { 
            _members.Add(memberName);
            NewMemberAdded?.Invoke(memberName);
        }
    }

    public class MemberWelcomer
    {
        public MemberWelcomer() 
        {
            Guild.NewMemberAdded += WelcomeMember;
        }
        public void WelcomeMember(string memberName) 
        {
            Console.WriteLine($"Welcome {memberName}");
        }
    }

    public class GuildHall
    {
        public GuildHall() 
        {
            Guild.NewMemberAdded += AddBedroom;
        }
        public void AddBedroom(string memberName)
        {
            Console.WriteLine($"A room was added to the guild hall for {memberName}");
        }
        
    }
}