namespace Lab17_Stack
{
    public class EmailNotification : Notification
    {
        public EmailNotification(string content) : base(content) { }
        public override void Show() => Console.WriteLine($"[Email] {Content}");
    }
}
