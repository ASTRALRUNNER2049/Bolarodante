using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SocialCredit : MonoBehaviour
{
    private float Totalcredit;
    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = Totalcredit.ToString("0");
    }

    public void SumarSocialCredit(float socialCredit)
    {
        Totalcredit += socialCredit;
    }
}
