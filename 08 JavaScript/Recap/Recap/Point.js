var Point = (function () {

    function Point(x, y) {
        this.x = x;
        this.y = y;
    }

    Point.prototype.dump = function () {
        console.log(this.x + ", " + this.y);
    }

    return Point;
})();


