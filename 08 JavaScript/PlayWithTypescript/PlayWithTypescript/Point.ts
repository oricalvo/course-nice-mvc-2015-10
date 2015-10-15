export class Point {
    x;
    y;

    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    move(dx, dy) {
        setTimeout(() =>  {
            this.x += dx;
            this.y += dy;
        }, 1000);
    }

    dump() {
        console.log(this.x + ", " + this.y);
    }
}
