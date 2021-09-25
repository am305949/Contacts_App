function addNumber(number) {
    var num = document.forms[0].Number;
    num.value += number;
}

function removeNumber() {
    var num = document.forms[0].Number.value;
    var last_char = num.charAt(num.length - 1);
    var new_num = num.slice(0, num.length - 1);
    document.forms[0].Number.value = new_num;
}

function emptyNumber() {
    document.forms[0].Number.value = "";
}