using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUEgyptExcavation.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Burial> Burial { get; set; }

        public PageNumberingInfo PageNumberingInfo { get; set; }
    }
}
