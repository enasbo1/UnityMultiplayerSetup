using UnityEngine;

namespace Script
{
    public class Test1 : MonoBehaviour
    {
        [SerializeField] public int num;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(num);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
