using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerからの攻撃判定
/// PlayerとEnemyでinterfaceを分けるべきか不明なため、取り敢えず分けた
/// </summary>
public interface IReceiveDamageEnemy
{
    void ReceiveDamage(float damage);
}
