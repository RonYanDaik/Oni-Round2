Shader "GLU/GLU Image Shader" {
	Properties {
		_MainTex ("Image Texture", 2D) = "white" {}
		_Color ("Color", Color) = (1,1,1,1)
        _RGBOffset ("RGB offset", Range(-1,1)) = 0
	}

	SubShader {

		Tags {"IgnoreProjector"="True" "RenderType"="Transparent" "Queue"="Transparent"}
		AlphaTest Off
		Lighting Off Cull Off ZTest Always ZWrite Off Fog { Mode Off }
		Blend SrcAlpha OneMinusSrcAlpha
		// Blend SrcAlpha Zero
		// Blend OneMinusDstAlpha DstAlpha
		// Blend SrcColor OneMinusSrcColor
		BlendOp Add

		Pass {	
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest

			#include "UnityCG.cginc"

			struct appdata_t {
				float4 vertex : POSITION;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f {
				float4 vertex : POSITION;
				float2 texcoord : TEXCOORD0;
			};

			sampler2D _MainTex;
			uniform float4 _MainTex_ST;
			uniform fixed4 _Color;
			float _RGBOffset;
			
			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.texcoord = TRANSFORM_TEX(v.texcoord,_MainTex);
				return o;
			}

			fixed4 frag (v2f i) : COLOR
			{
				fixed4 col = tex2D(_MainTex, i.texcoord);
				// col *= _Color;
				// col.a = max(col.a, _Color.a);
				col.a = col.a * _Color.a;
				col.rgb *= _Color.rgb;
				return col;
			}
			ENDCG 
		}
	} 	

	SubShader {
		Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
		Lighting Off Cull Off ZTest Always ZWrite Off Fog { Mode Off }
		Blend SrcAlpha OneMinusSrcAlpha
		Pass {
			Color [_Color]
			SetTexture [_MainTex] {
				combine primary, texture * primary
			}
		}
	}
}
