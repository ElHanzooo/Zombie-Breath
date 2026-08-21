shader_type canvas_item;

uniform sampler2D screenTexture : hint_screen_texture, filter_linear_mipmap;

uniform bool activated = true;

uniform float speedOfChange : hint_range(0.1, 30.0) = 10.0;
uniform float minimumSaturation : hint_range(0.0, 3.0) = 0.1;
uniform float maximumSaturation : hint_range(0.0, 3.0) = 1.0;

float randomGenerator(float seed) 
{
    return fract(sin(seed * 12.9898) * 43758.5453123);
}

void fragment() 
{
    vec4 originalColor = texture(screenTexture, SCREEN_UV);
    
    float slicedTime = floor(TIME * speedOfChange);
    
    float randomFactor = randomGenerator(slicedTime);
    
    float currentSaturation = mix(minimumSaturation, maximumSaturation, randomFactor);
    
    float luminance = dot(originalColor.rgb, vec3(0.299, 0.587, 0.114));
    vec3 grayscale = vec3(luminance);
    vec3 finalColor = mix(grayscale, originalColor.rgb, currentSaturation);
    
	if (activated)
	{
    	COLOR = vec4(finalColor, originalColor.a);
	}
	else
	{
		COLOR = originalColor;
	}
}