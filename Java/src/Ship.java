import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.util.Random;

public class Ship extends Sudno {
	public Ship(int maxSpeed, int maxCrew, int displacement, Color color) {
		this.maxSpeed = maxSpeed;
		this.maxCrew = maxCrew;
		this.color = color;
		this.displacement = displacement;
		CrewCount = 0;
		Random rand = new Random();
		startX = rand.nextInt(190) + 10;
		startY = rand.nextInt(190) + 10;
	}

	public Ship(String info) {
		String[] str = info.split(";");
		if (str.length == 6) {
			maxSpeed = Integer.parseInt(str[0]);
			maxCrew = Integer.parseInt(str[1]);
			displacement = Integer.parseInt(str[2]);
			color = new Color(Integer.parseInt(str[3]),
					Integer.parseInt(str[4]), Integer.parseInt(str[5]));
		}
		CrewCount = 0;
		Random rand = new Random();
		startX = rand.nextInt(190) + 10;
		startY = rand.nextInt(190) + 10;
	}

	protected void setMaxSpeed(int value) {
		if (value > 0 && value < 40) {
			super.maxSpeed = value;
		} else {
			super.maxSpeed = 20;
		}
	}

	public int getMaxSpeed() {
		return super.maxSpeed;
	}

	protected void setMaxCrew(int value) {
		if (value > 100 && value < 400) {
			super.maxCrew = value;
		} else {
			super.maxCrew = 300;
		}
	}

	public int getMaxCrew() {
		return super.maxCrew;
	}

	protected void setDisplacement(int value) {
		if (value > 8000 && value < 12000) {
			super.displacement = value;
		} else {
			super.displacement = 9000;
		}
	}

	public int getDisplacement() {
		return super.displacement;
	}

	@Override
	public void moveSudno(Graphics g) {
		startX += (maxSpeed * 50 / (displacement / 100))
				/ (CrewCount == 0 ? 1 : CrewCount);
		drawSudno(g);
	}

	@Override
	public void drawSudno(Graphics g) {
		drawNormalSudno(g);
	}

	protected void drawNormalSudno(Graphics g) {
		Graphics2D g2 = (Graphics2D) g;
		BasicStroke pen1 = new BasicStroke(1);
		g2.setStroke(pen1);
		g2.setColor(new Color(244, 164, 96));
		g2.fillRect(startX - 10, startY, 70, 40);
		g2.fillOval(startX, startY, 120, 40);
		g2.setColor(Color.BLACK);
		g2.drawOval(startX, startY, 120, 40);
		g2.drawRect(startX - 10, startY, 70, 40);

		g2.setColor(color);
		g2.fillRect(startX - 10, startY + 5, 30, 30);
		g2.setColor(Color.BLACK);
		g2.drawRect(startX - 10, startY + 5, 30, 30);

		g2.setColor(color);
		g2.fillRect(startX + 30, startY + 5, 45, 30);
		g2.fillRect(startX + 30, startY + 10, 45, 20);
		g2.setColor(Color.BLACK);
		g2.drawRect(startX + 30, startY + 10, 45, 20);
		g2.setColor(color);
		g2.fillOval(startX + 60, startY + 5, 10, 30);
		g2.setColor(Color.BLACK);
		g2.drawOval(startX + 60, startY + 5, 10, 30);
		g2.drawOval(startX + 35, startY + 15, 10, 10);
		g2.drawOval(startX + 45, startY + 15, 10, 10);
		g2.drawRect(startX + 30, startY + 5, 45, 30);
	}

	@Override
	public void setMainColor(Color newColor) {
		color = newColor;
	}

	@Override
	public String getInfo() {
		return maxSpeed + ";" + maxCrew + ";" + displacement + ";"
				+ color.getRed() + ";" + color.getGreen() + ";"
				+ color.getBlue();
	}
}
