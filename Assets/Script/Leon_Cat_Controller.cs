using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leon_Cat_Controller : MonoBehaviour
{
    public List<Texture> jacketTextures = new List<Texture>();
    public Material jacketMaterials;
    int currentTextureIndex = 0;

    Vector3 scaleChange = new Vector3(0.25f, 0.25f, 0.25f);

    public List<GameObject> UI_sets = new List<GameObject>();

    public Animator player_Anim;
    int currAnim = 0;

    // Start is called before the first frame update
    void Start()
    {
        UI_sets[0].SetActive(true);
        UI_sets[1].SetActive(false);
        UI_sets[2].SetActive(false);
        UI_sets[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextColor()
    {
        currentTextureIndex++;

        if (currentTextureIndex >= jacketTextures.Count)
        {
            currentTextureIndex = 0;
        }

        ChangeJacketColor();
    }

    public void PrevColor()
    {
        currentTextureIndex--;

        if (currentTextureIndex < 0)
        {
            currentTextureIndex = jacketTextures.Count-1;
        }

        ChangeJacketColor();
    }

    public void ChangeJacketColor()
    {
        jacketMaterials.mainTexture = jacketTextures[currentTextureIndex];
    }

    public void LeftRotate()
    {
        this.transform.Rotate(0f, 30f, 0f);
    }

    public void RightRotate()
    {
        this.transform.Rotate(0f, -30f, 0f);
    }

    public void PlusScale()
    {
        this.transform.localScale += scaleChange;
    }

    public void MinusScale()
    {
        this.transform.localScale -= scaleChange;
    }

    public void Origin()
    {
        this.transform.position = new Vector3(0f, 0f, 0f);
        this.transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
    }

    public void NextAnimation()
    {
        currAnim += 1;

        if (currAnim > 1)
        {
            currAnim = -1;
        }
        PlayAnimation();
    }

    public void PrevAnimation()
    {
        currAnim -= 1;

        if (currAnim < -1)
        {
            currAnim = 1;
        }
        PlayAnimation();
    }

    public void PlayAnimation()
    {
        if (currAnim == 1)
        {
            player_Anim.ResetTrigger("Walk");
            player_Anim.ResetTrigger("Idle");
            player_Anim.SetTrigger("Dance");
        }

        else if (currAnim == -1)
        {
            player_Anim.ResetTrigger("Dance");
            player_Anim.ResetTrigger("Idle");
            player_Anim.SetTrigger("Walk");
        }

        else
        {
            player_Anim.ResetTrigger("Walk");
            player_Anim.ResetTrigger("Dance");
            player_Anim.SetTrigger("Idle");
        }
    }

    public void Animate()
    {
        UI_sets[0].SetActive(false);
        UI_sets[2].SetActive(true);
    }

    public void Transform()
    {
        UI_sets[0].SetActive(false);
        UI_sets[1].SetActive(true);
    }

    public void Customise()
    {
        UI_sets[0].SetActive(false);
        UI_sets[3].SetActive(true);
    }

    public void ReturnToMain()
    {
        UI_sets[0].SetActive(true);
        UI_sets[1].SetActive(false);
        UI_sets[2].SetActive(false);
        UI_sets[3].SetActive(false);
    }

}
