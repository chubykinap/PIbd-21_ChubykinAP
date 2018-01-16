import java.awt.Color;
import java.awt.Graphics;

public class Parking {
	Port<ITech> parking;
	int countPlaces = 15;
	int placeSizeWidth = 210;
	int placeSizeHeight = 80;
	int currentLVL;

	public int getLvl() {
		return currentLVL;
	}

	public Parking() {
		parking = new Port<ITech>(countPlaces, null);
	}

	public int PutInParking(ITech ship) {
		return parking.plus(parking, ship);
	}

	public ITech GetInParking(int index) {
		return parking.minus(parking, index);
	}

	public void DrawPort(Graphics g) {
		g.setColor(Color.BLACK);
		g.drawRect(0, 0, (countPlaces / 5) * placeSizeWidth, 480);
		for (int i = 0; i < countPlaces / 5; i++) {
			for (int j = 0; j < 6; ++j) {
				g.drawLine(i * placeSizeWidth, j * placeSizeHeight, i
						* placeSizeWidth + 110, j * placeSizeHeight);
			}
			g.drawLine(i * placeSizeWidth, 0, i * placeSizeWidth, 400);
		}
	}

	public void Draw(Graphics g) {
		DrawPort(g);
		for (int i = 0; i < countPlaces; i++) {
			ITech ship = parking.getShip(i);
			if (ship != null) {
				ship.setPos(20 + i / 5 * placeSizeWidth, i % 5
						* placeSizeHeight + 15);
				ship.drawSudno(g);
			}
		}
	}
}
