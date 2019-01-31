using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace POEApi.Model
{
    [DebuggerDisplay("Type: {Type} Stack: {StackInfo.Amount}/{StackInfo.MaxSize}")]
    public class DivinationCard : StackableItem
    {
        public DivinationCard(JSONProxy.Item item) : base(item)
        {
            ItemType = ItemType.DivinationCard;

            FlavourText = item.FlavourText;
            //ImageURL = String.Format("http://webcdn.pathofexile.com/image/gen/divination_cards/{0}.png", item.ArtFilename);
        }
 
        public List<string> FlavourText { get; set; }
        public String ImageURL { get; set; }
    }
}