var Point = (function () {

    function Point(x, y) {
        function dump() {
            console.log(x + ", " + y);
        }

        function move(dx, dy) {
            x += dx;
            y += dy;
        }

        function reset() {
            x = 0;
            y = 0;
        }

        return {
            dump: dump,
            move: move,
            reset: reset,
        };
    }

    return Point;
})();


