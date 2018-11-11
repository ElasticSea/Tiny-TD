using System;
using System.Collections.Generic;
using Assets.Scripts.Entities;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class Wave
    {
        private readonly HashSet<Creep> creeps = new HashSet<Creep>();

        public event Action OnDeath = () => { };

        public void Add(Creep c)
        {
            creeps.Add(c);
            c.OnPathFinished += () =>
            {

            };
            c.GetComponent<Health>().OnDeath += () =>
            {
                GameObject.FindObjectOfType<Player>().Money += c.Money;
                creeps.Remove(c);
                if (creeps.Any() == false)
                {
                    OnDeath();
                }
            };
        }
    }
}