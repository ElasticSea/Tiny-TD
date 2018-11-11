using Assets.Scripts.Entities;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Ui : MonoBehaviour
    {
        [SerializeField] private Tower tower;
        [SerializeField] private Player player;
        [SerializeField] private Text moneyText;
        private ShadowTowerPlacer shadow;

        // TODO remove
        private void Awake()
        {
            shadow = new GameObject("Shadow Tower Place").AddComponent<ShadowTowerPlacer>();
            shadow.Tower = tower;
        }

        private void Update()
        {
            moneyText.text = $"{player.Money}$";

            if (shadow.Valid && Input.GetMouseButtonDown(0))
            {
                var tower = Instantiate(shadow.Tower);
                tower.transform.position = shadow.transform.position;
            }
        }
    }
}