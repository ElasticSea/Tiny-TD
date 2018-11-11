using System;
using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    public class TowerUpgrade
    {
        public Tower tower;
        public int price;
    }
}