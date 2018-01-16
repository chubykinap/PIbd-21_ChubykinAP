import java.awt.Color;
import java.awt.Graphics;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;

public class Parking {
	ArrayList<Port<ITech>> pStages;
	int countStages = 5;
	int countPlaces = 15;
	int placeSizeWidth = 210;
	int placeSizeHeight = 80;
	int currentLVL;

	public int getLvl() {
		return currentLVL;
	}

	public Parking() {
		pStages = new ArrayList<Port<ITech>>(countStages);
		for (int i = 0; i < countStages; i++) {
			pStages.add(new Port<ITech>(countPlaces, null));
		}
	}

	public boolean LevelUp() {
		if (currentLVL + 1 < pStages.size()) {
			currentLVL++;
			return true;
		}
		return false;
	}

	public boolean LevelDown() {
		if (currentLVL > 0) {
			currentLVL--;
			return true;
		}
		return false;
	}

	public int PutInParking(ITech ship) throws ParkingOverflowException {
		return pStages.get(currentLVL).plus(pStages.get(currentLVL), ship);
	}

	public ITech GetInParking(int index) throws ParkingIndexOutOfRangeException {
		return pStages.get(currentLVL).minus(pStages.get(currentLVL), index);
	}

	public boolean save(String filename) {
		File file = new File(filename);
		if (file.exists()) {
			file.delete();
		}
		try (FileOutputStream fileStream = new FileOutputStream(file)) {
			try (BufferedOutputStream bs = new BufferedOutputStream(fileStream)) {
				String str = "CountLeveles:" + pStages.size()
						+ System.lineSeparator();
				ByteArrayOutputStream byteOut = new ByteArrayOutputStream();
				for (int i = 0; i < str.length(); i++) {
					byteOut.write(str.charAt(i));
				}
				byte[] info = byteOut.toByteArray();
				fileStream.write(info, 0, info.length);
				for (Port<ITech> level : pStages) {
					byteOut = new ByteArrayOutputStream();
					str = "Level" + System.lineSeparator();

					for (int i = 0; i < str.length(); i++) {
						byteOut.write(str.charAt(i));
					}
					info = byteOut.toByteArray();
					fileStream.write(info, 0, info.length);

					for (int i = 0; i < countPlaces; i++) {
						ITech ship = level.getShip(i);
						if (ship != null) {
							byteOut = new ByteArrayOutputStream();
							String shipInfo = ship.getClass().getName() + ":"
									+ ship.getInfo() + System.lineSeparator();
							for (int j = 0; j < shipInfo.length(); j++) {
								byteOut.write(shipInfo.charAt(j));
							}
							info = byteOut.toByteArray();
							fileStream.write(info, 0, info.length);
						}
					}
				}
			}
			fileStream.close();
			return true;
		} catch (IOException e) {
			return false;
		}
	}

	public boolean load(String filename) throws ParkingOverflowException {
		File file = new File(filename);
		if (!file.exists()) {
			return false;
		}
		try (FileInputStream fileStream = new FileInputStream(filename)) {
			String s = "";
			try (BufferedInputStream bs = new BufferedInputStream(fileStream)) {
				Path path = Paths.get(file.getAbsolutePath());
				byte[] b = new byte[fileStream.available()];
				b = Files.readAllBytes(path);
				ByteArrayInputStream bos = new ByteArrayInputStream(b);
				String value = new String(b, StandardCharsets.UTF_8);
				while (bos.read(b, 0, b.length) > 0) {
					s += value;
				}
				s = s.replace("\r", "");
				String[] strs = s.split("\n");
				if (strs[0].contains("CountLeveles")) {
					if (pStages != null) {
						pStages.clear();
					}
					pStages = new ArrayList<Port<ITech>>();
				} else {
					return false;
				}
				int counter = -1;
				for (int i = 0; i < strs.length; i++) {
					if (strs[i].startsWith("Level")) {
						counter++;
						pStages.add(new Port<ITech>(countPlaces, null));
					} else if (strs[i].startsWith("Ship")) {
						ITech ship = new Ship(strs[i].split(":")[1]);
						int number = pStages.get(counter).plus(
								pStages.get(counter), ship);
						if (number == -1) {
							return false;
						}
					} else if (strs[i].startsWith("Cruiser")) {
						ITech ship = new Cruiser(strs[i].split(":")[1]);
						int number = pStages.get(counter).plus(
								pStages.get(counter), ship);
						if (number == -1) {
							return false;
						}
					}
				}
			}
			return true;
		} catch (IOException ex) {
			return false;
		}
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
			ITech ship = pStages.get(currentLVL).getShip(i);
			if (ship != null) {
				ship.setPos(20 + i / 5 * placeSizeWidth, i % 5
						* placeSizeHeight + 15);
				ship.drawSudno(g);
			}
		}
	}
}
