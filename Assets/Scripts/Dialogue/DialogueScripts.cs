using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScripts : MonoBehaviour
{
    DialogueSystem dialogue;
    public GameObject starterPanel;
    public AudioSource gamelanSource;
    public string[] s;
    public Sprite[] playerBoy = new Sprite[22];
    public Sprite[] playerGirl = new Sprite[22];
    public Sprite[] tak = new Sprite[22];
    public Sprite[] dah = new Sprite[22];
    public string username;
    public string gender;
    public Image takImage;
    public Image dahImage;
    public Image myImage;
    int index = 0;
    void Start()
    {
        dialogue = DialogueSystem.instance;
        username = PlayerPrefs.GetString("username");
        gender = PlayerPrefs.GetString("gender");
        s = new string[]{
        "Hmmmm…. X kuadrat ditambah 2y….. Ohhh!! Ketemu jawabannya! Akhirnya satu nomor lagi dan tugas ini selesaiiii!!!:"+ username +"",
        "Astaga, sudah jam segini.. Aku harus cepat cepat pulang!",
        "***terburu buru menuju gerbang:  ",
        "Aduhhhh, kenapa buku tugasku belum aku masukkan ke tas, mana tugasnya buat kelas pagi besok..:"+ username +"",
        "***setengah berlari ke kelas:  ",
        "  :  ",
        "Eh? Siapa yang bermain musik di jam segini… Arahnya dari ruang kesenian, coba aku liat dulu:"+ username +"",
        "***menari mengikuti irama musik gamelan: Tak&Dah",
        "EH??!!:Semua",
        "J-jangan takut! Kami bukan makhluk jahat kok!:Dah",
        "B-benarkah?:"+ username +"",
        "Iya benar! Perkenalkan namaku Dah, dan ini temanku Tak. Maaf sepertinya kami mengagetkanmu, kami sedang menghibur hati kami yang sedih:Dah&Tak",
        "Sedih? Apa yang terjadi?:"+ username +"",
        "Kami merasa kesepian karena di sini jarang sekali ada yang mau memainkan gamelan, dulu gamelan masih sempat diajarkan saat pelajaran, namun sekarang gamelan hanya jadi ekstrakulikuler saja itupun tidak banyak yang ikut. Kami juga pernah dengar anak anak melewati kami dengan tatapan aneh dan mengatakan bahwa kami kuno:Dah",
        "….:"+ username +"",
        "Kalau begitu, maukah kalian mengajariku tentang gamelan? Dari melodinya terdengar menyenangkan!",
        "Kamu mau belajar tentang gamelan?!:Tak",
        "Tentu saja!:"+ username +"",
        "Kalau begitu Tak akan menjelaskan apa itu gamelan!:Dah",
        "Gamelan adalah musik ansambel tradisional Jawa, Sunda, Bali dan Lombok di Indonesia yang memiliki tangga nada pentatonis dalam sistem tangga nada yang disebut laras slendro dan pelog:Tak",
        "Untuk instrument atau alat musiknya sendiri biasanya terdiri dari Bonang Barung, Bonang Panerus, Demung, Saron, Peking, Slenthem, Kempul, Kendhang, dan Gong. Untuk instrumen lain ada xilofon berupa gambang, aerofon berupa seruling, kordofon berupa rebab, dan kelompok vokal disebut sindhen",
        "Jadi bagaimana? Maukah kamu bermain gamelan bersama kami?:Dah",
        "Aku siap kapanpun!:"+ username +"",
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            starterPanel.SetActive(false);
            if (!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
            {
                if(index >= s.Length)
                {
                    SceneManager.LoadScene("LevelSelect");
                } 
                if(index == 5){
                    gamelanSource.Play();
                } else if(index > 5){
                    gamelanSource.Stop();
                }
                takImage.sprite = tak[index];
                dahImage.sprite = dah[index];
                if(gender.Equals("boy")){
                    myImage.sprite = playerBoy[index];
                } else if(gender.Equals("girl")){
                    myImage.sprite = playerGirl[index];
                }
                Say(s[index]);
                index++;
            }
        }
    }

    void Say(string s){
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.Say(speech, speaker);
    }
}
