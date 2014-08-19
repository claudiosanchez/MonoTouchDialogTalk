using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using iOS.Data;
using MonoTouch.Dialog;
using MonoTouch.Dialog.Utilities;
using MonoTouch.UIKit;

namespace iOS
{
    public class InfluencersController : DialogViewController
    {
        public InfluencersController(RootElement root) : base(root)
        {
            EnableSearch = true;
        }

        public override async void ViewDidLoad()
        {

            var localData =   DataManager.GetTopInfluencers();

            var client = new WebDataHelper<IEnumerable<Influencer>>();
            var list = await client.GetData("http://50.19.213.136:8080/skills-devdom/api/influencer/top/general.json");

            
            var firstSection = new Section("Coolest Dev")
            {
                new BadgeElement(UIImage.FromBundle("me.jpg"), "Claudio Sanchez"),
            
            };

            var section = new Section("Top 20") ;
            
            Root.Add(firstSection);
            Root.Add(section);

            foreach (var influencer in list)
            {
                var image = await  ImageHelper.LoadImage(influencer.picture);
                var element = new BadgeElement(image, string.Format ("[{0}] {1}",influencer.position,influencer.fullName));
                section.Add(element);
            }

           

        }

        public InfluencersController(UITableViewStyle style, RootElement root) : base(style, root)
        {
        }
    }
}