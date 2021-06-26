using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> skiData;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get { return skiData.Count; } }

        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            skiData = new List<Ski>();
        }

        public void Add(Ski ski)
        {
            if (skiData.Count < Capacity)
            {
                skiData.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Ski ski = skiData.FirstOrDefault(s => s.Model == model && s.Manufacturer == manufacturer);

            if (ski != null)
            {
                skiData.Remove(ski);
                return true;
            }

            return false;
        }

        public Ski GetNewestSki()
        {
            List<Ski> newestSkiList = skiData.OrderByDescending(s => s.Year).ToList();
            Ski newestSki = newestSkiList.FirstOrDefault();

            if (newestSki != null)
            {
                return newestSki;
            }

            return null;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            Ski currentSki = skiData.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
            if (currentSki != null)
            {
                return currentSki;
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");

            foreach (var ski in skiData)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
