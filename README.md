# STS2Mod-回调王座（RevertTheSealedThrone）

> 把《杀戮尖塔 2》储君先古卡「封印王座」的升级效果回调为 v0.106 及之前的「固有」。
> Reverts the Regent's Ancient card "The Sealed Throne": upgrading it grants Innate again, instead of reducing its cost.

- 当前版本：**1.0**
- ModId：`RevertTheSealedThrone`
- 游戏版本：default 0.107.1 / public beta 0.111.0
- 开源地址：<https://github.com/Rim-World/STS2Mod-Revert-Sealed-Throne>
- 许可：MIT（见 [LICENSE](LICENSE)）

## 功能

- **升级效果**：v0.107.1 起升级为「费用 -1」；本 mod 改为 v0.106 及之前的「添加固有」。
- **基础版不变**：未升级的封印王座与原版完全一致。
- **无需文本补丁**：「固有」由关键词自动渲染，卡面描述、升级预览与图鉴同步。
- **自动降级**：卡片形态与预期不符时（未来版本改动），补丁自动失效并记警告，不破坏游戏。

## 兼容性

- 单份产物同时服务 default 107 与 public beta 111：两版 `OnUpgrade` 反编译逐字一致。
- 无 mod 依赖（`dependencies: []`）。
- 不保证与盗版、修改版、移动版、老旧版本或冷门 mod、次级 mod 的兼容性。

## 安装

1. 构建产物为 `RevertTheSealedThrone.dll` + `.pck` + `.json` 三件套。
2. 放入游戏目录 `mods/RevertTheSealedThrone/`。
3. 启动游戏，日志出现 `RevertTheSealedThrone: Harmony patches applied` 即生效。

## 构建

```powershell
cd 9.SRC\RevertTheSealedThrone
pwsh .\build.ps1
```

依次执行：`dotnet build -c Debug` → Godot headless 导入 → `--export-pack "Windows Desktop"` →
拷贝 dll/pdb/json 到游戏 `mods/`。依赖本机 `sts2.dll`、`0Harmony.dll` 与 Godot 4.5.1 mono。

## 目录结构

```
1.ADR/          决策记录（ADR.md 索引）
2.PLANS/        施工计划（PLANS.md 索引）
3.DOCS/         知识与取证（DOCS.md 索引）
4.SDD/          软件设计（SDD.md 索引）
5.ChangeLog/    版本日志（ChangeLog.md 索引）
9.SRC/          源码（Godot + C# 工程）
10.OUTPUT/      构建产物与发布包（output.md 索引，不入库）
PRIVACY/        机密信息（不入库）
TMP/            临时与过程文件（TMP.md 索引，不入库）
TOOLS/          工具与自写脚本（TOOLS.md 索引）
description/    创意工坊文案（中/英）
pics/           封面与素材图
```

## 文档索引

- 决策：[1.ADR/001-封印王座升级效果回调方案.md](1.ADR/001-封印王座升级效果回调方案.md)
- 计划：[2.PLANS/001-G-封印王座升级回调计划.md](2.PLANS/001-G-封印王座升级回调计划.md)
- 调研：[3.DOCS/001-T-封印王座版差异与可行性调研.md](3.DOCS/001-T-封印王座版差异与可行性调研.md)
- 设计：[4.SDD/001-总体设计.md](4.SDD/001-总体设计.md)
- 版本日志：[5.ChangeLog/001-1.0-2026-08-17.md](5.ChangeLog/001-1.0-2026-08-17.md)、[CHANGELOG.md](CHANGELOG.md)

## 致谢

感谢《杀戮尖塔 2》制作组提供的 mod 支持；感谢 [STS2RevertAnthony](https://github.com/jiegec/STS2RevertAnthony)
提供的版本差异数据与参考实现。

## 许可

本项目采用 [MIT 许可证](LICENSE)。

## 反馈

欢迎在创意工坊评论区或 GitHub Issues 提出意见与反馈。
