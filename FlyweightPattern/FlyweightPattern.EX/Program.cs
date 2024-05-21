using FlyweightPattern.EX;
using FlyweightPattern.EX.Enum;

namespace FlyweightPattern
{
    class program
    {
        static void Main(string[] args)
        {
            IGalaxy star = GalaxyFactory.GetPlanetaryObject(PlanetaryType.star);
            star.SetPosition(50, 70);
            star.SetBrightness(65);
            Console.WriteLine(star);

            IGalaxy planet = GalaxyFactory.GetPlanetaryObject(PlanetaryType.planet);
            planet.SetPosition(80, 100);
            planet.SetBrightness(25);
            Console.WriteLine(planet);

            IGalaxy star2 = GalaxyFactory.GetPlanetaryObject(PlanetaryType.star);
            star.SetPosition(20, 50);
            star.SetBrightness(78);
            Console.WriteLine(star2);

            IGalaxy planet2 = GalaxyFactory.GetPlanetaryObject(PlanetaryType.planet);
            planet.SetPosition(130, 110);
            planet.SetBrightness(32);
            Console.WriteLine(planet2);

            // فقط 2 ابجکت ساخته میشه
            Console.WriteLine(GalaxyFactory.GetCount());
        }
    }
}
//برای اینکه با کمبود حافظه مواجه نشیم مثلا در گیم ها از این الگو استفاده میکنیم 
//در این الگو موارد ثابت رو یک بار کش کردیم یعنی یکبار در حافظه ذخیره میکنیم
//تا هربار نخواهیم همان آبجکت رو دوباره بسازیم
//در اینجا یک سیاره با اندازه مشخص  و یک ستاره با اندازه مشخص داریم
//پس کلا دوتا آبجکت ساخته میشه 
// فقط مقادیر متغیرش که پوزیشن هست تغییر میکنه
