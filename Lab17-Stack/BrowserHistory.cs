namespace Lab17_Stack
{
    public class BrowserHistory
    {
        private readonly Stack<string> _backStack = new Stack<string>();
        private readonly Stack<string> _forwardStack = new Stack<string>();

        public string CurrentPage { get; private set; }

        public bool CanGoBack => _backStack.Count > 0;
        public bool CanGoForward => _forwardStack.Count > 0;

        public BrowserHistory(string homePage)
        {
            CurrentPage = homePage;
        }

        public void Visit(string url)
        {
            _backStack.Push(CurrentPage);
            CurrentPage = url;
            _forwardStack.Clear();      // mở trang mới thì không Forward được nữa
        }

        public bool Back()
        {
            if (!CanGoBack) return false;
            _forwardStack.Push(CurrentPage);
            CurrentPage = _backStack.Pop();
            return true;
        }

        public bool Forward()
        {
            if (!CanGoForward) return false;
            _backStack.Push(CurrentPage);
            CurrentPage = _forwardStack.Pop();
            return true;
        }
    }
}
