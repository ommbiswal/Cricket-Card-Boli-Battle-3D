CRICKET CARD BOLI BATTLE — UNITY 3D STARTER PROJECT
===================================================

This is a STARTER / PROTOTYPE scaffold, not a finished commercial cricket game.
It creates a simple 3D cricket practice scene from Unity primitives at runtime.

Confirmed game design:
- English-only UI and game text
- Online P vs P + AI modes planned
- Match entry: 20 virtual CC
- Winner reward: 60 virtual CC
- New account receives one random fictional starter player
- Fictional player roster until likeness/name licensing is obtained

IMPORTANT LIMITATIONS:
- No production 3D character models, animations, stadium assets, commentary, or polished UI are included.
- No real batting-ball collision scoring or complete cricket rules yet.
- Online multiplayer, matchmaking, anti-cheat, secure coin transactions, tournament backend,
  player inventory persistence, and rewards are NOT implemented in this starter.
- CoinWallet is local prototype code only. Never use it for real-money purchases or online rewards.
- The swipe script is a basic input prototype and needs Inspector wiring to the bat Transform.
- The scene is generated from primitives so it can be opened without downloading paid assets.

HOW TO OPEN:
1. Extract the ZIP.
2. Open Unity Hub on a supported Windows/Mac/Linux development computer.
3. Add the extracted project folder.
4. Open with Unity 6.0 (6000.0.x).
5. Create an empty scene named Main and save it under Assets/Scenes, or run the project;
   ProjectBootstrap creates a basic test ground at runtime.
6. For Android builds, install Android Build Support, SDK, NDK and OpenJDK in Unity Hub.

MOBILE-ONLY WORKFLOW:
A phone cannot run the full Unity Editor. You can store/manage this project from Android,
but the Unity project needs a remote/cloud Unity build machine or a computer to compile.
Unity Build Automation requires a source-control repository and a configured cloud build.

NEXT DEVELOPMENT PHASES:
1. Replace primitives with licensed/custom 3D cricketer models and rigged animations.
2. Implement real batting timing, ball physics, shot direction, bowling, fielding and wicketkeeping.
3. Add AI opponent and complete innings/over/rules engine.
4. Add authoritative online multiplayer server/session sync, reconnect and anti-cheat.
5. Add secure server-side virtual coin wallet, 20 CC entry and 60 CC winner payout.
6. Add English premium UI, audio, accessibility, performance profiles and Android testing.

Do not advertise this scaffold as a finished 3D multiplayer game.
