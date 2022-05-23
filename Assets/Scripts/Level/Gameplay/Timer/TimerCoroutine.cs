using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
    public class TimerCoroutine : MonoBehaviour
    {
        public event Action Updated;

        private Coroutine coroutine;


        public void Run()
        {
            coroutine = StartCoroutine(Timer());
        }

        private IEnumerator Timer()
        {
            yield return new WaitForSeconds(1);
            Updated?.Invoke();
            Run();
        }
        
        public void Stop()
        {
            StopCoroutine(coroutine);
        }
    }
}
