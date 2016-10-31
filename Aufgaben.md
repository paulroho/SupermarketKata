# Supermarkt Kata


Du arbeitest in einem Team, das ein System für einen Supermarkt schreibt.
Deine Aufgabe ist es, Features im Bereich der **Kassa** zu implementieren.
Die nächsten Items im Backlog drehen sich um das **Scannen** von Produkten (mittels EAN-Code) und die Informationen für die **Rechnung** zusammenzustellen.

Es gibt Akzeptanztests (mit Infrastruktur) als Leitlinie für die Umsetzung.

### Hinweis

Widerstehe der Versuchung, alles auf einmal runterzuprogrammieren bis der Akzeptanztest durchläuft (*"... sollte ja nicht so schwierig sein ..."*).

Insbesondere
* verwende **TDD**, schreibe also keinen Produktionscode, wenn es keinen **fokussierten Unit-Test** gibt, der zeigt, dass eine Funktionalität fehlt.
* arbeite **in kleinen Schritten**

---

## Aufgabe 0 - Mit dem bestehenden Code vertraut machen
Du solltest ein Grundverständnis haben vom
* bestehenden DomainModel
* Code der die Specs mit dem DomainModel verbindet

---

## Aufgabe 1 - Die API für die Kassa definieren
- Das Interface für die Kassa sollte definiert sein.
- Die TODOs im Spec-Driver sollten erledigt sein.

---

## Aufgabe 2 - Implementiere einen einfachen Kassiervorgang
> Mach das Feature "Simple checkout" grün


Die Rechnung soll
- für jedes Produkt eine Buchungszeile
- eine USt Zeile
- die richtige Summe (inkl. USt)

aufweisen.

---

## Aufgabe 3 - Die Kassa soll unterschiedliche Steuersätze unterstützen

> Mach das Feature "Advanced checkout" grün

Die Rechnung soll
- für jedes Produkt eine Buchungszeile
- **NEU:** je vorkommendem Steuersatz eine Zeile
- die richtige Summe (inkl. USt)

aufweisen.
