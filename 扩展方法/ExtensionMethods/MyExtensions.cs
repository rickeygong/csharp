namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static string SplitEmailAddressPrefix(this string str)
        {
            string emile = str;
            int index = emile.IndexOf('@');//确定@的位置
            string userName = emile.Substring(0, index); 
            //string doMain = emile.Substring(index + 1);
            return userName;
        }
    }
}
