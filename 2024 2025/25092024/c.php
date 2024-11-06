<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
</head>
<link rel="stylesheet" href="style.css">
<body>
Witam w moim sklepie spożywczym online 
<p>Jestem Witek i sprzedam Ci najlepsze jaja z wolnego wybiegu.</p>

<div class="container">
    <div>
        <?php


        if (isset($_POST['submit'])) {

        $mak=$_POST['mak'];
        $sol=$_POST['sol'];
        $cuk=$_POST['cuk'];
        $wod=$_POST['wod'];
        $ene=$_POST['ene'];
        $jag=$_POST['jag'];
        $pla=$_POST['pla'];
        $kro=$_POST['kro'];
        $bul=$_POST['bul'];
        $slo=$_POST['slo'];
        if ((empty($mak) && $mak !=0) || (empty($sol) && $sol !=0) || (empty($cuk) && $cuk !=0) || (empty($wod) && $wod !=0) || (empty($ene) && $ene !=0) ||
            (empty($jag) && $jag !=0) || (empty($pla) && $pla !=0) || (empty($kro) && $kro !=0) || (empty($bul) && $bul !=0) || (empty($slo) && $slo !=0) )


        { echo '<br> nie uzupełniłeś wszystkich pól formularza. spróbuj ponownie';}
        else
        {
        echo 'Oto państwa zamówienie: <br>';
        echo 'Liczba mąki: '. $_POST['mak'] . '<br>';
        echo 'Liczba soli: '. $_POST['sol'] . '<br>';
        echo 'Liczba cukru: '. $_POST['cuk'] . '<br>';
        echo 'Liczba wody: '. $_POST['wod'] . '<br>';
        echo 'Liczba napoi energetycznych: '. $_POST['ene'] . '<br>';
        echo 'Liczba Jaggermaistera: '. $_POST['jag'] . '<br>';
        echo 'Liczba płatków zbożowych: '. $_POST['pla'] . '<br>';
        echo 'Liczba chleba: '. $_POST['kro'] . '<br>';
        echo 'Liczba bułek: '. $_POST['bul'] . '<br>';
        echo 'Liczba bułek słodkich: '. $_POST['slo'] . '<br>';
        
        define ('cena_mak',15);
        define ('cena_sol',10);
        define ('cena_cuk',73);
        define ('cena_wod',23);
        define ('cena_ene',12);
        define ('cena_jag',5);
        define ('cena_pla',5);
        define ('cena_kro',8);
        define ('cena_bul',3);
        define ('cena_slo',9);

        $suma=0;
        $suma=$mak*cena_mak+$sol*cena_sol+$cuk*cena_cuk+$wod*cena_wod+$ene*cena_ene+$jag*cena_jag+$pla*cena_pla+$kro*cena_kro+$bul*cena_bul+$slo*cena_slo;
        echo '<br> Wartość zamówienia wynosi '. $suma . ' złotych (netto) <br>';

        $vat=0.23;
        $suma_vat=$suma*$vat+$suma;
            echo '<br> Wartość zamówienia wynosi (VAT) '. number_format($suma_vat,2) . ' złotych <br>';

            if ($suma_vat < 70) 
            { echo ' <br> Nie uzyskano zniżki';
                $znizka=0;}
        elseif ($suma_vat >= 70 && $suma_vat < 100)
            {echo '<br> Uzyskano zniżkę 5%';
                $znizka=0.05;}
        elseif ($suma_vat >= 100 && $suma_vat < 125)
            {echo '<br> Uzyskano zniżkę 10%';
                $znizka=0.1;}
        elseif ($suma_vat >= 125 && $suma_vat < 200)
            {echo '<br> Uzyskano zniżkę 15%';
                $znizka=0.15;}
        elseif ($suma_vat >= 200)
            {echo '<br> Uzyskano zniżkę 20%';
                $znizka=0.2;
            }
            
            $suma_znizka=$suma_vat-($suma_vat*$znizka);
            echo '<br> Wartość zamówienia po zniżce: '. $suma_znizka . ' zł <br>';
            echo '<br><div id="koniec1"><br> Koszty transportu </div><br>';
            echo '<div id="koniec"> <table> <tr> <td> ---- </td> <td> Odległość w km ---- </td> <td> Koszty w zł ---- </td> </tr>';
            $x=1;
            for ($i=3;$i<=15;$i+=2){
                echo '<tr> <td> '. $x++ .' </td> <td> '. $i .' </td> <td>' . $i+3 . '</td> </tr>';
            }
            echo '</table></div>';



        }
        }
        ?>
    </div>
    <form action="komis.php" method="POST">
    Mąka <input type="text" name="mak"><br>
    Sól <input type="text" name="sol"><br>
    Cukier <input type="text" name="cuk"><br>
    Woda mineralna <input type="text" name="wod"><br>
    Napój energetyczny <input type="text" name="ene"><br>
    Likier Jagermeister <input type="text" name="jag"><br>
    Płatki zbożowe <input type="text" name="pla"><br>
    Chleb krojony <input type="text" name="kro"><br>
    Bułki <input type="text" name="bul"><br>
    Bułki słodkie <input type="text" name="slo"><br>

    <input type="submit" value="Wyślij" name="submit"><br>
    </form>
</div>





  
</body>
</html>