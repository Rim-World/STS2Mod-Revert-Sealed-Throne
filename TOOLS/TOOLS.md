# 工具与自写脚本索引

> 最后更新：2026-11-01

## 外部工具依赖

| 时间 | 工具 | 版本 | 用途 | 来源 | 安装方式 |
|---|---|---|---|---|---|
| 2026-08 | .NET SDK | 9.0 | 编译 C#（MSIL） | 系统已装 | 全局安装 |
| 2026-08 | Godot（mono） | 4.5.1-stable | 资源导入与 `--export-pack` 打包 pck | 本机 `C:\Godot&GDRE` | 免安装 |
| 2026-08 | HarmonyLib | 随游戏 | 运行时方法补丁 | 游戏目录 `data_sts2_windows_x86_64/0Harmony.dll` | 随游戏提供 |

## 自写脚本

| 时间 | 脚本 | 用途 | 依赖 | 说明 |
|---|---|---|---|---|
| 2026-08 | `9.SRC/RevertTheSealedThrone/build.ps1` | 一键构建并部署到游戏 mods 目录 | dotnet、Godot 4.5.1、游戏本体 | 属于源码工程的一部分，留在 `9.SRC/` 内 |

`TOOLS/scripts/` 目前为空：本项目未产生独立于工程之外的自写脚本。
