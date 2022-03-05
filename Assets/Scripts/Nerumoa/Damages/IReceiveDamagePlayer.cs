using UnityEngine.EventSystems;

/// <summary>
/// Playerのダメージ判定
/// </summary>
public interface IReceiveDamagePlayer : IEventSystemHandler
{
    void ReceiveDamage(float damage);
}
