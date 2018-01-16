import java.awt.EventQueue;
import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JTextArea;
import javax.swing.JCheckBox;
import javax.swing.JLabel;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JList;

public class Form {

	private JFrame frame;
	private Color color;
	private Color dopColor;
	private int maxCrew;
	private int maxSpeed;
	private int displacement;
	private String[] levels = new String[6];
	Parking port;
	JList list;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form window = new Form();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Form() {
		port = new Parking(5);
		initialize();
		for (int i = 0; i < 5; i++) {
			levels[i] = "Уровнь " + (i + 1);
		}
		list.setSelectedIndex(port.getLvl());
		color = Color.GRAY;
		dopColor = Color.DARK_GRAY;
		maxSpeed = 30;
		maxCrew = 300;
		displacement = 9000;
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 953, 542);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel1(port);
		panel.setBounds(10, 11, 632, 484);
		frame.getContentPane().add(panel);

		JPanel panelGet = new JPanel();
		panelGet.setBounds(652, 106, 275, 141);
		frame.getContentPane().add(panelGet);

		JButton btnShip = new JButton("setShip");
		btnShip.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Color color = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (color != null) {
					ITech ship = new Ship(maxSpeed, maxCrew, displacement,
							color);
					int place = port.PutInParking(ship);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место: "
							+ (place + 1));
				}
			}
		});
		btnShip.setBounds(652, 11, 89, 23);
		frame.getContentPane().add(btnShip);

		JButton btnCruiser = new JButton("setCruiser");
		btnCruiser.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				color = JColorChooser.showDialog(null, "JColorChooser Sample",
						null);
				dopColor = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (color != null && dopColor != null) {
					ITech ship = new Cruiser(maxSpeed, maxCrew, displacement,
							color, true, true, dopColor);
					int place = port.PutInParking(ship);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место: "
							+ (place + 1));
				}
			}
		});
		btnCruiser.setBounds(751, 11, 89, 23);
		frame.getContentPane().add(btnCruiser);

		JTextArea placeArea = new JTextArea();
		placeArea.setBounds(707, 45, 71, 16);
		frame.getContentPane().add(placeArea);

		JLabel lblPlace = new JLabel("Place");
		lblPlace.setBounds(651, 45, 46, 14);
		frame.getContentPane().add(lblPlace);

		JButton getShip = new JButton("GetShip");
		getShip.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				int place;
				ITech ship;
				try {
					place = Integer.parseInt(placeArea.getText()) - 1;
					if (place > 15 && place < 1) {
						JOptionPane.showMessageDialog(null,
								"Введено неверное число", "Ошибка", 0, null);
						return;
					}
					ship = port.GetInParking(place);
					ship.setPos(50, 50);
				} catch (NumberFormatException e) {
					JOptionPane.showMessageDialog(null, "Неверный формат",
							"Ошибка", 0, null);
					return;
				} catch (NullPointerException e) {
					JOptionPane.showMessageDialog(null, "Пусто", "Ошибка", 0,
							null);
					return;
				}
				Graphics g = panelGet.getGraphics();
				g.setColor(Color.BLACK);
				g.drawRect(20, 20, 200, 100);
				ship.drawSudno(g);
				panel.repaint();
			}
		});
		getShip.setBounds(652, 72, 89, 23);
		frame.getContentPane().add(getShip);

		list = new JList(levels);
		list.setBounds(652, 258, 153, 141);
		frame.getContentPane().add(list);

		JButton Up = new JButton(">>");
		Up.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				port.LevelUp();
				list.setSelectedIndex(port.getLvl());
				panel.repaint();
			}
		});
		Up.setBounds(815, 255, 89, 23);
		frame.getContentPane().add(Up);

		JButton Down = new JButton("<<");
		Down.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				port.LevelDown();
				list.setSelectedIndex(port.getLvl());
				panel.repaint();

			}
		});
		Down.setBounds(815, 289, 89, 23);
		frame.getContentPane().add(Down);
	}
}
