using PanCardView;
using PanCardView.Controls;
using PanCardView.Controls.Styles;
using PanCardViewSample.ViewModels;
using Xamarin.Forms;
using System.Collections.Generic;

namespace PanCardViewSample.Views
{
	public class CarouselSampleSrollView : ContentPage
	{
		private readonly CarouselView _carouselView;

		public CarouselSampleSrollView()
		{
			_carouselView = new CarouselView
			{
				ItemTemplate = new DataTemplate(GetCardItem),
				Children = {
					new IndicatorsControl
					{
						SelectedIndicatorStyle = new Style(typeof(Frame))
						{
							BasedOn = DefaultIndicatorItemStyles.DefaultSelectedIndicatorItemStyle,
							Setters = {
								new Setter { Property = BackgroundColorProperty, Value = Color.Red }
							}
						}
					}
				}
			};
			_carouselView.SetBinding(CardsView.ItemsSourceProperty, nameof(CarouselSampleScrollViewModel.Items));

			Title = "CarouselView scroll";

			Content = _carouselView;
			BindingContext = new CarouselSampleScrollViewModel();
		}


		private View GetCardItem() => new CardItem();
	}

	public class CardItem : ContentView
	{
		public CardItem()
		{
            Label slideHeader = new Label
            {
                FontFamily = "SFUIDisplay-Medium",
                FontSize = 26,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black
            };
            slideHeader.SetBinding(Label.TextProperty, "HeaderText");

            var scroller = new ScrollView
			{
				WidthRequest = 280,
				BackgroundColor = Color.White,
				Content = new StackLayout
				{
					WidthRequest = 280,
					Children =
					{
						slideHeader,
						//new Label
						//{
						//	WidthRequest = 280,
						//	TextColor = Color.Gold,
						//	FontSize = 50,
						//	Text = "\nasfla jlasjf lkasj flkasjf lkajslk fjasl fjlas jflkjf alk sjflkasj lkasj flkasj flkajs lfjasl kfjaslk fjlaks jflask jfslka jlkaj flkasj faskf jalks fjlkas jflkas jfasj flas jfalks fjlaf "
						//}
					}
				}
			};

			Content = scroller;
		}
	}
}
