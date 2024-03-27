using System;
using UnityEngine;

namespace RotatingStuff
{
    public class ActivateChildOnOrientation : MonoBehaviour
    {
        public Vector3 activationWorldUpAxis;
        public float activationRange;
        private bool lastActiveState;
        private Animator _animator;
        private void Start()
        {
            _animator = GetComponent<Animator>();
            lastActiveState = false;
            SetChildrenActive(false);
            
        }

        void Update()
        {
            //Get the angle between our up axis and the activation world angle.
            bool shouldBeActive = ShouldBeActive();
            if (shouldBeActive != lastActiveState)
            {
                lastActiveState = shouldBeActive;
                SetChildrenActive(shouldBeActive);
            }
        }

        private bool ShouldBeActive()
        {
            float angle = Vector3.Angle(transform.up, activationWorldUpAxis);
            return angle <= activationRange;
        }

        private void SetChildrenActive(bool active)
        {
            _animator.SetBool("active",active);
            // foreach (Transform child in transform)
            // {
            //     child.gameObject.SetActive(active);
            // }
        }
    }
}