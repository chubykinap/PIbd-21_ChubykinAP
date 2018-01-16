import java.awt.EventQueue;
import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JTextArea;
import javax.swing.JCheckBox;
import javax.swing.JLabel;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;

public class Form {

	private JFrame frame;
	private JPanel panel;
	JTextArea maxSpeedArea;
	JTextArea maxCrewArea;
	JTextArea DispArea;
	private Color color;
	private Color dopColor;
	private int maxCrew;
	private int maxSpeed;
	private int displacement;
	private ITech inter;
	Graphics g;

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
		initialize();
		color = Color.GRAY;
		dopColor = Color.GRAY;
		maxSpeed = 30;
		maxCrew = 300;
		displacement = 9000;
		maxSpeedArea.setText("" + maxSpeed);
		maxCrewArea.setText("" + maxCrew);
		DispArea.setText("" + displacement);
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 425, 607);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		maxSpeedArea = new JTextArea();
		maxSpeedArea.setBounds(109, 452, 89, 23);
		frame.getContentPane().add(maxSpeedArea);

		maxCrewArea = new JTextArea();
		maxCrewArea.setBounds(109, 481, 89, 23);
		frame.getContentPane().add(maxCrewArea);

		DispArea = new JTextArea();
		DispArea.setBounds(109, 510, 89, 23);
		frame.getContentPane().add(DispArea);

		JCheckBox front = new JCheckBox("frontCannon");
		front.setBounds(208, 452, 89, 23);
		frame.getContentPane().add(front);

		JCheckBox back = new JCheckBox("backCannon");
		back.setBounds(208, 481, 89, 23);
		frame.getContentPane().add(back);

		JButton btnShip = new JButton("Ship");
		btnShip.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!maxSpeedArea.getText().equals("")
						&& !maxCrewArea.getText().equals("")
						&& !DispArea.getText().equals("")) {
					maxSpeed = Integer.parseInt(maxSpeedArea.getText());
					maxCrew = Integer.parseInt(maxCrewArea.getText());
					displacement = Integer.parseInt(DispArea.getText());
					inter = new Ship(maxSpeed, maxCrew, displacement, color);
					panel = new Panel1(inter);
					panel.setBounds(10, 10, 383, 401);
					frame.getContentPane().add(panel);
					panel.updateUI();
				}
			}
		});
		btnShip.setBounds(10, 423, 89, 23);
		frame.getContentPane().add(btnShip);

		JButton btnCruiser = new JButton("Cruiser");
		btnCruiser.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!maxSpeedArea.getText().equals("")
						&& !maxCrewArea.getText().equals("")
						&& !DispArea.getText().equals("")) {
					maxSpeed = Integer.parseInt(maxSpeedArea.getText());
					maxCrew = Integer.parseInt(maxCrewArea.getText());
					displacement = Integer.parseInt(DispArea.getText());
					inter = new Cruiser(maxSpeed, maxCrew, displacement, color,
							front.isSelected(), back.isSelected(), dopColor);
					panel = new Panel1(inter);
					panel.setBounds(10, 10, 383, 401);
					frame.getContentPane().add(panel);
					panel.updateUI();
				}
			}
		});
		btnCruiser.setBounds(109, 423, 89, 23);
		frame.getContentPane().add(btnCruiser);

		JButton btnColor = new JButton("color");
		btnColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				color = JColorChooser.showDialog(btnColor, "", color);
			}
		});
		btnColor.setBounds(307, 423, 89, 23);
		frame.getContentPane().add(btnColor);

		JButton btnDopcolor = new JButton("dopColor");
		btnDopcolor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				dopColor = JColorChooser.showDialog(btnDopcolor, "", dopColor);
			}
		});
		btnDopcolor.setBounds(307, 452, 89, 23);
		frame.getContentPane().add(btnDopcolor);

		JLabel lblMaxspeed = new JLabel("maxSpeed");
		lblMaxspeed.setBounds(10, 457, 69, 14);
		frame.getContentPane().add(lblMaxspeed);

		JLabel lblMaxcrew = new JLabel("maxCrew");
		lblMaxcrew.setBounds(10, 485, 69, 14);
		frame.getContentPane().add(lblMaxcrew);

		JLabel lblDisplacement = new JLabel("displacement");
		lblDisplacement.setBounds(10, 510, 69, 14);
		frame.getContentPane().add(lblDisplacement);
	}
}
