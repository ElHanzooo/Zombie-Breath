using Godot;
using System;
using Godot.Collections;

public partial class GenericUIAnimation : BaseButton
{
	[ExportGroup("Animation Configuration")]
	[Export] public float Duration = 0.2f;
	[Export] public Tween.TransitionType Transition = Tween.TransitionType.Cubic;
	[Export] public Tween.EaseType Ease = Tween.EaseType.Out;


	[ExportGroup("Properties: Mouse Hover")]
	[Export] public Dictionary<string, Variant> HoverValues = new Dictionary<string, Variant>();

	[ExportGroup("properties: Initial State")]
	[Export] public Dictionary<string, Variant> DefaultValues = new Dictionary<string, Variant>();

	private Tween _tween;

	public void OnMouseEntered() => AnimateTo(HoverValues);
	public void OnMouseExited() => AnimateTo(DefaultValues);

	private void AnimateTo(Dictionary<string, Variant> targetProperties)
	{
		_tween?.Kill();

		if (targetProperties == null || targetProperties.Count == 0) return;

		_tween = GetTree().CreateTween().SetParallel(true);

		foreach (var entry in targetProperties)
		{
			_tween.TweenProperty(this, entry.Key, entry.Value, Duration)
				  .SetTrans(Transition)
				  .SetEase(Ease);
		}
	}
}
