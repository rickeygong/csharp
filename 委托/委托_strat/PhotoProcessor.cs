namespace 委托_strat
{
    public class PhotoProcessor
    {
        public void Process(Photo photo)
        {
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}
