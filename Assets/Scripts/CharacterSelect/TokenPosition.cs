using UnityEngine;

namespace PlayerSetupScripts
{
    public class TokenPosition : MonoBehaviour
    {
        public GameObject[] tokens = new GameObject[8];

        public void SetTokenActives(bool active)
        {
            for (int n = 0; n < 8; n++)
            {
                tokens[n].SetActive(active);
            }
        }
    }
}
