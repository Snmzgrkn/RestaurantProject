using System.Collections.Generic;
using System.Linq;

namespace Cafe2.Models
{
    public class Cart
    
    {
        private List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }
        public void AddMenu(Menu menu, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Menu.Id == menu.Id);
            if (line==null)
            {
                _cardLines.Add(new CartLine() { Menu =menu,Quantity=quantity});
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeletMenu(Menu menu)
        {
            _cardLines.RemoveAll(i =>i.Menu.Id == menu.Id);
        }

        public double Total() {
            return _cardLines.Sum(i => i.Menu.Price * i.Quantity);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }
    }

    public class CartLine
    {
        public Menu Menu { get; set; }
        public int Quantity { get; set; }

    }
}
