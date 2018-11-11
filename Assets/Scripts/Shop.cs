using System.Linq;
using Assets.Core.Extensions;
using Assets.Scripts.Entities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class Shop : MonoBehaviour
    {
        [SerializeField] private TowerUpgrade[] defaultUpgrades;
        [SerializeField] private ShopTile tilePrefab;
        [SerializeField] private Transform tileGrid;
        private ShadowTowerPlacer shadow;
        private TowerUpgrade upgrade;
        private Tower selectedTower;

        private void Start()
        {
            ShowUpgrades(defaultUpgrades);
        }

        private void ShowUpgrades(TowerUpgrade[] towerUpgrades)
        {
            tileGrid.RemoveAllChildren();

            foreach (var defaultUpgrade in towerUpgrades)
            {
                var tile = Instantiate(tilePrefab);
                tile.Item = defaultUpgrade.tower;
                tile.Enabled = FindObjectOfType<Player>().Money >= defaultUpgrade.price;
                tile.OnClick += tower => ShowTower(defaultUpgrade);
                tile.transform.SetParent(tileGrid, false);
            }
        }

        private void ShowTower(TowerUpgrade upgrade)
        {
            if (selectedTower)
            {
                var transformPosition = selectedTower.transform.position;
                DestroyImmediate(selectedTower.gameObject);
                var tower = BuiildTower(upgrade, transformPosition);
                return;
            }

            if (shadow) DestroyImmediate(shadow.gameObject);
            shadow = new GameObject("Shadow Tower Place").AddComponent<ShadowTowerPlacer>();
            shadow.Tower = upgrade.tower;
            this.upgrade = upgrade;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && IsPointerOverGameObject() == false)
            {
                if (shadow && shadow.Valid)
                {
                    var tower = BuiildTower(upgrade, shadow.transform.position);
                    DestroyImmediate(shadow.gameObject);
                }
                else
                {
                    var allHits = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition));
                    var tower = allHits.FirstOrDefault(h => h.transform.GetComponent<Tower>()).transform;
                    if (tower)
                    {
                        selectedTower = tower.GetComponent<Tower>();
                        ShowUpgrades(selectedTower.Upgrades);
                    }
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                selectedTower = null;
                ShowUpgrades(defaultUpgrades);
                if(shadow) DestroyImmediate(shadow.gameObject);
            }
        }

        private Tower BuiildTower(TowerUpgrade upgrade, Vector3 position)
        {
            print(upgrade.tower);
            var tower = Instantiate(upgrade.tower);
            FindObjectOfType<Player>().Money -= upgrade.price;
            tower.transform.position = position;
            selectedTower = tower;
            ShowUpgrades(selectedTower.Upgrades);
            return tower;
        }

        private static bool IsPointerOverGameObject()
        {
#if !UNITY_EDITOR && (UNITY_ANDROID || UNITY_IPHONE)
        const int fingerId = 0;
#else
            const int fingerId = -1;
#endif

            return EventSystem.current.IsPointerOverGameObject(fingerId);
        }
    }
}