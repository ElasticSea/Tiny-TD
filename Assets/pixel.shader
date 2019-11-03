// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|custl-8817-OUT,olwid-2498-OUT,olcol-920-RGB;n:type:ShaderForge.SFN_LightVector,id:6869,x:31858,y:32654,varname:node_6869,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9684,x:31858,y:32782,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:7782,x:32073,y:32618,cmnt:Lambert,varname:node_7782,prsc:2,dt:4|A-6869-OUT,B-9684-OUT;n:type:ShaderForge.SFN_Color,id:4865,x:32391,y:33113,ptovrint:False,ptlb:wasfasf,ptin:_wasfasf,varname:node_4865,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.2352941,c3:0.07951321,c4:1;n:type:ShaderForge.SFN_Posterize,id:159,x:32608,y:32448,varname:node_159,prsc:2|IN-7782-OUT,STPS-3494-OUT;n:type:ShaderForge.SFN_Vector1,id:3494,x:32439,y:32579,varname:node_3494,prsc:2,v1:4;n:type:ShaderForge.SFN_Color,id:3587,x:32391,y:33271,ptovrint:False,ptlb:fasdfag,ptin:_fasdfag,varname:_SpecColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.4632353,c3:0.1544117,c4:1;n:type:ShaderForge.SFN_Code,id:8817,x:32949,y:33260,varname:node_8817,prsc:2,code:aQBmACgAdgBhAGwAIAA8ACAAMAAuADIANQApAHsACgByAGUAdAB1AHIAbgAgAGMAMAA7AAoAfQBpAGYAKAB2AGEAbAAgADwAIAAwAC4ANQApAHsACgByAGUAdAB1AHIAbgAgAGMAMQA7AAoAfQBpAGYAKAB2AGEAbAAgADwAIAAwAC4ANwA1ACkAewAKAHIAZQB0AHUAcgBuACAAYwAyADsACgB9AGUAbABzAGUAewAKAHIAZQB0AHUAcgBuACAAYwAzADsACgB9AA==,output:2,fname:Function_node_8817,width:352,height:148,input:0,input:2,input:2,input:2,input:2,input_1_label:val,input_2_label:c0,input_3_label:c1,input_4_label:c2,input_5_label:c3|A-3789-OUT,B-4865-RGB,C-3587-RGB,D-7757-RGB,E-4036-RGB;n:type:ShaderForge.SFN_Color,id:7757,x:32391,y:33431,ptovrint:False,ptlb:wgsdfa,ptin:_wgsdfa,varname:_SpecColor_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2119377,c2:0.8235294,c3:0.4158016,c4:1;n:type:ShaderForge.SFN_Color,id:4036,x:32391,y:33592,ptovrint:False,ptlb:whsdfs,ptin:_whsdfs,varname:_SpecColor_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7132353,c2:1,c3:0.8088235,c4:1;n:type:ShaderForge.SFN_Power,id:3789,x:32545,y:32760,varname:node_3789,prsc:2|VAL-7782-OUT,EXP-4147-OUT;n:type:ShaderForge.SFN_Vector1,id:4147,x:32451,y:32946,varname:node_4147,prsc:2,v1:4;n:type:ShaderForge.SFN_Color,id:920,x:32209,y:32958,ptovrint:False,ptlb:wasfasf_copy,ptin:_wasfasf_copy,varname:_wasfasf_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.2352941,c3:0.07951321,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:2498,x:32738,y:32952,ptovrint:False,ptlb:node_2498,ptin:_node_2498,varname:node_2498,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;proporder:4865-3587-7757-4036-920-2498;pass:END;sub:END;*/

Shader "Shader Forge/pixel" {
    Properties {
        _wasfasf ("wasfasf", Color) = (0,0.2352941,0.07951321,1)
        _fasdfag ("fasdfag", Color) = (0,0.4632353,0.1544117,1)
        _wgsdfa ("wgsdfa", Color) = (0.2119377,0.8235294,0.4158016,1)
        _whsdfs ("whsdfs", Color) = (0.7132353,1,0.8088235,1)
        _wasfasf_copy ("wasfasf_copy", Color) = (0,0.2352941,0.07951321,1)
        _node_2498 ("node_2498", Float ) = 0.1
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _wasfasf_copy;
            uniform float _node_2498;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_FOG_COORDS(0)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*_node_2498,1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_wasfasf_copy.rgb,0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _wasfasf;
            uniform float4 _fasdfag;
            float3 Function_node_8817( float val , float3 c0 , float3 c1 , float3 c2 , float3 c3 ){
            if(val < 0.25){
            return c0;
            }if(val < 0.5){
            return c1;
            }if(val < 0.75){
            return c2;
            }else{
            return c3;
            }
            }
            
            uniform float4 _wgsdfa;
            uniform float4 _whsdfs;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
                float node_7782 = 0.5*dot(lightDirection,normalDirection)+0.5; // Lambert
                float3 finalColor = Function_node_8817( pow(node_7782,4.0) , _wasfasf.rgb , _fasdfag.rgb , _wgsdfa.rgb , _whsdfs.rgb );
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _wasfasf;
            uniform float4 _fasdfag;
            float3 Function_node_8817( float val , float3 c0 , float3 c1 , float3 c2 , float3 c3 ){
            if(val < 0.25){
            return c0;
            }if(val < 0.5){
            return c1;
            }if(val < 0.75){
            return c2;
            }else{
            return c3;
            }
            }
            
            uniform float4 _wgsdfa;
            uniform float4 _whsdfs;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
////// Lighting:
                float node_7782 = 0.5*dot(lightDirection,normalDirection)+0.5; // Lambert
                float3 finalColor = Function_node_8817( pow(node_7782,4.0) , _wasfasf.rgb , _fasdfag.rgb , _wgsdfa.rgb , _whsdfs.rgb );
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
