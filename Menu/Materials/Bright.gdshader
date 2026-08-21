shader_type canvas_item;

uniform float bright : hint_range(-1.0, 1.0) = 0.0;

void fragment() {
	vec4 originalColor = texture(TEXTURE, UV);
	
	vec3 colorWithShine = originalColor.rgb + bright;
	
	COLOR = vec4(colorWithShine, originalColor.a);
}