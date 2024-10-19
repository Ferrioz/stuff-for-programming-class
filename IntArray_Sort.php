<?php

$exampleArr = array(
    1, 9, 4, 2, 19, 12
);

function sortIntArray($unsortedArray)
{
    $flags = 0;
    $temp = null;

    for($i = 0; $i < count($unsortedArray); $i++) {
        if($unsortedArray[$i] != count($unsortedArray)-1 && $i != 0 && ($unsortedArray[$i-1] > $unsortedArray[$i])) {

            $flags++;
            $temp = $unsortedArray[$i - 1];
            $unsortedArray[$i - 1] = $unsortedArray[$i];
            $unsortedArray[$i] = $temp;

        }
    }
    if($flags == 0) {
        return $unsortedArray;
    }
    else { return sortIntArray($unsortedArray); }
}

function main($args) {
    echo "Unsorted array.\r\n";
    for($i = 0; $i < count($args); $i++)
    {
        echo $args[$i];
        if($i != count($args) - 1)
        {
            echo ", ";
        }
    }
    echo "\n\n\n";
    $sortedArr = sortIntArray($args);
    echo "Sorted array.\n";
    for($i = 0; $i < count($sortedArr); $i++)
    {
        echo $sortedArr[$i];
        if($i != count($sortedArr) - 1)
        {
            echo ", ";
        }
    }
    echo "\n";
}

main($exampleArr);

?>