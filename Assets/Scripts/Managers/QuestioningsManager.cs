using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class Questions : System.IEquatable<Questions> {
    public int id;

    //adicionar os sprites correspondentes a cada questão
    //IMPORTANTE

    [Multiline]
    public string question;

    //public int wavesNumber = 4;

    public int[] rightAnswers;  //precisaremos de 4 respostas certas
    public int[] wrongAnswers;  //precisaremos de 12 respostas erradas

    public override bool Equals(object obj) {
        if(obj == null)
            return false;

        Questions quest = obj as Questions;

        if(quest == null)
            return false;
        else
            return Equals(quest);
    }

    public override int GetHashCode() {
        return id;
    }

    public bool Equals(Questions other) {
        if(other == null)
            return false;
        return (this.id.Equals(other.id));
    }
}

// Banco de Perguntas e de Sprites (um é o certo)
public class QuestioningsManager : MonoBehaviour {

    /*                0      1        2        3         4
        sprites = { Zezim, Huguim, Chiquim, Marquim, Soniquim }
        questionings = { quem é o mais gordim?, quem é o mais doidim?, quem é o mais magrim?, quem é o mais avoadim?, quem é o mais baixim? }
        answers = {  0,        4,        3,     2,        0   }
    */

    public Sprite[] sprites;

    public Button[] buttons;
    public Text description;
    public Image timer;

    public List<Questions> questions;

    public int currentQuestion;

    public int correctButton;

    void Start() {
        GenerateWaves();
        description.text = questions[currentQuestion].question;
    }

    public void GenerateWaves() {
        currentQuestion = Random.Range(0, questions.Count);

        correctButton = Random.Range(0, buttons.Length);

        List<int> tempSprites = new List<int>(sprites.Length - 1);

        for(int i = 0; i < questions[currentQuestion].wrongAnswers.Length; i++) {
            tempSprites.Add(questions[currentQuestion].wrongAnswers[i]);
        }

        for(int i = 0; i < buttons.Length; i++) {
            if(i == correctButton) {
                buttons[i].image.sprite = sprites[questions[currentQuestion].rightAnswers[Random.Range(0, questions[currentQuestion].rightAnswers.Length)]];
            }
            else {
                int tmp = Random.Range(0, tempSprites.Count);
                buttons[i].image.sprite = sprites[tempSprites[tmp]];

                tempSprites.RemoveAt(tmp);
            }
        }

        //questions[currentQuestion].wavesNumber--;
    }

    public void ContinueWave() {
        //if(questions[currentQuestion].wavesNumber > 0) {

            correctButton = Random.Range(0, buttons.Length);

            List<int> tempSprites = new List<int>(sprites.Length - 1);

            for(int i = 0; i < questions[currentQuestion].wrongAnswers.Length; i++) {
                tempSprites.Add(questions[currentQuestion].wrongAnswers[i]);
            }

            for(int i = 0; i < buttons.Length; i++) {
                if(i == correctButton) {
                    buttons[i].image.sprite = sprites[questions[currentQuestion].rightAnswers[Random.Range(0, questions[currentQuestion].rightAnswers.Length)]];
                }
                else {
                    int tmp = Random.Range(0, tempSprites.Count);
                    buttons[i].image.sprite = sprites[tempSprites[tmp]];

                    tempSprites.RemoveAt(tmp);
                }
            }

            //questions[currentQuestion].wavesNumber--;
        //}
    }
    public void GameOver() {
        Debug.Log("you lose");
    }

    public void CheckIfScores(int id) {
        if(id == correctButton) {
            ContinueWave();
        }
        else {
            GameOver();
        }
    }
}