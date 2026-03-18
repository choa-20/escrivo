using UnityEngine;

public class BotoesBh : MonoBehaviour
{
    public GameObject ledRed;
    public GameObject ledGreen;
    public GameObject ledPurple;
    public GameObject panel1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Btnl()
    {
        print("reversão");
        ledRed.SetActive(!ledRed.activeSelf); //pega o nome de referência e deixa desativado da forma mais brutal possível
    }
     public void Btnl2()
    {
        print("lapso");
        ledGreen.SetActive(!ledGreen.activeSelf);
    }
    public void BtnClose()  
    {
        panel1.SetActive(false);
    }
    public void Btn3()
    {
        print("roxo");
        ledPurple.SetActive(!ledPurple.activeSelf);
    }
    public void Btn4()
    {
        print("vazio");

    }
}
