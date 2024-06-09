using UnityEngine.Rendering;

namespace DualKawaseBlur
{
    [VolumeComponentMenu("Custom/BackGroundBlur"),System.Serializable]
    public class BackGroundBlur : VolumeComponent
    {
        
        //パラメーター定義
        public ClampedFloatParameter blur = new (0, 0, 1);
        // public Vector4Parameter Rect0 = new( new (0,0,0,0)) ;
        // public Vector4Parameter Rect1 = new( new (0,0,0,0)) ;
        // public Vector4Parameter Rect2 = new( new (0,0,0,0)) ;
        
        //アクティブ条件の設定
        public bool IsActive()
        {
            return blur.value > 0;
        }
    }
}