// ---------------------------------------------------------  
// PlayerSound.cs  
// プレイヤー効果音を再生するスクリプト
// 作成日:  3/1
// 作成者:  竹村綾人
// ---------------------------------------------------------  
using UnityEngine;

public class PlayerSound : MonoBehaviour
{

    #region 変数  

    private AudioSource _audioSource = default;
    [SerializeField, Tooltip("攻撃１の音")]
    private AudioClip _attack1 = default;
    [SerializeField, Tooltip("攻撃２の音")] 
    private AudioClip _attack2 = default;
    [SerializeField, Tooltip("攻撃３の音")]
    private AudioClip _attack3 = default;
    [SerializeField, Tooltip("攻撃４の音")] 
    private AudioClip _attack4 = default;
    [SerializeField, Tooltip("回避音")]
    private AudioClip _dodge = default;    
    [SerializeField, Tooltip("歩く音")]
    private AudioClip _walk = default;    
    [SerializeField, Tooltip("死んだ時の声")]
    private AudioClip _death = default;    

    #endregion

    #region メソッド  

    /// <summary>
    /// 更新前処理
    /// </summary>
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    /// <summary>  
    /// 効果音再生
    /// </summary>  
    public void Sound(string animeType)
     {
        //今のアニメーションに対応したサウンドを設定
        switch (animeType)
        {
            case "Attack1":
                _audioSource.clip = _attack1;
                break;
            case "Attack2":
                _audioSource.clip = _attack2;
                break;
            case "Attack3":
                _audioSource.clip = _attack3;
                break;
            case "Attack4":
                _audioSource.clip = _attack4;
                break;
            case "Dodge":
                _audioSource.clip = _dodge;
                break;
            case "Walk":
                _audioSource.clip = _walk;
                break;
            case "Run":
                _audioSource.clip = _walk;
                break;
            case "Death":
                _audioSource.clip = _death;
                break;
        }
        //サウンドを再生する
        _audioSource.PlayOneShot(_audioSource.clip);
     }
  
    #endregion
}
