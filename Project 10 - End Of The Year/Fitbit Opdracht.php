<?php
$dag = array("maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag");
$aantal = array(11214, 10514, 11250, 10552, 10501, 10316, 12016);

$totaal = 0;

for ($i=0; $i<7; $i++){
    $totaal = $totaal + $aantal[$i];
}
$totaal = $totaal / $i;

echo "Gemiddeld aantal stappen = $totaal <br>";

echo "Dagen met meer stappen dan gemiddeld:";

echo "<TABLE>";
for ($i=0; $i<7; $i++){
    if($aantal[$i] > $totaal){
        echo "<TR><TD>".$dag[$i]."</TD><TD>".$aantal[$i]."</TD></TR>";
    }
}
echo "</TABLE>";
?>