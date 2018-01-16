import java.awt.EventQueue;
import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JTextArea;
import javax.swing.JCheckBox;
import javax.swing.JLabel;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.io.File;

import javax.swing.JList;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JMenu;
import javax.swing.filechooser.FileNameExtensionFilter;

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
		port = new Parking();
		initialize();
		for (int i = 0; i < 5; i++) {
			levels[i] = "Level " + (i + 1);
		}
		list.setSelectedIndex(port.getLvl());
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
		frame.setBounds(100, 100, 953, 565);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JMenuBar menuBar = new JMenuBar();
		frame.setJMenuBar(menuBar);

		JMenu menuFile = new JMenu("File");
		menuBar.add(menuFile);

		JPanel panel = new Panel1(port);
		panel.setBounds(10, 11, 632, 484);
		frame.getContentPane().add(panel);

		JMenuItem menuSave = new JMenuItem("Save");
		menuSave.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser filesave = new JFileChooser();
				FileNameExtensionFilter filter = new FileNameExtensionFilter(
						"txt file", "txt");
				filesave.setFileFilter(filter);
				if (filesave.showSaveDialog(null) == JFileChooser.APPROVE_OPTION) {
					File file = filesave.getSelectedFile();
					String path = file.getAbsolutePath();
					if (port.save(path)) {
						JOptionPane.showMessageDialog(null, "Saved");
						return;
					} else {
						JOptionPane.showMessageDialog(null, "Save failed", "",
								0, null);
					}
				}
			}
		});
		menuFile.add(menuSave);

		JMenuItem menuLoad = new JMenuItem("Load");
		menuLoad.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser fileChooser = new JFileChooser();
				FileNameExtensionFilter filter = new FileNameExtensionFilter(
						"txt file", "txt");
				fileChooser.setFileFilter(filter);
				if (fileChooser.showOpenDialog(null) == JFileChooser.APPROVE_OPTION) {
					File file = fileChooser.getSelectedFile();
					try {
						if (port.load(file.getAbsolutePath())) {
							JOptionPane.showMessageDialog(null, "Loaded");
						} else {
							JOptionPane.showMessageDialog(null, "Load failed",
									"", 0, null);
						}
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, ex.getMessage(),
								"", 0, null);
					}
					panel.repaint();
				}
			}
		});
		menuFile.add(menuLoad);
		color = Color.GRAY;

		JPanel panelGet = new JPanel();
		panelGet.setBounds(652, 106, 275, 141);
		frame.getContentPane().add(panelGet);

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
								"Wrong number", "Error", 0, null);
						return;
					}
					ship = port.GetInParking(place);
					ship.setPos(50, 50);
				} catch (NumberFormatException e) {
					JOptionPane.showMessageDialog(null, "Wrong format",
							"Error", 0, null);
					return;
				} catch (NullPointerException e) {
					JOptionPane.showMessageDialog(null, "Empty", "Error", 0,
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

		JButton setShip = new JButton("setShip");
		setShip.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				formSelect form = new formSelect(frame);
				if (form.checkExist()) {
					ITech ship = form.returnShip();
					if (ship == null) {
						JOptionPane.showMessageDialog(null, "Null element",
								"Error", 0, null);
						return;
					}
					int place = port.PutInParking(ship);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Your place : "
							+ (place + 1));
				}
			}
		});
		setShip.setBounds(652, 11, 89, 23);
		frame.getContentPane().add(setShip);

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
