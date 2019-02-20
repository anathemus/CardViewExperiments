using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PanCardViewSample.ViewModels
{
	public class CarouselSampleScrollViewModel
	{
        
		public CarouselSampleScrollViewModel()
		{
            Items = new List<KeyValuePair<string, string>>();
            Items.Add(new KeyValuePair<string, string>("HeaderText", "Track your Coverages"));
            Items.Add(new KeyValuePair<string, string>("HeaderText", "Get Solid Advice"));
            Items.Add(new KeyValuePair<string, string>("HeaderText", "Find Savings Fast"));
        }

		public List<KeyValuePair<string, string>> Items { get; }
	}
}