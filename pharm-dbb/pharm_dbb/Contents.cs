﻿
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace SAFA
{






    public class Contents : ContentPage
    {
        private ListView _pharmacylist;





        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }




      
        public void Reporting_Concerns_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Reporting a Concern";
            var tg = new d("17", "Reporting a concern", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Making_Safeguarding_Personal_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Making Safeguarding Personal";
            var tg = new Making_Safeguarding_Better();
            
            //      var tg = new d("21", "Making safeguarding personal", "#bfbfbf");
            // var tg= new LocalHtmlBaseUrl { Title = "BaseUrl" };
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Definition_Adult_At_Risk_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Definition of an Adult at Risk";
            var tg = new definition("1", "Definition of an Adult at Risk", "#953735");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void What_Is_Safeguarding_Clicked(object sender, EventArgs args)
        {
            App.app_title = "What is Safeguarding?";
            var tg = new What_Is_Safeguarding(App.app_title);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        public void Categories_Of_Abuse_Clicked(object sender, EventArgs args)
        {
                             App.app_title = "Categories of Abuse";
                             var tg = new Categories_Abuse();
                             Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        public void Recognising_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Recognising Abuse";
            var tg = new Recognising_Abuse(); 
            //  var tg = new d("14", "Reporting a concern", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }
    //    public void Recognising_Abuse_Clicked(object sender, EventArgs args)
    //    {
    //        App.app_title = "Safeguarding Adults from Abuse (SAFA)";
    //        var tg = new d("14", "safeguarding Adults from Abuse (SAFA)", "#bfbfbf");
    //        Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
    //
    //    }




        public void Reporting_Concern_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Reporting a concern";
            var tg = new d("17", "Reporting a concern", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

                    
        public class GetFrontPage
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }


        public class VC : ViewCell
        {
            public VC()
            { }
        }

        public Contents()
        {
            var s=new Label { HeightRequest=0};
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
                s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "HSAB SAFA", TextColor = Color.FromHex("953735"), Font = Font.SystemFontOfSize(24, FontAttributes.Bold) };
                s.HeightRequest = 40;
                s.BackgroundColor = Color.White;
                s.TextColor = Color.FromHex("#923b3d");
                BackgroundColor = Color.White;
               
            }

            

            var u = new Label { Text = "", FontSize = 10 };

            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";

            App.app_title = "HSAB SAFA";
            Title = "HSAB SAFA";
            BackgroundColor = Color.FromHex("FCDED4");


            //  BackgroundColor = Color.FromHex("#e6b9b8");


         
            BackgroundColor = Color.White;




            //           var data = new List<GetFrontPage>  {

            //           new GetFrontPage("Definition of an Adult at Risk", "Flag1.png"),
            //               new GetFrontPage("What is Safeguarding?", "Flag2.png"),
            //                  new GetFrontPage("Categories of Abuse", "Flag3.png"),
            //              new GetFrontPage("Recognising Abuse", "Flag4.png"),
            //                new GetFrontPage("Reporting a Concern", "Flag5.png"),
            //                new GetFrontPage("Making Safeguarding Personal", "Flag6.png"),

            //         };

            //           _pharmacylist = new ListView
            //         {

            //               SeparatorColor = Color.FromHex("#ddd"),
            //           };
            //           _pharmacylist.ItemsSource = data;
            //          var cell = new DataTemplate(typeof(ImageCell));
            //          cell.SetValue(TextCell.TextColorProperty, Color.FromHex("a50100"));
            //         _pharmacylist.HasUnevenRows = true;

            //         cell.SetBinding(TextCell.TextProperty, "Name");
            //          cell.SetBinding(ImageCell.ImageSourceProperty, "Image");

            //          _pharmacylist.ItemTemplate = cell;
            //          _pharmacylist.RowHeight = 63;

            //  BackgroundImage = "people.jpg";
            Button Definition_Adult_At_Risk = new Button { Text = "Definition of an Adult at Risk", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            Button What_Is_Safeguarding = new Button { Text = "What is Safeguarding?", BackgroundColor = Color.FromHex("#DB5E5E"), TextColor = Color.White, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            Button Categories_Of_Abuse = new Button { Text = "Categories of Abuse", BackgroundColor = Color.FromHex("#d99694"), TextColor = Color.FromHex("#953735"), VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            Button Recognising_Abuse = new Button { Text = "Recognising Abuse", BackgroundColor = Color.FromHex("#e6b9b8"), TextColor = Color.FromHex("#953735"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            Button Reporting_Concern = new Button { Text = "Reporting a Concern", BackgroundColor = Color.FromHex("#bfbfbf"), TextColor = Color.FromHex("#953735"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            Button Making_Safeguarding_Personal = new Button { Text = "Making Safeguarding Personal", BackgroundColor = Color.FromHex("#896A6A"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };







            Definition_Adult_At_Risk.Clicked += Definition_Adult_At_Risk_Clicked;
            What_Is_Safeguarding.Clicked += What_Is_Safeguarding_Clicked;
            Categories_Of_Abuse.Clicked += Categories_Of_Abuse_Clicked;
            Recognising_Abuse.Clicked += Recognising_Abuse_Clicked;
            Reporting_Concern.Clicked += Reporting_Concern_Clicked;
            Making_Safeguarding_Personal.Clicked += Making_Safeguarding_Personal_Clicked;



            var a = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand

                //  Padding = new Thickness (5, 5, 5, 5), 
            };
           





            var logo = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,

                Children = {
          new Image {
                                
                           //     BackgroundColor =Color.White,
                           VerticalOptions = LayoutOptions.CenterAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                          HeightRequest=40,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "HSAB.png" )
            }
                }

            };
            var i = new Image
            {

                //     BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 70,
                Source = ImageSource.FromFile("s4.jpg")
            };

            var o = new Image
            {

                //     BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 70,
                Source = ImageSource.FromFile("s1.jpg")
            };

            var j = new Image
            {

                //     BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 70,
                Source = ImageSource.FromFile("s4.jpg")
            };

            var jk = new Image
            {

                //     BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 70,
                Source = ImageSource.FromFile("s5.jpg")
            };


            var jj = new StackLayout
            { 
                BackgroundColor=Color.Black,
                Padding=2,
                Orientation=StackOrientation.Horizontal,
                Children = {i,o,jk}
            };

            var k = new StackLayout
                {
                   Padding=5,
                     //  BackgroundColor = Color.White,
                    Children = {
                  jj,
                  //  _pharmacylist,
                   Definition_Adult_At_Risk,
                   What_Is_Safeguarding,
                 Categories_Of_Abuse,
                 Recognising_Abuse,
                 Reporting_Concern,
                 Making_Safeguarding_Personal,
                    logo

                }
                };

            if (Device.OS == TargetPlatform.Windows)
            {

                Definition_Adult_At_Risk.FontSize = 22;
                What_Is_Safeguarding.FontSize = 22;
                Categories_Of_Abuse.FontSize = 22;
                Recognising_Abuse.FontSize = 22;
                Reporting_Concern.FontSize = 22;
                Making_Safeguarding_Personal.FontSize = 22;

               k = new StackLayout
                {
                    Padding = 5,
                    //  BackgroundColor = Color.White,
                    Children = {
                 s, jj,
                    Definition_Adult_At_Risk,
                   What_Is_Safeguarding,
                 Categories_Of_Abuse,
                 Recognising_Abuse,
                 Reporting_Concern,
                 Making_Safeguarding_Personal,
                      //  _pharmacylist,
                        logo

                }
                };
            }

                Content = k;






//            _pharmacylist.ItemSelected += (sender, e) =>
//            {


 //               if (e.SelectedItem == null) return;
 //               var user = (GetFrontPage)e.SelectedItem;
 //               if (user.Name == "Definition of an Adult at Risk")
 //               {
 //                   App.app_title = "Definition of an Adult at Risk";
 //                   var tg = new definition("1", "Definition of an Adult at Risk", "#953735");
 //                   Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
 //               }
 //               if (user.Name == "What is Safeguarding?")
 //               {
 //                   App.app_title = "What is Safeguarding?";
 //                   var tg = new What_Is_Safeguarding(App.app_title);

//                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

  //              }
  //              if (user.Name == "Categories of Abuse")
   //             {
   //                 App.app_title = "Categories of Abuse";
   //                 var tg = new Categories_Abuse();
   //                 Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
   //             }
   //             if (user.Name == "Recognising Abuse")
   //             {
   //                 App.app_title = "Recognising Abuse";
   //                 var tg = new Recognising_Abuse();
   //                 Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
   //             }


     //           if (user.Name == "Reporting a Concern")
   //             {
   //                 App.app_title = "Reporting a concern";
    //                var tg = new d("17", "Reporting a concern", "#bfbfbf");
    //                Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
    //            }
     //           if (user.Name == "Making Safeguarding Personal")
     //           {
     //               App.app_title = "Making Safeguarding Personal";
     //               var tg = new Making_Safeguarding_Better();

       //             Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
         //       }



       //         if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
                                                    // do something with e.SelectedItem
         //       ((ListView)sender).SelectedItem = null; // de-select the row

           // };
        }
    }
}