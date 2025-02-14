using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.ReverseEngineering;

/// <summary>
/// This item has some value in reverse engineering lathe recipes.
/// </summary>
[RegisterComponent]
public sealed partial class ReverseEngineeringComponent : Component
{
    /// <summary>
    /// The recipes that can be reverse engineered from this.
    /// Does not neccesarily line up with lathe recipes.
    /// </summary>
    [DataField("recipes")]
    public List<string>? Recipes;

    /// <summary>
    /// Difficulty score 1-5 how hard this is to reverse engineer.
    /// </summary>
    [DataField("difficulty")]
    public readonly int Difficulty = 1;

    /// <summary>
    /// A new item that should be given back by the reverse engineering machine instead of this one.
    /// E.g., NT aligned versions of syndicate items.
    /// </summary>
    [DataField("newItem", customTypeSerializer:typeof(PrototypeIdSerializer<EntityPrototype>))]
    public string? NewItem;
}
