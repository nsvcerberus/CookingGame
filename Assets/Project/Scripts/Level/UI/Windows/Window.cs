using UnityEngine;

namespace Cooking.Level.UI
{
    public abstract class Window : MonoBehaviour
    {
        protected RectTransform rectTransform;

        protected virtual void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
        }
    }
}