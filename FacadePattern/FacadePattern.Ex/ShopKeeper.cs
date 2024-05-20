using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Ex
{
    public class ShopKeeper
    {
        private IMobileShop iphon;
        private IMobileShop samsung;
        private IMobileShop motorola;

        public ShopKeeper()
        {
            iphon = new IPhon();
            samsung = new Samsung();
            motorola = new Motorola();
        }

        public void IPhonSale()
        {
            iphon.ModelNo();
            iphon.Price();
        }
        public void SamsungSale()
        {
            samsung.ModelNo(); 
            samsung.Price();
        }
        public void MotorolaSale()
        {
            motorola.ModelNo();
            motorola.Price();
        }
    }
}