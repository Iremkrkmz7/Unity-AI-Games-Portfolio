# 🎮 NPC AI — FSM Tabanlı Düşman Yapay Zekası / FSM-Based Enemy AI
 
> 🇹🇷 Türkçe aşağıda / 🇬🇧 English below
 
---
 
## 🇬🇧 English
 
### What is this?
A simple but solid **enemy AI** built in Unity using a **Finite State Machine (FSM)** pattern. The NPC detects the player, chases them, and triggers a Game Over when it catches up.
 
### States
| State | Condition | Behaviour |
|-------|-----------|-----------|
| **Idle** | Player out of range | NPC stands still |
| **Chase** | Player within detection range | NPC moves toward player |
| **Attack** | Player within attack range | Game Over triggered |
 
### How it works
```
Player enters detection range
        ↓
    [ Chase ]  →  Player in attack range  →  [ Attack ] → Game Over
        ↑
Player leaves range
        ↓
    [ Idle ]
```
 
### Setup
1. Add `NPC.cs` to your enemy GameObject
2. Add a `NavMeshAgent` component to the same object
3. Bake a NavMesh on your scene (Window → AI → Navigation)
4. Assign `gameOverText` in the Inspector (a UI Text/Panel)
5. Tag your player object as `Player`
6. Hit Play
### Inspector Settings
| Field | Default | Description |
|-------|---------|-------------|
| Detection Range | 10 | How far the NPC can see |
| Attack Range | 0.5 | How close to trigger Game Over |
 
### Tech
- Unity (any version with NavMesh)
- C#
- UnityEngine.AI (NavMeshAgent)
- FSM pattern
---
 
## 🇹🇷 Türkçe
 
### Bu ne?
Unity'de **Finite State Machine (FSM)** pattern'i kullanılarak yapılmış basit ama sağlam bir **düşman yapay zekası**. NPC oyuncuyu algılar, kovalayıp yakalarsa Game Over tetiklenir.
 
### Durumlar (States)
| Durum | Koşul | Davranış |
|-------|-------|----------|
| **Idle** | Oyuncu menzil dışında | NPC bekler |
| **Chase** | Oyuncu görüş menziline girdi | NPC oyuncuya doğru koşar |
| **Attack** | Oyuncu saldırı menziline girdi | Game Over tetiklenir |
 
### Nasıl çalışır?
```
Oyuncu görüş menziline girer
        ↓
    [ Chase ]  →  Oyuncu saldırı menziline girer  →  [ Attack ] → Game Over
        ↑
Oyuncu uzaklaşır
        ↓
    [ Idle ]
```
 
### Kurulum
1. `NPC.cs` dosyasını düşman GameObject'ine ekle
2. Aynı objeye `NavMeshAgent` component'i ekle
3. Sahneye NavMesh pişir (Window → AI → Navigation → Bake)
4. Inspector'da `gameOverText` alanına bir UI Text/Panel ata
5. Oyuncu objesini `Player` olarak etiketle
6. Play'e bas
### Inspector Ayarları
| Alan | Varsayılan | Açıklama |
|------|-----------|----------|
| Detection Range | 10 | NPC'nin görüş menzili |
| Attack Range | 0.5 | Game Over tetiklenme mesafesi |
 
### Kullanılan Teknolojiler
- Unity (NavMesh destekleyen her versiyon)
- C#
- UnityEngine.AI (NavMeshAgent)
- FSM (Finite State Machine) pattern
---
 
## 📁 Dosyalar / Files
 
```
📦 NPC-AI
 ┣ 📜 NPC.cs        ← Düşman AI / Enemy AI
 ┣ 📜 Player.cs     ← NavMesh ile oyuncu hareketi / Player movement
 ┗ 📜 README.md
```
 
---
 
## 🔗 Proje Serisi / Project Series
 
| # | Proje | Açıklama |
|---|-------|----------|
| 1 | PCG Level Generator | Rastgele level üretimi |
| 2 | **NPC AI** ← bu repo | FSM tabanlı düşman |
| 3 | PCG + NPC (coming soon) | İkisinin birleşimi |

### 📹 Demo:
<img width="1920" height="992" alt="demo mp4" src="https://github.com/user-attachments/assets/a7a375df-96ae-48cb-bc90-29e489a54171" />


---

