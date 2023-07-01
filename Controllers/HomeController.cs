using HatsAplpication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HatsApplication.Controllers
{
    public class HomeController : Controller
    {
        List<Hat> hats = new List<Hat>()
        {
            new Hat() { ImgURL= @"https://www.sportsdirect.com/images/products/39188403_l.jpg", Id=0, Brand="Nike", Description="Sportswear", Gender="Unisex", Name="Nike Sportswear Heritage86", Price=20},
            new Hat() { ImgURL = @"https://th.bing.com/th/id/OIP.7d1Tq2pUitKRr0W9wDk1rAHaKu?pid=ImgDet&w=759&h=1100&rs=1", Id = 1, Brand = "Adidas", Description = "Sportswear", Gender = "Female", Name = "RELAXED MINI LOGO HAT", Price = 28 },
            new Hat() {
            ImgURL = @"https://th.bing.com/th/id/R.6db45c986c1dcf23c7ed259d8aadc9fe?rik=7QbfTe7y9aiiHQ&riu=http%3a%2f%2fpumaecom.scene7.com%2fis%2fimage%2fPUMAECOM%2f896433_03_01_PNA%3fwid%3d1000&ehk=zGpajHNSIxTmBerlxCwI8u30SWvLUC1onK353Sa9TZo%3d&risl=&pid=ImgRaw&r=0",
            Id = 2, Brand = "Puma", Description = "Sportswear", Gender = "Male", Name = "Essentials No.1 Cap", Price = 15 },
            new Hat() { ImgURL= @"https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/b9ceb18f-2a64-4cf5-9452-14c64c19df17/sportswear-classic-99-cap-L20MMR.png", Id=3, Brand="Nike", Description="Sportswear", Gender="Male", Name="Nike Sportswear Classic 99", Price=19},
            new Hat() { ImgURL=@"https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/4a39eede-1625-49e0-883e-7a1b44ed5d1c/jordan-pro-jumpman-snapback-hat-LqGxfx.png", Id=4 ,Brand="Nike",Description="Sportswear",Gender="Male", Name="Jordan Pro Jumpman",Price=32 },
            new Hat() { ImgURL=@"https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/48c4e5c4-7531-4d8e-b148-234d8fd93ef0/heritage86-washed-golf-hat-jM4T9q.png", Id=5,Brand="Nike",Description="Sportswear",Gender="Unisex", Name="Nike Heritage86",Price=22 },
            new Hat() { ImgURL=@"https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/747109fb-9476-4770-9a36-b7c3b60f5f3d/aerobill-classic99-printed-golf-hat-65z8cS.png", Id=6,Brand="Nike",Description="Sportswear",Gender="Female", Name="Nike AeroBill Classic99",Price= 34},
            new Hat() { ImgURL=@"https://assets.adidas.com/images/w_383,h_383,f_auto,q_auto,fl_lossy,c_fill,g_auto/4e56d9155c4d4cf996eaaefa015564de_9366/lifestyle-washed-bucket-hat.jpg", Id=7,Brand="Adidas",Description="Sportswear",Gender="Male", Name="LIFESTYLE WASHED BUCKET HAT",Price=18 },
            new Hat() { ImgURL=@"https://assets.adidas.com/images/w_383,h_383,f_auto,q_auto,fl_lossy,c_fill,g_auto/ebf77fbab36e48e494d6af4a007344eb_9366/ultimate-hat.jpg", Id=8,Brand="Adidas",Description="Sportswear",Gender="Unisex", Name="ULTIMATE HAT",Price=12 },
            new Hat() { ImgURL=@"https://assets.adidas.com/images/w_383,h_383,f_auto,q_auto,fl_lossy,c_fill,g_auto/046c2c1b30fa451a8e50af430162c1d1_9366/python-bucket-hat.jpg", Id=9,Brand="Adidas",Description="Sportswear",Gender="Female", Name="SNAKE GRAPHIC BASEBALL CAP",Price=35 },
            new Hat() { ImgURL=@"https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_1350,h_1350/global/024363/04/fnd/PNA/fmt/png/Core-Bucket-Hat", Id=10,Brand="Puma",Description="Sportswear",Gender="Female", Name="Core Bucket Hat",Price=23 },
            new Hat() { ImgURL=@"https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_500,h_500/global/927423/36/fnd/PNA/fmt/png/PUMA-#1-Relaxed-Fit-Adjustable-Hat", Id=11,Brand="Puma",Description="Sportswear",Gender="Male", Name="PUMA #1 Relaxed Fit Adjustable Hat",Price=20 },
            new Hat() { ImgURL=@"https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_500,h_500/global/023754/02/fnd/PNA/fmt/png/Neymar-Jr-Baseball-Football-Cap", Id=12,Brand="Puma",Description="Sportswear",Gender="Unisex", Name="Neymar Jr Baseball Football Cap",Price=25 }
        };
        List<HatsDetails> details = new List<HatsDetails>()
        {
            new HatsDetails(){ Id=0,Code=1234, Color="black", Description="Classic and comfortable, the Nike Sportswear Heritage86 Cap features a 6-panel design made from twill fabric and an adjustable closure for a snug, secure fit.This 6-panel design features an unstructured, low-profile crown, curved brim and adjustable strapback closure.\r\nThe embroidered Futura logo on the crown adds texture and an elevated look. The metal closure on the strap features a small Swoosh detail.", Material="polyester", Size="ONE SIZE"},
            new HatsDetails(){ Id=1,Code=567, Color="pink", Description="Tiny Trefoil. Big style. Show off an adidas icon when you slip on this cotton hat. Wear it all day or toss it in your bag for later. Either way, you're covered.", Material="cotton", Size="ONE SIZE"},
            new HatsDetails(){ Id=2,Code=890, Color="dark blue", Description="Meet our Essentials No.1 baseball cap – a timeless sporting staple look that's perfect for everyday wear.", Material="cotton", Size="ONE SIZE"},
            new HatsDetails(){ Id=3,Code=486, Color="blue", Description="Updating the classic silhouette, the Nike Sportswear Classic 99 Trucker features our classic graphic embroidered on the front panel and an adjustable snapback closure.", Material="cotton", Size="ONE SIZE"},
            new HatsDetails(){ Id=4, Code=187, Color="black", Description="Show them your hops in the Jordan Pro Jumpman Snapback Hat. It has a flat bill and high structured crown made from tightly woven twill. The iconic logo is thickly embroidered on the front, a bold projection of the Brand's heritage. This product is made with at least 50% recycled polyester fibers.", Material="polyester", Size="ONE SIZE"},
            new HatsDetails(){ Id=5, Code=529, Color="white", Description="The Nike Heritage86 Hat tops off your look with supersoft fabric that's been through a heavy wash—creating a worn-in feel. Plus, a green underbill nods to vintage headwear.", Size="ONE SIZE", Material="cotton"},
            new HatsDetails(){ Id=6, Code=820, Color="pink", Description="Argyle is to golf what big belt buckles and hats are to rodeo. The Nike AeroBill Classic99 Hat brings a piece of that history back to the course in a stretchy, sweat-wicking design that keeps you comfortable round after round.", Material="polyester", Size="ONE SIZE"},
            new HatsDetails(){ Id=7, Code=162, Color="black", Description="THIS SOFT BUCKET HAT IS MADE WITH A CONTRASTING UNDERVISOR. A stylish way to stay under shade. This adidas bucket hat is made from cotton for a naturally airy feel. The moisture-wicking sweatband keeps you comfortable when you take your sweat session outdoors.", Material="cotton", Size="ONE SIZE"},
            new HatsDetails(){ Id=8, Code=710, Color="grey", Description="Keep it comfortable. Keep it classic. A trusty cap never goes out of style. Head to the game or hang with friends, no matter what's on your schedule, this hat keeps you covered with a comfy cotton build and a moisture-wicking sweatband. An embroidered adidas Badge of Sport on the front keeps your look legit.", Size="ONE SIZE", Material="cotton"},
            new HatsDetails(){ Id=9, Code=498, Color="grey", Description="Impression made. The snakeskin print on this adidas baseball cap instantly steps up whatever you wear it with, whether that's sweats, a bodycon dress or a blazer. Both casual and statement-making, it's an undeniably confident vibe.", Material="polyester", Size="ONE SIZE"},
            new HatsDetails(){ Id=10, Code=109, Color="pink", Description="Bucket hats are back and they're better than ever. This version stays true to the style, with a branded patch on the front and a contrast under brim.", Material="cotton", Size="ONE SIZE"},
            new HatsDetails(){ Id=11, Code=378, Color="orange", Description="PUMA's accessory styles are designed to top off your look. Comfy socks, sweet hats, awesome backpacks, we've got top-trending and high quality styles for everyone.", Material="cotton", Size="ONE SIZE"},
            new HatsDetails(){ Id=12, Code=611, Color="white", Description="A good baseball cap should be lightweight, comfortable and have a head-turning design. Luckily, this Neymar Jr Baseball Cap ticks all the boxes. Featuring contrast colour blocking, the PUMA Cat Logo and Neymar Jr's iconic logo, it's the perfect way to top off any casual outfit. Design inspired by Neymar Jr logo and iconic Brazilian colors. Neymar Jr logo at front and center. PUAM Cat Logo at left side", Material="cotton", Size="ONE SIZE"}
        };

        // GET: Hats
        public ActionResult Index()
        {

            return View(hats);
        }
        public ActionResult Details(int id)
        {
            var model2 = details.ElementAt(id);
            model2.hat = hats.ElementAt(id);
            return View(model2);

        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}