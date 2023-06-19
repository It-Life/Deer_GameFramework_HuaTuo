//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.Deer
{
public sealed partial class PlayerData_Character :  Bright.Config.BeanBase 
{
    public PlayerData_Character(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        Hp = _buf.ReadInt();
        Speed = _buf.ReadFloat();
        DamageResistance = _buf.ReadFloat();
        BoosterPower = _buf.ReadFloat();
        BoosterDuration = _buf.ReadFloat();
        BoosterCooldown = _buf.ReadFloat();
        PostInit();
    }

    public static PlayerData_Character DeserializePlayerData_Character(ByteBuf _buf)
    {
        return new Deer.PlayerData_Character(_buf);
    }

    /// <summary>
    /// 唯一标识
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// GamePlay预制体路径
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 生命值
    /// </summary>
    public int Hp { get; private set; }
    /// <summary>
    /// 移动速度
    /// </summary>
    public float Speed { get; private set; }
    /// <summary>
    /// 伤害抗性
    /// </summary>
    public float DamageResistance { get; private set; }
    /// <summary>
    /// 助推器强度
    /// </summary>
    public float BoosterPower { get; private set; }
    /// <summary>
    /// 助推器持续时间
    /// </summary>
    public float BoosterDuration { get; private set; }
    /// <summary>
    /// 助推器冷却时间
    /// </summary>
    public float BoosterCooldown { get; private set; }

    public const int __ID__ = 2146940661;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Hp:" + Hp + ","
        + "Speed:" + Speed + ","
        + "DamageResistance:" + DamageResistance + ","
        + "BoosterPower:" + BoosterPower + ","
        + "BoosterDuration:" + BoosterDuration + ","
        + "BoosterCooldown:" + BoosterCooldown + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}