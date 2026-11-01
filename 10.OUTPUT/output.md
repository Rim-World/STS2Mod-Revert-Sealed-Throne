# 构建产物与发布包索引

> 最后更新：2026-11-01
> 本目录内容不入库（`.gitignore` 已忽略，仅保留本文件）。

| 时间 | 名称 | 版本号 | 大小 | 说明 |
|---|---|---|---|---|
| 2026-11-01 | `RevertTheSealedThrone.v1.0.zip` | 1.0 | 432 KB | 从游戏 mods 目录打包（dll/pck/json/pdb），随 GitHub Release v1.0 发布 |
| 2026-11-01 | `RevertTheSealedThroneSourceCode.zip` | 1.0 | 24 KB | 源码包，随 GitHub Release v1.0 发布 |

## 产物构成（参考）

| 文件 | 说明 |
|---|---|
| `RevertTheSealedThrone.dll` | Harmony 补丁与形状守卫 |
| `RevertTheSealedThrone.pck` | 创意工坊图标 |
| `RevertTheSealedThrone.json` | mod 清单（版本号与依赖声明） |
| `RevertTheSealedThrone.pdb` | 调试符号（可选分发） |
