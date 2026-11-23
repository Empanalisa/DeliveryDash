<div align="center">

# 🍦 Delivery Dash

**A top-down 2D delivery game built in Unity. Drive an ice cream van around a neighborhood, pick up packages, deliver them to customers and grab speed boosts along the way.**

![Unity](https://img.shields.io/badge/Unity-6000.4-000000?logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![2D](https://img.shields.io/badge/2D-URP-5C5C5C)

</div>

---

## About

Delivery Dash is a small top-down driving game that I built in **Unity 6** with **C#**. You drive an ice cream van through a neighborhood of houses, trees, fences and streetlights. Collect a package, drive it to a waiting customer, and use boost pickups to get there faster. I made it to practice core Unity skills: input handling, movement, collision and trigger events, tags, prefabs and particle effects.

## How to play

1. Drive to a **package pickup** to grab it. A particle effect shows you're carrying one.
2. Drive to a **customer** to deliver it. You can only carry one package at a time.
3. Drive over a **boost item** to speed up. A "Boost!" message appears on screen.
4. Bump into the world (fences, houses and other obstacles) and you drop back to regular speed.

### Controls

| Action | Key |
| --- | --- |
| Drive forward | `W` |
| Reverse | `S` |
| Steer left | `A` |
| Steer right | `D` |

## Features

- **Pickup and delivery loop.** A package must be picked up before a customer will accept a delivery, and a delivery only counts once per pickup.
- **Speed boost.** A boost item raises your speed and shows a "Boost!" label. Crashing into the world resets you to regular speed.
- **Frame-rate independent movement.** Driving and steering are scaled by `Time.deltaTime`, so the van feels the same on any machine.
- **Prefab-based objects.** Packages, customers and boost items are prefabs, so more can be dropped into the level.
- **Tag-based interactions.** Collisions are handled through Unity tags (`Package`, `Customer`, `Boost`, `WorldCollision`).

## How it's built

All of the game logic lives in `Assets/Scripts/`:

| Script | What it does |
| --- | --- |
| `Driver.cs` | Reads keyboard input, moves and steers the van, and handles boost pickups and speed resets |
| `Delivery.cs` | Tracks whether the van has a package, plays the carrying effect and completes deliveries |

**Unity features used:** the Input System package, trigger and collision events (`OnTriggerEnter2D`, `OnCollisionEnter2D`), tags, prefabs, TextMesh Pro for UI text and particle systems.

## Getting started

1. Install [Unity Hub](https://unity.com/download) and Unity **6000.4.2f1**.
2. Clone the repo:
   ```bash
   git clone https://github.com/Empanalisa/DeliveryDash.git
   ```
3. In Unity Hub, choose **Add → Add project from disk** and select the cloned folder. The first import takes a few minutes.
4. Open `Assets/Scenes/SampleScene` and press **Play**.

## Project structure

```
DeliveryDash/
├── Assets/
│   ├── Scripts/                          # Driver.cs and Delivery.cs
│   ├── Prefabs/                          # Package pickup, customer and boost item
│   ├── Scenes/                           # SampleScene (the game level)
│   └── GameDev.tv - Delivery Dash Assets # Art: van, houses, props and tiles
├── Packages/                             # Unity package manifest
└── ProjectSettings/                      # Unity project settings
```

## Credits

Art assets (the van, houses, props and background tiles) come from the **GameDev.tv Delivery Dash asset pack**, used under the license in `Assets/GameDev.tv - Delivery Dash Assets/GameDev.tv Asset License Agreement.txt`. Copyright 2025, GameDev.tv.
