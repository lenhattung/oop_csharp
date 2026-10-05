namespace Lab17_Stack
{
    public class SmsNotification : Notification
    {
        public SmsNotification(string content) : base(content) { }
        public override void Show() => Console.WriteLine($"[SMS] {Content}");
    }
}
