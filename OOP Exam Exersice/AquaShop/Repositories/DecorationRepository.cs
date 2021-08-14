using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System.Collections.Generic;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private IReadOnlyCollection<IDecoration> models;
        public IReadOnlyCollection<IDecoration> Models 
        {
            get 
            {
                return models;
            } 
            private set 
            {
                models = value;
            } 
        }

        public void Add(IDecoration decoration)
        {
            List<IDecoration> tempModels = new List<IDecoration>(Models);
            tempModels.Add(decoration);
            Models = tempModels;
            
        }

        public IDecoration FindByType(string type)
        {
            List<IDecoration> tempModels = new List<IDecoration>(Models);
            IDecoration output = null;

            foreach (var item in tempModels)
            {
                if (item.GetType().Name == type)
                {
                    output = item;
                    break;
                }
            }

            return output;
            
        }

        public bool Remove(IDecoration decoration)
        {
            bool removeSucessful = false;
            List<IDecoration> tempModels = new List<IDecoration>(Models);
            if (tempModels.Remove(decoration))
            {
                removeSucessful = true;
                Models = tempModels;
            }

            return removeSucessful;
        }
    }
}
