using System;
using PreyPredator.Generation;

namespace PreyPredator
{
    public class WorldSettings
    {
        public WorldSettings(
            ICarnivorePlacement carnivorePlacement,
            IHerbivorePlacement herbivorePlacement)
        {
            CarnivorePlacement = carnivorePlacement
                ?? throw new ArgumentNullException(nameof(carnivorePlacement));
            HerbivorePlacement = herbivorePlacement
                ?? throw new ArgumentNullException(nameof(herbivorePlacement));
        }

        public ICarnivorePlacement CarnivorePlacement { get; }

        public IHerbivorePlacement HerbivorePlacement { get; }
    }
}