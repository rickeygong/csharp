namespace DelegateDemo_end
{
    //定义委托，因为委托是一个类，我习惯写在class外面
    //接下来图片的滤镜都交由该委托进行处理
    public delegate void PhotoFilterHandler(Photo photo);
    public class PhotoProcessor
    {
        //将委托传入Process
        public void Process(Photo photo, PhotoFilterHandler photoFilterHandler)
        {
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            photoFilterHandler(photo);
            photo.Save();
        }
    }
}
