## 概述
- 使用Unity来使用GPU更加容易
- 本文旨在构造一个产品级路径追踪器，并且保持快速、简单、有效

## 在Unity中的流程
- 渲染流程
  - 在ComputeShader中追踪光线
  - 保存结果到RenderTexture
  - 渲染Rendertexture到屏幕
- 在计算核心上每个工作组运行一个8x8的线程块
  - 一组线程运行8x8的块，所以分法的时候dispatch(widht / 8, height / 8)把所有的像素都包含了
  - 当追踪结束的时候计算结果累计到像素里
- 最终的计算结果处理
  - 每个像素累计了追踪的值，所以是超过1的
  - 在alpha通道存储追踪的次数
  - 在rgb通道存颜色值
  - 最终结果为rgb/a
- 在OnRenderImage中把像素渲染到屏幕上，具体操作可查看Unity后处理相关知识
```
void OnRenderImage(RenderTexture source, RenderTexture dest) {
  Graphics.Blit(m_accumulatedImage, dest, FullScreenResolve);
}
```

## 随机采样

## GPU上的追踪射线

## 射线调度器

## 使用Unity的相机

## 深度

## 游戏对象 & 材质更新
- 提供光线追踪需要的数据

## 减少闪烁
- 对每个是黑色的像素，重置采样次数为1