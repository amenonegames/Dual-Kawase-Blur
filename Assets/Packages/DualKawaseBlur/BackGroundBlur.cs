using UnityEngine.Rendering;

namespace DualKawaseBlur
{
    [VolumeComponentMenu("Custom/BackGroundBlur"),System.Serializable]
    public class BackGroundBlur : VolumeComponent
    {
        
        //パラメーター定義
        public ClampedFloatParameter blur = new (0, 0, 5);
        
        //アクティブ条件の設定
        public bool IsActive()
        {
            return blur.value > 0;
        }
    }
}