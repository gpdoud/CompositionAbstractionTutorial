using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAbstractionTutorial {
    class Rect {

        public Quad quad { get; set; }

        public int Perimeter() {
            var p = quad.Perimeter();
            var pi = Convert.ToInt32(p);
            return pi;
        }
        public double PerimeterAsDouble() {
            return quad.Perimeter();
        }
        public int Area() {
            return Convert.ToInt32(quad.Side1 * quad.Side2);
        }

        public Rect() { }

        public Rect(int s1, int s2) {
            this.quad = new Quad(s1, s2, s1, s2);
        }
    }
}
