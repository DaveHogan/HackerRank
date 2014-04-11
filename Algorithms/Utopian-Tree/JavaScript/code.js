function growTree(input) {
    var args = input.split("\n");
    var testcases = args[0];

    for (var i = 0; i < testcases; ++i) {
        var cycle = args[i + 1];

        var treeSize = 1;
        for (var c = 0; c < cycle; ++c) {
            if (c % 2) {
                treeSize = treeSize + 1; // Add 1 - Summer 
            } else {
                treeSize += treeSize; // Double - Monsoon Season
            }
        }
        console.log(treeSize);
    }
}

// Boiler plate code for HackerRank
process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function(input) {
    _input = input;
});

process.stdin.on("end", function() {
    growTree(_input);
});