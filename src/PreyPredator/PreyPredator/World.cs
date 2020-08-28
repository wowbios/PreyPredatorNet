using System;
using System.Collections.Generic;
using PreyPredator.Animals;
using PreyPredator.Exceptions;

namespace PreyPredator
{
    public class World
    {
        private static readonly World _instance = new World();

        private World() { }

        public WorldState State { get; private set; }

        public void Tick()
        {
            if (State is null)
                throw new WorldException("Мир не инициализирован");

            State.Tick();
        }

        public void Initialize(WorldSettings settings)
        {
            Reset();
            State = new WorldState(settings);
        }

        private void Reset()
        {
            State = null;
        }

        public static World Instance => _instance;
    }
}