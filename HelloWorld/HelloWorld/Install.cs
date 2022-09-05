namespace HelloWorld
{
    class Install
    {
        private readonly Logger logger;

        public Install(Logger logger)
        {
            this.logger = logger;
        }
        public void install()
        {
            logger.Log("安装开始");
            //todo:安装过程省略
        }
    }



}
