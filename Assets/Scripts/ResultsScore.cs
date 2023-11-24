using UnityEngine.UI;
using UnityEngine;

public class ResultsScore : MonoBehaviour
{
    public Text _result;
    [SerializeField] private Transform _playerTransform;
   
    private void Update()
    {
        _result.text = transform.position.z.ToString();
    }
}
