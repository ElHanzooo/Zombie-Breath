shader_type canvas_item;

uniform vec2 offset = vec2(5.0, 5.0);
uniform vec4 shadow_color : source_color = vec4(0.0, 0.0, 0.0, 0.5);
uniform float blur_amount : hint_range(0.0, 5.0) = 1.0;

void fragment() {
    vec4 col = texture(TEXTURE, UV);
    
    vec2 ps = TEXTURE_PIXEL_SIZE;
    vec2 shadow_uv = UV - (offset * ps);
    
    float shadow_alpha = texture(TEXTURE, shadow_uv).a;
    
    vec4 shadow = vec4(shadow_color.rgb, shadow_alpha * shadow_color.a);
    
    COLOR = mix(shadow, col, col.a);
}