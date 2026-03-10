using UnityEngine;
using TMPro; //biblioteca de texto avançado

public class GameController : MonoBehaviour
{

    public TMP_Text caixaDeTexto;
    

    public void AvançarHistoria()
    {
        caixaDeTexto.text = "A escuridão sorriu para mim e eu... Gelei";
        
    }

}
