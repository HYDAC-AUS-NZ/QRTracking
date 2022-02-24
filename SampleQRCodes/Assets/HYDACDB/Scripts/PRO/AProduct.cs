using UnityEngine;

using HYDACDB.INFO;

namespace HYDACDB.PRO
{
    public class AProduct : MonoBehaviour
    {
        [SerializeField] protected ProductInfo info = null;
        public ProductInfo Info => info;

        public void SetPartInfo(ProductInfo _info)
        {
#if UNITY_EDITOR
            info = _info;
#endif
        }
    }
}