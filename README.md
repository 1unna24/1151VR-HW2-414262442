# Unity 專案內容

目前專案為 Unity 2D 專案，場景為 `SampleScene`，包含以下物件：

 | Main Camera | Background（背景圖片） | meangirl（2D 人物角色）

## 製作流程與相關操作

### 1. Unity 專案建立
- 開啟 Unity Hub
- 建立 Unity 2D 專案
- 建立並設定遊戲場景
- 匯入 2D 人物圖片及背景素材

### 2. Unity 場景操作
- 熟悉 Unity 2D 編輯器介面
- 將人物及背景素材匯入 Assets
- 使用 Hierarchy 管理場景物件
- 調整人物及背景的位置、大小與圖層順序
- 設定人物起點、移動路徑及終點

### 3. 角色移動與跳躍實作
- 使用 C# 撰寫人物移動程式 `Move.cs`
- 使用 Vector3 儲存人物移動座標
- 使用陣列（Array）設定人物移動位置
- 使用 `Vector3.MoveTowards()` 實作直線移動
- 使用 `Mathf.Lerp()` 與數學公式實作拋物線跳躍
- 使用鍵盤 Space 鍵控制人物移動及跳躍

### 4. 作業繳交
- **GitHub：** https://github.com/1unna24/1151VR-HW2-414262442
- **YouTube：** https://youtu.be/dWsL3pX6OIc
