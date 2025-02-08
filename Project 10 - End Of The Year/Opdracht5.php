<?php
if (isset($_POST['kleuren'])){
        $kleur1 = $_POST['kleuren'];
} else {
        $kleur1 = "white";
}

if (isset($_POST['kleuren2'])){
        $kleur2 = $_POST['kleuren2'];
} else {
        $kleur2 = "black";
}
echo "<html>
<head>
<title>PHP kleurenpracht</title>

<style>
        body {background-color: $kleur1; color: $kleur2; padding:5em;}
</style>

</head>

<body>
<form name='kleurenkeuze' method='POST' action='Opdracht5.php'>
Kies 2 kleuren:
<br/>
Achtergrondkleur: <select name='kleuren' id='kleuren'>
                <option value='red'>Rood</option>
                <option value='yellow'>Geel</option>
                <option value='blue'>Blauw</option>
                <option value='black'>Zwart</option>
                <option value='white'>Wit</option>
                <option value='green'>Groen</option>
            </select>
            <br/>
Font kleur: <select name='kleuren2' id='kleuren2'>
                <option value='red'>Rood</option>
                <option value='yellow'>Geel</option>
                <option value='blue'>Blauw</option>
                <option value='black'>Zwart</option>
                <option value='white'>Wit</option>
                <option value='green'>Groen</option>
            </select>
            <br/>
            <br/>
            <input type='submit' value='Verander kleuren'>
</form>
<h1>Delftse onderzoekers ontrafelen de werking van de fiets</h1>
<p>
Delft - Wiskundigen breken zich al bijna anderhalve eeuw het hoofd over de
fiets. Hoe is het toch mogelijk dat een rijdende fiets uit zichzelf al zo
stabiel is ? Delftse onderzoekers, in samenwerking met collega's van Cornell
University en de universiteit van Nottingham UK, menen nu het ultieme
fietsmodel gemaakt te hebben. Zij vertellen hierover in de nieuwe editie
van Delft Integraal, het wetenschapsmagazine van de TU Delft.
</p>
<p>
Fietsfabrikanten hebben nooit geweten hoe een fiets precies werkt, vertelt
dr.ir. Arend Schwab van de faculteit Werktuigbouwkunde, Maritieme Techniek
en Technische Materiaalwetenschappen. Ze hebben hun fietsen altijd
experimenteel moeten verbeteren. In ons model kunnen ze alle factoren die
van invloed zijn op de besturingseigenschappen in de computer invoeren. Het
model rekent vervolgens uit hoe de fiets zich zal gedragen bij
verschillende snelheden. Het model is onlangs gepubliceerd in het
wetenschappelijke tijdschrift PROCEEDINGS OF THE ROYAL SOCIETY series A.
</p>
<p>
Een model dat aangeeft of een ontwerp een nerveuze fiets oplevert of juist een stabiel exemplaar voor bijvoorbeeld ouderen, daar
heeft de fietsindustrie wel oren naar. Hoofd productontwikkeling van fietsfabrikant Batavus, Rob van Regenmortel, volgt het onderzoek van Arend
Schwab en collega-onderzoeker ir. Jodi Kooijman op de voet.
</p>
<p>
Van Regenmortel: Bij het ontwerpen van onze fietsen werken we van oudsher
met drie parameters: de algehele geometrie, de afstand tussen de assen en
de hoek waaronder de voorvork naar beneden steekt. Die keuzes hebben alle
fietsfabrikanten ooit eens gemaakt en zijn er nauwelijks van afgeweken
omdat de fietsen het goed bleken te doen. Maar met het model hopen we
binnenkort gerichter fietsen te kunnen ontwerpen voor speciale doelgroepen.
</p>
<p>
Rijgedrag Rob Van Regenmortel wil met Arend Schwab en Jodi Kooijman
meewerken aan een vervolgproject, waarbij ook het rijgedrag van de
bestuurder wordt onderzocht. Het uiteindelijke doel van dit fietsonderzoek
is om het menselijke rijgedrag mee te nemen in het model, zodat ze het
samenspel van de fiets en de bestuurder kunnen onderzoeken. Hierdoor
kunnen we in principe voor iedereen een fiets op maat maken, zegt Van
Regenmortel. Mensen die moeilijk hun evenwicht kunnen houden, hoeven dan
niet meer op een driewieler te rijden.
</p>

</body>
</html>";


?>