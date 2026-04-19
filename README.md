🎮 NPC AI — FSM Tabanlı Düşman Yapay Zekası / FSM-Based Enemy AI

🇹🇷 Türkçe aşağıda / 🇬🇧 English below


🇬🇧 English
What is this?
A simple but solid enemy AI built in Unity using a Finite State Machine (FSM) pattern. The NPC detects the player, chases them, and triggers a Game Over when it catches up.
States
StateConditionBehaviourIdlePlayer out of rangeNPC stands stillChasePlayer within detection rangeNPC moves toward playerAttackPlayer within attack rangeGame Over triggered
How it works
Player enters detection range
        ↓
    [ Chase ]  →  Player in attack range  →  [ Attack ] → Game Over
        ↑
Player leaves range
        ↓
    [ Idle ]
Setup

Add NPC.cs to your enemy GameObject
Add a NavMeshAgent component to the same object
Bake a NavMesh on your scene (Window → AI → Navigation)
Assign gameOverText in the Inspector (a UI Text/Panel)
Tag your player object as Player
Hit Play

Inspector Settings
FieldDefaultDescriptionDetection Range10How far the NPC can seeAttack Range0.5How close to trigger Game Over
Tech

Unity (any version with NavMesh)
C#
UnityEngine.AI (NavMeshAgent)
FSM pattern


🇹🇷 Türkçe
Bu ne?
Unity'de Finite State Machine (FSM) pattern'i kullanılarak yapılmış basit ama sağlam bir düşman yapay zekası. NPC oyuncuyu algılar, kovalayıp yakalarsa Game Over tetiklenir.
Durumlar (States)
DurumKoşulDavranışIdleOyuncu menzil dışındaNPC beklerChaseOyuncu görüş menziline girdiNPC oyuncuya doğru koşarAttackOyuncu saldırı menziline girdiGame Over tetiklenir
Nasıl çalışır?
Oyuncu görüş menziline girer
        ↓
    [ Chase ]  →  Oyuncu saldırı menziline girer  →  [ Attack ] → Game Over
        ↑
Oyuncu uzaklaşır
        ↓
    [ Idle ]
Kurulum

NPC.cs dosyasını düşman GameObject'ine ekle
Aynı objeye NavMeshAgent component'i ekle
Sahneye NavMesh pişir (Window → AI → Navigation → Bake)
Inspector'da gameOverText alanına bir UI Text/Panel ata
Oyuncu objesini Player olarak etiketle
Play'e bas

Inspector Ayarları
AlanVarsayılanAçıklamaDetection Range10NPC'nin görüş menziliAttack Range0.5Game Over tetiklenme mesafesi
Kullanılan Teknolojiler

Unity (NavMesh destekleyen her versiyon)
C#
UnityEngine.AI (NavMeshAgent)
FSM (Finite State Machine) pattern


📁 Dosyalar / Files
📦 NPC-AI
 ┣ 📜 NPC.cs        ← Düşman AI / Enemy AI
 ┣ 📜 Player.cs     ← NavMesh ile oyuncu hareketi / Player movement
 ┗ 📜 README.md


### 📹 Demo:
<img width="1920" height="992" alt="demo mp4" src="https://github.com/user-attachments/assets/a7a375df-96ae-48cb-bc90-29e489a54171" />


---

