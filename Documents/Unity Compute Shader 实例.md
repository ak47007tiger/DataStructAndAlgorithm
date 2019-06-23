# Unity Compute Shader Demo
- 本文提供一个简单的可运行的Unity Compute Shader实例

# 运行结果

# Shader代码
```
// Each #kernel tells which function to compile; you can have many kernels
#pragma kernel CSMain

// Create a RenderTexture with enableRandomWrite flag and set it
// with cs.SetTexture
RWTexture2D<float4> Result;

[numthreads(8,8,1)]
void CSMain (uint3 id : SV_DispatchThreadID)
{
    Result[id.xy] = float4(id.x & id.y, (id.x & 15)/15.0, (id.y & 15)/15.0, 1);
    // Result[id.xy] = float4(1,0,0,1);
}
```

# Script代码
```
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Sample01 : MonoBehaviour
{
  public ComputeShader _ComputeShader;
  public RawImage rawImg;
  private Vector2Int size = new Vector2Int(8,8);
  private RenderTexture _Result;

  private int propId;
  private int kernelIndex;

  void Start()
  {
    var desc = new RenderTextureDescriptor(size.x, size.y, RenderTextureFormat.ARGBHalf);
    desc.enableRandomWrite = true;
    _Result = new RenderTexture(desc);
    _Result.Create();

    propId = Shader.PropertyToID("Result");
    kernelIndex = _ComputeShader.FindKernel("CSMain");

    _ComputeShader.SetTexture(kernelIndex, propId, _Result);

    _ComputeShader.Dispatch(kernelIndex, size.x, size.y, 1);

    rawImg.texture = _Result;
  }

  void OnDestroy()
  {

    if (null != _Result)
    {
      _Result.Release();
    }

  }

}

```

# 需要手动做的操作
- 创建UGUI的RawImage拖到脚本上
- 创建compute shader，换成文中代码拖到脚本上

# 需要注意的点
- 查找shader中的变量id
  - RWTexture2D<float4> Result;
  - Shader.PropertyToID("Result");
  - 直接用变量名查找
- _Result.Create(); //创建
