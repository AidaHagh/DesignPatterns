using FlyweightPattern.EX.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern.EX
{
    public class GalaxyFactory
    {
        private static Dictionary<PlanetaryType,IGalaxy> planetaryObjects=new Dictionary<PlanetaryType, IGalaxy> ();
       public static IGalaxy GetPlanetaryObject(PlanetaryType planetaryType)
        {
            if (planetaryObjects.ContainsKey(planetaryType))
            {
                return planetaryObjects[planetaryType];
            }
            else
            {
                IGalaxy newObject = null;
                if (planetaryType== PlanetaryType.star)
                {
                    newObject = new Star();
                    planetaryObjects.Add(PlanetaryType.star, newObject);
                }
                else
                {
                    newObject = new Planet();
                    planetaryObjects.Add(PlanetaryType.planet, newObject);
                }
                return newObject;
            }
        }

        public static int GetCount()
        {
            return planetaryObjects.Count();
        }
    }
}