using UnityEngine;
using UnityEngine.UI;
using RandomColorUnity;

public class RandomColorButton : MonoBehaviour
{
    public Image Image;
    public RandomColor.PredefinedColor Color;
    public RandomColor.LuminosityLevel Luminosity;

    RandomColor rc;

    #region Overrides
    protected virtual void Awake()
    {
        rc = new RandomColor();
    }
    #endregion

    public void RandomizeColor()
    {
        Image.color = rc.GetColor(Color, Luminosity);
    }
}
