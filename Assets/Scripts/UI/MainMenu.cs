using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class MainMenu : MonoBehaviour
    {

        [SerializeField] private RectTransform _bottomTier, _topTier;

        private void Awake()
        {
            RectTransformExtensions.SetTop(_bottomTier, Screen.height * (1f/3f));
            RectTransformExtensions.SetBottom(_topTier, Screen.height * (2f/3f));

        }
    }
}

