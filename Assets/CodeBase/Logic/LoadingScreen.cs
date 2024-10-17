using System.Collections;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Logic
{
    public class LoadingScreen : MonoBehaviour
    {
        public Image screen ;
        private void Awake() => 
            DontDestroyOnLoad(this);

        public void Show() => 
            gameObject.SetActive(true);

        public void Hide()
        {
            screen.DOFade(0, 3f).OnComplete(() =>
                gameObject.SetActive(false));
        }

    }
}
