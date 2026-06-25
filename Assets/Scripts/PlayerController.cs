using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // プレイヤーのRigidbodyコンポーネント
    private Animator playerAnim; // プレイヤーのAnimatorコンポーネント
    private bool isOnGround = true; // 地面に接触しているかどうかのフラグ
    private AudioSource playerAudio; // プレイヤーのAudioSourceコンポーネント
    private GameInputs gameInputs; // 入力を管理する

    public float jumpForce = 1; // ジャンプの力
    public ParticleSystem explosionParticle; // 爆発パーティクル
    public ParticleSystem dirtParticle; // 土埃パーティクル
    public AudioClip jumpSound; // ジャンプ時の効果音
    public AudioClip crashSound; // 障害物とぶつかった時の効果音

    // Start is called before the first frame update
    void Start()
    {
        // Playerの各コンポーネントを取得
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        gameInputs = new GameInputs(); // 入力を管理するクラスのインスタンス
        gameInputs.Player.Jump.performed += OnJump; // ジャンプの入力が行われたときのメソッドを登録
        gameInputs.Enable(); // 入力を有効化
    }

    // ジャンプの入力が行われたときに呼び出される
    private void OnJump(InputAction.CallbackContext context)
    {

    }

}


/*

        // コピー元 - １：ジャンプ
        if (isOnGround && !GameManager.isGameOver())
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // 上方向に力を加えてジャンプさせる
            playerAnim.SetTrigger("Jump_trig"); // ジャンプ時のアニメを起動

        }


    // コピー元 - ２：他のオブジェクトと接触した際に呼び出される
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; // 地面に接触した
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // 障害物と接触したらゲームオーバー
            GameManager.SetGameOver();
            playerAnim.SetBool("Death_b", true); // 倒れるアニメを起動
            playerAnim.SetInteger("DeathType_int", 1); // 倒れ方の指定

        }
    }


            // コピー元 - ３
            isOnGround = false; // 地面から離れた

            // コピー元 - ４
            playerAudio.PlayOneShot(jumpSound, 1.0f); // ジャンプ時の効果音を鳴らす

            // コピー元 - ５
            playerAudio.PlayOneShot(crashSound, 1.0f); // 障害物とぶつかった効果音を鳴らす

            // コピー元 - ６
            dirtParticle.Stop(); // 土埃パーティクルを止める 1

            // コピー元 - ７
            dirtParticle.Play(); // 土埃パーティクルを起動

            // コピー元 - ８
            dirtParticle.Stop(); // 土埃パーティクルを止める 2
            explosionParticle.Play(); // 爆発パーティクルを起動

 */

