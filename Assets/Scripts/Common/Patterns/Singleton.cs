using UnityEngine;

namespace Cooking
{
    public abstract class Singleton<T> : MonoBehaviour
        where T : MonoBehaviour
    {
        public static T instance;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(this);
            }
            else
            {
                instance = GetComponent<T>();
            }
        }
    }
}