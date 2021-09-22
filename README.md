# LA1200_niklaus

#Einführung

In meinem Eintrag zeige ich Ihnen, wie ich in meinem Zahlenratespiel `try` `catch` verwendet habe und für was es nutzbar ist. 
Da ich in meinem Zahleratespiel Mühe mit `try` `catch` hatte, werde ich Ihnen ein Ausschnitt von meinem Code vom Spiel zeigen und Ihnen erklären, wie ich es gemacht habe.

 #Ziele
   1. Der Leser lernt, wie man `try` `catch` in C# programmiert, damit das Programm beim Durchlauf nicht abstürzt, falls der Benutzer etwas falsches angegeben hat.
   2. Der Leser weiss, wofür sie nützlich sind und wie man diese einsetzt.
   3. Der Leser lernt, wie man mit `try` `catch` den Benutzer hinweisen kann, dass es einen Fehler in der Eingabe gab.


Vorteil von `try` `catch`:

Mit `try` `catch` fängt das Programm den Fehler der Benutzereingabe sanft auf. 



Für was benutzt man `try` `catch`?

Mit `try` `catch` wird...
  - ...ein Code-Block ausprobiert (`try`), ob er ohne Laufzeitfehler funktioniert.
  - ...ein Fehler - wenn er passiert - ausgeworfen (`throw`).
  - Wird ein Fehler aufgeworfen, versuchen wir, ihn zu fangen (`catch`).


Ein Beispiel für eine Ausnahmebehandlung zeige ich Ihnen hier:
```csharp
try
{
  Console.Write("Geben Sie bitte eine Zahl ein: ");
  int eingabe=Convert.ToInt32(Console.ReadLine());
  //was hier steht, wird bei Fehler nicht ausgeführt
  //das hier auch nicht
}
```
Mit `try` fordert man das Programm, die Benutzereingabe zu lesen und in eine Zahl zu konvertieren. Wenn das Programm es versucht hat und es nicht funktioniert hat, dann wird `catch` ausgeführt:

```csharp
catch
{
  Console.WriteLine("Ungültige Eingabe.");
  Enviroment.Exit(0);
}
```
Mit `catch` fängt das Programm den Fehler langsam auf und meldet den Fehler dem Benutzer.



Hier zeige ich Ihnen eine `try` `catch`-Schleife von meinem Game:
```csharp
while (!(userguess=randomnumber))
{
     try
      {
        Console.WriteLine("Please write a number between 1 and 100.");
        int userguess = int.Parse(Console.ReadLine());
      }
      catch
      {
        Console.WriteLine("Please write a number between 1 and 100.");
      }
}
```
#Video
Hier zeige ich ein Video vom Durchlauf vom meinem Spiel:

https://youtu.be/YvBJP5Vk1Ps

#Verifikation

Ziel 1: Im ersten und im letzten Code-Block wird die Verwendung von `try` `catch` gezeigt
Ziel 2: Nach den Zielen der Vorteil, die Nutzung und ein Beispiel gezeigt.
Ziel 3: Im Code nach den Zielen wird ein Code gezeigt, der erklärt, wie man den Benutzer über den Fehler informiert.

#Reflexion

Ich habe mich während der Arbeit sehr viel mal von anderen Mitschülern ablenken lassen und konnte deswegen nicht so gut vorankommen. 
Dazu wusste ich nicht, wie mit dem Projekt anzufangen und habe deswegen ungefähr eine halbe Stunde vertrödelt.

Verbesserungsvorschlag:
- Nächstes Mal soll ich am Anfang der Stunde eine To-Do-Liste erstellen, damit ich sofort arbeiten kann und nicht lange überlegen muss.
- Ich soll mich nächstes Mal nicht von den Mitschüler ablenken lassen, indem ich ihnen sage, dass ich mich auf mein Projekt konzentrieren will.
