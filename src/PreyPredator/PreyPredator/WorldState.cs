using System;
using System.Collections.Generic;
using PreyPredator.Animals;

namespace PreyPredator
{
    public class WorldState
    {
        private readonly WorldSettings _settings;
        private List<IAnimal> _animals;
        private List<IEntity> _entities;

        public WorldState(WorldSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            Initialize();
        }

        public IReadOnlyList<IAnimal> Animals => _animals.AsReadOnly();

        private void Initialize()
        {
            _entities = new List<IEntity>();
            _animals = new List<IAnimal>();
            foreach (IAnimal carnivore in _settings.CarnivorePlacement.PlaceCarnivores())
            {
                _entities.Add(carnivore);
                _animals.Add(carnivore);
            }

            foreach (IAnimal hebivore in _settings.HerbivorePlacement.PlaceHerbivores())
            {
                _entities.Add(hebivore);
                _animals.Add(hebivore);
            }
        }

        public void Tick()
        {
            foreach (IEntity entity in _entities) entity.Tick();
        }
    }
}