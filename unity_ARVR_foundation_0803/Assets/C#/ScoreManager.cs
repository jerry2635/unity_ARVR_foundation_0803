using UnityEngine;
using TMPro;
namespace jerry
{
    /// <summary>
    /// ���ƺ޲z
    /// </summary>
    public class ScoreManager : MonoBehaviour
    {
        private string nameBasketball = "�x�y";
        private TextMeshProUGUI textScore;
        private int addScore = 2;
        private int totalScore;

        private void Awake()
        {
            textScore = GameObject.Find("����").GetComponent<TextMeshProUGUI>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameBasketball))
            {
                AddScore();
            }
        }

        private void AddScore()
        {
            totalScore += addScore;
            textScore.text = "SCORE" + totalScore;
        }
        /// <summary>
        /// �ܧ����
        /// </summary>
        /// <param name="scoreTochange"></param>
        private void ChangeScore(int scoreTochange)
        {
            addScore = scoreTochange;
        }
    }
}

