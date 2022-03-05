using UnityEngine.EventSystems;

/// <summary>
/// Enemyのダメージ判定
/// </summary>
public interface IReceiveDamageEnemy : IEventSystemHandler
{
    void ReceiveDamage(float damage);
}
