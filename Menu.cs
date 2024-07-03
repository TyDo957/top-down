using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void menugame()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu2()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu3()
    {
        SceneManager.LoadScene(2);
    }
    public void Bomb()
    {
        SceneManager.LoadScene(3);
    }

    public void Character()
    { 
        SceneManager.LoadScene(4);
    }
    
    public void Skill()
    {
        SceneManager.LoadScene(5);
    }
    
    public void Lucky()
    {
        SceneManager.LoadScene(6);
    }
    
    public void Weapon()
    {
        SceneManager.LoadScene(7);
    }
    
   public void Short()
    {
        SceneManager.LoadScene(8);
    }
    
    public void Dura()
    {
        SceneManager.LoadScene(9);
    }
    public void Hp()
    {
        SceneManager.LoadScene(10);
    }
    public void Skillan()
    {
        SceneManager.LoadScene(11);
        
    }
    public void Gold()
    {
        SceneManager.LoadScene(12);
    }
   
   public void Danh()
    {
        SceneManager.LoadScene(13);
        
    }
    public void War()
    {
        SceneManager.LoadScene(14);
    }
    
}
