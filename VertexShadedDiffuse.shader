Shader "VertexShadedDiffuse" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_f ( "f", float) = 1
 	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf SimpleLambert
  
          half4 LightingSimpleLambert (SurfaceOutput s, half3 lightDir, half atten) {
              half NdotL = dot (s.Normal, lightDir);
              half4 c;
              c.rgb = s.Albedo * _LightColor0.rgb * (NdotL * atten * 2);
              c.a = s.Alpha;
              return c;
          }

		sampler2D _MainTex;
		float _f;

		struct Input {
			float2 uv_MainTex;
			float4 color : COLOR;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb *  IN.color.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
