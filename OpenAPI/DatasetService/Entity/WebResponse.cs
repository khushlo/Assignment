using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace DatasetService
{
    public class WebResponse
    {
        public List<Cheese> CheeseDirectory { get; set; }
        public WebResponse()
        {

        }
        public WebResponse(List<Cheese> lstData)
        {
            this.CheeseDirectory = lstData;
        }
    }
}
