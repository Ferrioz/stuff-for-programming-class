
let exampleArr = [1, 9, 4, 2, 19, 12];

function sortIntArray(unsortedArray) {
    let flags = 0;
    let temp;
    for(let i = 0; i < unsortedArray.length; i++) {
        if(unsortedArray[i] != unsortedArray.length-1 && i != 0 && (unsortedArray[i-1] > unsortedArray[i])) {
            flags++;
            temp = unsortedArray[i - 1];
            unsortedArray[i - 1] = unsortedArray[i];
            unsortedArray[i] = temp;
        }
    }
    if(flags == 0) {
        return unsortedArray;
    }
    else { return sortIntArray(unsortedArray); }
}

function Main() {
    console.log("Unsorted array.");
    let unsortedText = "";
    for(let i = 0; i < exampleArr.length; i++) {
        unsortedText += exampleArr[i].toString();
        if(i != exampleArr.length-1) {
            unsortedText += ", ";
        }
    }
    console.log(unsortedText + "\n\n");
    let sortedArray = sortIntArray(exampleArr);
    let sortedText = "";
    console.log("Sorted array.");
    for(let i = 0; i < sortedArray.length; i++) {
        sortedText += sortedArray[i].toString();
        if(i != sortedArray.length-1) {
            sortedText += ", ";
        }
    }
    console.log(sortedText);
}

Main();