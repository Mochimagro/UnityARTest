# デモ動画
https://www.youtube.com/watch?v=JVaKo_rP6bw

# 概要
本リポジトリは、Unity + AR Foundation を用いて

 - 平面検出＋タップによるオブジェクト配置（ARRaycast）
 - 画像マーカー認識による3Dキャラクター表示（ARMarker）

の2種類のAR表現を実装し、
UI操作によってシーンを切り替え可能なサンプルアプリケーションです。

ポートフォリオ用途として、
実装速度・再現性を重視して構成しています。

# 開発環境
Unity	2022.3.62f3 LTS

言語	C#

AR SDK	AR Foundation

XR Plugin	ARCore XR Plugin

Platform	Android

Graphics	URP

検証端末	Google Pixel 8a

※ ARCore対応端末が必要です

# 機能構成
1. ARRaycast Scene

平面検出（ARPlaneManager）

タップ位置へのレイキャスト

Prefabの動的生成

デバッグ用UI表示

2. ARMarker Scene

画像マーカー検出（ARTrackedImageManager）

マーカー認識時の3Dキャラクター生成

認識状態の管理（生成・非表示）

# 技術的補足・制約

Human Occlusion（人物遮蔽）は未対応

AR未対応端末では正常動作しません

# 参考記事
 - ARRaycast
https://note.com/bunmeisha_media/n/nc1b308f180df

 - ARMarker
https://qiita.com/Pancetta/items/3754c3b22268760e05a4

 - オクルージョン設定
https://marumaro7.hatenablog.com/entry/arocclusion

