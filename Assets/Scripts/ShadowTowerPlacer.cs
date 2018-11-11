using System;
using System.Linq;
using Assets.Core.Extensions;
using Assets.Core.Scripts.Extensions;
using Assets.Scripts.Entities;
using Assets.Scripts.Logic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ShadowTowerPlacer : MonoBehaviour
    {
        [SerializeField] private Tower tower;
        private Tower shadow;
        private bool? wasValid;

        public Tower Tower
        {
            get { return tower; }
            set
            {
                tower = value;
                SetupTower(value);
            }
        }

        private void SetupTower(Tower tower)
        {
            if (shadow) Destroy(shadow.gameObject);
            shadow = Instantiate(tower);
            shadow.GetComponentsInChildren<Behaviour>().ForEach(b => b.enabled = false);
            shadow.GetComponentsInChildren<Collider>().ForEach(Destroy);
            shadow.GetComponentsInChildren<Renderer>()
                .SelectMany(r => r.materials)
                .ForEach(m =>
                {
                    m.SetupMaterialWithBlendMode(MaterialExtensions.Mode.Transparent);
                });
            shadow.transform.SetParent(transform);
            shadow.transform.localPosition = Vector3.zero;
        }

        private void Update()
        {
            var placementRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            var point = placementRay.Intersect();
            if (point.HasValue == false) return;

            transform.position = point.Value.Snap(.5f, offset: .25f);

            var groundRay = new Ray(transform.position + Vector3.up, Vector3.down);
            var raycastHit = groundRay.RaycastHit();
            if (raycastHit.HasValue == false) return;

            var hitObject = raycastHit.Value.transform.gameObject;

            transform.position = transform.position.SetY(raycastHit.Value.point.y);

            Valid = hitObject.layer == LayerMask.NameToLayer("Ground");

            shadow.GetComponentsInChildren<Renderer>()
                .SelectMany(r => r.materials)
                .ForEach(m =>
                {
                    var color = m.color;
                    if (wasValid != null)
                    {
                        color = wasValid.Value
                            ? new Color(color.r, color.g - .5f, color.b, .3f)
                            : new Color(color.r - .5f, color.g, color.b, .3f);
                    }
                    m.color = Valid
                        ? new Color(color.r, color.g + .5f, color.b, .3f)
                        : new Color(color.r + .5f, color.g, color.b, .3f);
                });

            wasValid = Valid;
        }

        public bool Valid { get; private set; }
    }
}