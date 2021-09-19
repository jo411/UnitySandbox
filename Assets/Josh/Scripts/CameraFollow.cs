using UnityEngine;
namespace Josh
{
    public class CameraFollow : MonoBehaviour
    {

        public Transform target;
        public float moveSpeed;
        public Vector3 offset;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 targetOffsetPos = target.position + offset;
            transform.position = Vector3.LerpUnclamped(transform.position, targetOffsetPos, Time.deltaTime * moveSpeed);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(target.position, target.position + offset);
        }

    }
}

