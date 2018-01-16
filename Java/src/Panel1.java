import javax.swing.JPanel;
import java.awt.Graphics;

public class Panel1 extends JPanel {
	ITech inter;

	public Panel1(ITech temp) {
		inter = temp;
	}

	public void paint(Graphics g) {
		super.paint(g);
		Draw1(g, inter);
	}

	public void Draw1(Graphics g, ITech inter) {
		if (inter != null) {
			inter.moveSudno(g);
		}
	}
}
