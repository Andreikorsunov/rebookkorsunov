using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace rebookkorsunov
{
    public class ktoten : ContentPage
    {
        public ktoten()
        {
            Label titleLabel = new Label
            {
                Text = "Kes sa oled, Vari? Aleksandra Pivovarova",
                // More properties set here to define the Label appearance
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new StackLayout
                {
                    Children =
                {
                    new Label
                    {
                        Text = "FOR the most wild, yet most homely narrative which I am about to pen, I neither expect nor solicit belief. Mad indeed would I be to expect it, in a case where my very senses reject their own evidence. Yet, mad am I not -- and very surely do I not dream. But to-morrow I die, and to-day I would unburthen my soul. My immediate purpose is to place before the world, plainly, succinctly, and without comment, a series of mere household events. In their consequences, these events have terrified -- have tortured -- have destroyed me. Yet I will not attempt to expound them. To me, they have presented little but Horror -- to many they will seem less terrible than barroques. Hereafter, perhaps, some intellect may be found which will reduce my phantasm to the common-place -- some intellect more calm, more logical, and far less excitable than my own, which will perceive, in the circumstances I detail with awe, nothing more than an ordinary succession of very natural causes and effects.",
                    },
                    // More Label objects go here
                }
                }
            };

            Title = "Kes sa oled, Vari?";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = { titleLabel, scrollView }
            };
        }
    }
}