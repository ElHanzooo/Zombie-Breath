shader_type canvas_item;

uniform vec4 outline_color : source_color = vec4(1.0, 0.0, 0.0, 1.0);
uniform float outline_width : hint_range(0.0, 10.0) = 1.0;

bool is_transparent(vec2 uv_offset, vec2 current_uv, sampler2D tex) {
	return texture(tex, current_uv + uv_offset).a < 0.1;
}

void fragment() {
	vec4 base_color = texture(TEXTURE, UV);
	vec4 final_color = base_color;

	if (base_color.a < 0.1) {
		bool found_edge = false;
		
		// Mudamos o loop para usar uma variável de controle em vez de 'return'
		for (float x = -outline_width; x <= outline_width; x += 1.0) {
			for (float y = -outline_width; y <= outline_width; y += 1.0) {
				if (x == 0.0 && y == 0.0) continue;
				
				vec2 offset = vec2(x, y) * TEXTURE_PIXEL_SIZE;
				
				if (!is_transparent(offset, UV, TEXTURE)) {
					found_edge = true;
					break; // O 'break' sai do loop interno, o que é permitido
				}
			}
			if (found_edge) break; // Sai do loop externo
		}
		
		if (found_edge) {
			final_color = outline_color;
		}
	}
	
	COLOR = final_color;
}