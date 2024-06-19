Du skal lage en kalkulator som skal beregne areal og omkrets til en trekant, rektangel,og et kvadrat ved hjelp av arv. Start med å finne en baseklasse med de egenskapene som er felles, hver klasse må så ha sin egen implementasjon for beregningene.

```
foreach(var shape in shapes)
{
Console.WriteLine(shape.GetCircumference());
Console.WriteLine(shape.GetArea());
}
```

Skal printe ut noe som feks:
```
triangle is 34
rectangle circumference is 44
square circumference is 55

triangle area is 34
rectangle areais 44
square area is 55
```