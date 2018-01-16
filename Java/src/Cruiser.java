import java.awt.Color;
import java.awt.Graphics;

public class Cruiser extends Ship {
	private boolean frontCannon;
	private boolean backCannon;
	private Color dopColor;

	public Cruiser(int maxSpeed, int maxCrew, int displacement, Color color,
			boolean fronCannon, boolean backCannon, Color dopColor) {
		super(maxSpeed, maxCrew, displacement, color);
		this.frontCannon = fronCannon;
		this.backCannon = backCannon;
		this.dopColor = dopColor;
	}

	@Override
	protected void drawNormalSudno(Graphics g) {
		super.drawNormalSudno(g);
		if (frontCannon) {
			g.setColor(dopColor);
			g.fillRect(startX + 80, startY + 10, 20, 20);
			g.setColor(Color.BLACK);
			g.drawRect(startX + 80, startY + 10, 20, 20);
			g.drawRect(startX + 90, startY + 15, 10, 10);
			g.setColor(dopColor);
			g.fillRect(startX + 92, startY + 17, 25, 6);
			g.setColor(Color.BLACK);
			g.drawRect(startX + 92, startY + 17, 25, 6);
		}
		if (backCannon) {
			g.setColor(dopColor);
			g.fillOval(startX - 5, startY + 10, 20, 20);
			g.setColor(Color.BLACK);
			g.drawOval(startX - 5, startY + 10, 20, 20);
			g.drawLine(startX + 5, startY + 15, startX - 7, startY + 15);
			g.drawLine(startX + 5, startY + 25, startX - 7, startY + 25);
		}
	}

	public void setDopColor(Color newColor){
		dopColor = newColor;
	}
}
