using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace CompiledBinding_AnniversaryEdition_Sample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        #region 01 - Function binding

        public DateTime Today = DateTime.Now;

        public Person Roberts = new Person()
        {
            Firstname = "Dread Pirate",
            Lastname = "Roberts"
        };

        public string GetHelloWorld()
        {
            return "Hello World";
        }

        #endregion

        #region 02 - Dictionary indexers

        public Dictionary<string, string> Dictionary = new Dictionary<string, string>()
        {
            { "A", "Alpha" },
            { "B", "Beta" },
            { "C", "Charlie" },
        };

        #endregion

        #region 03 - Explicit value cast

        public AClass A = new BClass();
        public bool? IsThreeStateNull = null;
        public bool? IsThreeStateFalse = false;
        public bool? IsThreeStateTrue = true;

        #endregion

        #region 04 - Implicit Visibility conversion

        public bool IsVisibleFalse = false;
        public bool IsVisibleTrue = true;

        #endregion
    }
}
