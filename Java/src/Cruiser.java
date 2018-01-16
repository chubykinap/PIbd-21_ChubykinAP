import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

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

	public Cruiser(String info) {
		super(info);
		String[] str = info.split(";");
		if (str.length == 11) {
			maxSpeed = Integer.parseInt(str[0]);
			maxCrew = Integer.parseInt(str[1]);
			displacement = Integer.parseInt(str[2]);
			color = new Color(Integer.parseInt(str[3]),
					Integer.parseInt(str[4]), Integer.parseInt(str[5]));
			frontCannon = Boolean.parseBoolean(str[6]);
			backCannon = Boolean.parseBoolean(str[7]);
			dopColor = new Color(Integer.parseInt(str[8]),
					Integer.parseInt(str[9]), Integer.parseInt(str[10]));
		}
		CrewCount = 0;
		Random rand = new Random();
		startX = rand.nextInt(190) + 10;
		startY = rand.nextInt(190) + 10;
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

	public void setDopColor(Color newColor) {
		dopColor = newColor;
	}

	@Override
	public String getInfo() {
		return maxSpeed + ";" + maxCrew + ";" + displacement + ";"
				+ color.getRed() + ";" + color.getGreen() + ";"
				+ color.getBlue() + ";" + frontCannon + ";" + backCannon + ";"
				+ dopColor.getRed() + ";" + dopColor.getGreen() + ";"
				+ dopColor.getBlue();
	}
}
