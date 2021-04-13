using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUEgyptExcavation.Models.ViewModels
{
    //view model for burial data, page numbering, and filtering
    public class IndexViewModel
    {
        public IEnumerable<Burial> Burial { get; set; }

        public PageNumberingInfo PageNumberingInfo { get; set; }

        public Filters FilteringData { get; set; }

    }

}
