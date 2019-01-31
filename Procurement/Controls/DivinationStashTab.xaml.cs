using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using POEApi.Model;
using Procurement.ViewModel.Filters;

namespace Procurement.Controls
{
    /// <summary>
    /// Interaction logic for DivinationStash.xaml
    /// </summary>
    public partial class DivinationStashTab : AbstractStashTabControl
    {
        private DivinationStashViewModel viewModel;

        public DivinationStashTab()
        {
            InitializeComponent();
        }

        public DivinationStashTab(int tabNumber)
        {
            TabNumber = tabNumber;

            var stash = ApplicationState.Stash[ApplicationState.CurrentLeague];

            var items = stash.GetItemsByTab(tabNumber);

            viewModel = new DivinationStashViewModel(items, stash.Tabs.First(x => x.i == tabNumber).Cards);

            DataContext = viewModel;

            InitializeComponent();

            SetPremiumTabBorderColour();
        }

        public DivinationStashTab(int tabNumber, List<IFilter> filters) : this(tabNumber)
        {
            Filters = filters;
        }

        public override Border Border => LocalBorder;
    }

    public class DivinationStashViewModel
    {
        public DivinationStashViewModel(List<Item> items, List<string> allCards)
        {
        }
    }
}
