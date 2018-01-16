import java.awt.Color;
import java.awt.Graphics;

public abstract class Sudno implements ITech {
	protected int startX;
	protected int startY;
	protected int CrewCount;
	protected int displacement;
	protected int maxCrew;
	protected int maxSpeed;
	protected Color color;

	public abstract void moveSudno(Graphics g);

	public abstract void drawSudno(Graphics g);

	public void setPos(int x, int y) {
		startX = x;
		startY = y;
	}

	protected void setCrewCount(int newCrew) {
		CrewCount = newCrew;
	}

	public int getCrewCount() {
		return CrewCount;
	}

	protected void setDisplacement(int newDis) {
		displacement = newDis;
	}

	public int getDisplacement() {
		return displacement;
	}

	protected void setMaxCrew(int newMCrew) {
		maxCrew = newMCrew;
	}

	public int getMaxCrew() {
		return maxCrew;
	}

	protected void setMaxSpeed(int newSpeed) {
		maxSpeed = newSpeed;
	}

	public int getMaxSpeed() {
		return maxSpeed;
	}

	protected void setColor(Color newColor) {
		color = newColor;
	}

	public Color getColor() {
		return color;
	}
}
