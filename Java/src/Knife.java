public class Knife {
	public void CutCab(Cabbage c) {
		if (!c.cutted) {
			c.cutted = true;
		}
	}

	public void CutPot(Potato p) {
		if (!p.cutted) {
			p.cutted = true;
		}
	}
}
