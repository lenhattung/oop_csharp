namespace Lab17_Stack
{
    public abstract class Notification
    {
        public string Content { get; }

        protected Notification(string content)
        {
            Content = content;
        }

        public abstract void Show();
    }

}
