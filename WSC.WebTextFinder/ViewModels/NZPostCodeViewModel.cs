using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSC.WebTextFinder.Core;

namespace WSC.WebTextFinder.ViewModels {
    public class NZPostCodeViewModel : ViewModelBase {
    }
    public class NZRegion {
        public string Name { get; set; }
        public string UrbanPostCodes { get; set; }
        public string RuralPostCodes { get; set; }
    }
    public enum Island {
        North,
        South,
        Other
    }
}
