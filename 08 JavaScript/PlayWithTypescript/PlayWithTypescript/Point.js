define(["require", "exports"], function (require, exports) {
    var Point = (function () {
        function Point(x, y) {
            this.x = x;
            this.y = y;
        }
        Point.prototype.move = function (dx, dy) {
            var _this = this;
            setTimeout(function () {
                _this.x += dx;
                _this.y += dy;
            }, 1000);
        };
        Point.prototype.dump = function () {
            console.log(this.x + ", " + this.y);
        };
        return Point;
    })();
    exports.Point = Point;
});
//# sourceMappingURL=Point.js.map