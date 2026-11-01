# 更新日志

本文件记录本项目所有重要变更。
格式参考 [Keep a Changelog](https://keepachangelog.com/zh-CN/1.1.0/)，版本号遵循语义化版本。
详细的分版本施工记录（含开发人员反馈、失败教训与提交编号）见 `5.ChangeLog/`。

## [1.0] - 2026-08-17

### 新增

- 升级效果替换：`TheSealedThrone.OnUpgrade` 由「费用 -1」改为「添加固有」（Prefix 整体替换）。
- 形状守卫：能量费 1 / 星费 3 / Power / Ancient / 基础版不含固有，失配即禁用补丁并告警。
- mod 清单、Godot 工程、`build.ps1` 构建链与创意工坊图标。

### 变更

- 升级前已含 `Innate` 时放行原实现，避免未来官方改回固有时重复添加。

### 已知问题

- 游戏内效果（107 / 111）的实机验证未记录。

## 未发布

### 变更

- 仓库整理：源码移入 `9.SRC/`，文档按 AGENTS.md 规范重新编号并补全 `4.SDD`、`5.ChangeLog`、`10.OUTPUT`、`PRIVACY`、`TMP`、`TOOLS` 骨架。未改动任何代码。
- 新增 MIT 许可证。
