using Microsoft.AspNetCore.Mvc.Rendering;

namespace IZavarykInIA.Models
{
    public class ProductViewModel
    {
            public Product Product { get; set; }
            public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
