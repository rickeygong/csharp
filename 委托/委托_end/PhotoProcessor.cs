using System;

namespace 委托_end
{
    //System.Action<> 没返回值
    //System.Func<> 有返回值

    //public delegate void PhotoFilterHandler(Photo photo);
    public class PhotoProcessor
    {
        public void Process(Photo photo, Action<Photo> photoFilterHandler)
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
