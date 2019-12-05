using System.Collections.Generic;

namespace SampleApp
{
    public class MainPageViewModel
    {
        public List<TemplatedObject> TemplatedObjects { get; set; }

        public MainPageViewModel()
        {
            TemplatedObjects = new List<TemplatedObject>();
            for (var i = 0; i < 10; i++)
            {
                TemplatedObjects.Add(new TemplatedObject{ Title = $"My Title {i}", Description = "This is a default description."});
            }
        }
    }

    public class TemplatedObject
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}