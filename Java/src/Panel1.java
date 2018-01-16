import javax.swing.JPanel;
import java.awt.Graphics;

public class Panel1 extends JPanel {
	Parking inter;

	public Panel1(Parking temp) {
		inter = temp;
	}

	public void paint(Graphics g) {
		super.paint(g);
		inter.Draw(g);
	}
}
