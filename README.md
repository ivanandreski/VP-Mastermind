# Mastermind

![Project Image](https://github.com/IvanAndreski/VP-Mastermind/blob/cc8407fe85569c338908f194c55cffaa6483ed20/Screenshots/Logo.png)

---

### Содржина

- [Објаснување на проблем](#објаснување-на-проблем)
- [Опис на решение](#решение)
- [Опис на класата AudioPlayer код](#изворен-код)
- [Изглед на апликацијата и упатство за користење](#изглед-и-упатство)
- [Информации за авторите](#информации-за-авторите)

---

## Објаснување на проблем

Во нашата апликација пробуваме да ја имплементираме друштвената играта Mastermind чија цел е да се погоди одредена низа од 4 обоени кругчиња (секое кругче може да има 1 од 8 бои). Играта се игра така што играчот има 8 обиди и 100 секунди за да ја погоди точната низа. После секој обид играчот добива повратна информација за бројот на точно погодени кругчиња како и за бројот на точно погодени бои кои не се наоѓаат на точната позиција.

[Back To The Top](#Mastermind)

---

## Решение

Главна класа со која се имплементира играта е класата Game. Тука се чуваат методи за почеток на играта, крај на играта, вчитување на изглед на играта, отварање на главното мени и други функционални методи.
Изгледот на играта се чува во класата Scene во која се чува и ажурира изгледот на прозорецот во текот на играта. Во неа исто така се чува објект од класата Result кој се користи за проверување на точноста на обидите на играчот. Дополнително се чува низа од сите претходни обиди која се користи при исцртувањето на прозорецот.
Низата од обоени кругчиња која треба да се погоди се чува во низа од бои (class Color) ResultArray во класата Result. При даден обид се генерира низа од бои GuessArray која се споредува со ResultArray. Доколку тие се совпаѓаат играчот победува и му се нуди опција за нова игра. Доколку помине времето од 100 секунди или играчот 8 пати неуспешно се обиде да ја погоди низата играта завршува и играчот губи. Проверките за крајот на играта се извршуваат во класата Game во методите bntCheck_Click и timerUpdateProgressBar_Tick.

[Back To The Top](#Mastermind)

---

## Изворен код

За имплементација на звучни ефекти во играта ја користиме класата AudioPlayer. Во неа чуваме по еден објект од класите SoundPlayer и Random кои се веќе постоечки во С#. Звучните ефекти се поделени на 3 категории (почеток на играта, обид на играчот и крај на играта). За сите овие настани се чува метода за пуштање звук во класата AudioPlayer. Овие методи со помош на објектот од класата Random на случаен начин си избира еден звук кој соодвестува со настанот.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class AudioPlayer {
        public SoundPlayer SoundPlayer { get; set; }
        public Random Random { get; set; }

        public AudioPlayer() {
            SoundPlayer = new SoundPlayer();
            Random = new Random();
        }

        public void PlayStart() {
            SoundPlayer.SoundLocation = string.Format("../../audio/start/Braum.start{0}.wav", Random.Next(1, 6));
            SoundPlayer.Play();
        }

        public void PlayMove() {
            SoundPlayer.SoundLocation = string.Format("../../audio/move/Braum.move{0}.wav", Random.Next(1, 4));
            SoundPlayer.Play();
        }

        public void PlayEnd() {
            SoundPlayer.SoundLocation = string.Format("../../audio/end/Braum.end{0}.wav", Random.Next(1, 5));
            SoundPlayer.Play();
        }
    }
}
```

[Back To The Top](#Mastermind)

---

## Изглед и упатство

При стартување на апликацијата се отвара почетниот прозорец.
![Project Image](https://github.com/IvanAndreski/VP-Mastermind/blob/ad5b2048c3ea2d92439d4252a721258c5bc42d5c/Screenshots/Main%20Menu.jpg)

Тука имаме 3 опции: New Game, Instructions, Exit Game.
Со избор на копчето New Game се започнува нова игра.
![Project Image](https://github.com/IvanAndreski/VP-Mastermind/blob/48c1d2f57863085d6319ed5a67f71d95585dd26a/Screenshots/New%20Game%20Empty.jpg)

Во овој прозорец можеме да избереме некоја од 8те бои и со таа боја да ги боиме кругчињата од следниот обид. Кругчето околу курсорот се обојува со бојата која ни е селектирана.
Со клик на копчето Check се проверува тековниот обид и соодветно за него добиваме повратана информација.
![Project Image](https://github.com/IvanAndreski/VP-Mastermind/blob/6b12b33aabaab0f5a54022d7ddd4ca1aca3da5d4/Screenshots/New%20Game%20Progress.jpg)

Црвените кругчиња означуваат точно погодена боја на точна позиција, а жолтите означуваат точно погодена боја на грешна позиција. Позицијата на црвените и жолтите кругчиња не соодвествува со вистинската позиција на кругчињата.
Со клик на копчето Restart се започнува нова игра, a клик на копчетп Main Menu се враќаме на почетниот прозорец.
При клик на копчето Instructions на главниот прозорец се прикажува прозорец со краток опис на правилата и начинот на играње на играта.
![Project Image](https://github.com/IvanAndreski/VP-Mastermind/blob/1c32f776257e27f397ad32fbb861106c6fd604dd/Screenshots/Instructions.jpg)

Со клик на копчето Exit Game на главниот прозорец се излегува од апликацијата.

[Back To The Top](#Mastermind)

---

## Информации за авторите

- Иван Андрески 191239
- Андреј Тавчиоски 191019
- Димитар Митровски 191076

[Back To The Top](#Mastermind)
