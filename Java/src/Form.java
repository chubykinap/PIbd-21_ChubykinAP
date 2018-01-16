import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JToolBar;
import javax.swing.JComboBox;
import javax.swing.JTextPane;
import javax.swing.JSpinner;
import javax.swing.JLabel;
import javax.swing.JRadioButton;
import javax.swing.JButton;

import java.awt.Checkbox;

import javax.swing.ButtonGroup;

import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeEvent;

import javax.swing.JTextField;
import javax.swing.JCheckBox;

public class Form {

	private JFrame frame;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private JButton CutPotato;
	private Potato[] potato;
	private Cabbage[] cabbage;
	private Water water = new Water();
	private Other_Ingredients other = new Other_Ingredients();
	private WaterTap waterTap = new WaterTap();
	private Knife knife = new Knife();
	private Terka terka = new Terka();
	private Pan pan = new Pan();
	private Stove stove = new Stove();
	private boolean onStove = false;
	private JTextField PotatoCount;
	private JTextField CabbageCount;

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
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 393, 340);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JCheckBox Kran = new JCheckBox(
				"\u041A\u0440\u0430\u043D \u043E\u0442\u043A\u0440\u044B\u0442");
		Kran.setBounds(179, 10, 97, 23);
		frame.getContentPane().add(Kran);

		JLabel label = new JLabel(
				"\u041A\u0430\u0440\u0442\u043E\u0448\u043A\u0430");
		label.setBounds(10, 14, 57, 14);
		frame.getContentPane().add(label);

		JLabel label_1 = new JLabel(
				"\u041A\u0430\u043F\u0443\u0441\u0442\u0430");
		label_1.setBounds(10, 45, 46, 14);
		frame.getContentPane().add(label_1);

		JButton CutPotato = new JButton(
				"\u041D\u0430\u0440\u0435\u0437\u0430\u0442\u044C \u043A\u0430\u0440\u0442\u043E\u0448\u043A\u0443");
		CutPotato.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!"".equals(PotatoCount.getText())) {
					if (Integer.parseInt(PotatoCount.getText()) > 0) {
						potato = new Potato[Integer.parseInt(PotatoCount
								.getText())];
						for (int i = 0; i < potato.length; i++) {
							potato[i] = new Potato();
						}
					}
				} else {
					JOptionPane.showMessageDialog(null, "Картошки нет",
							"Ошибка", 0, null);
					return;
				}
				for (int i = 0; i < potato.length; i++) {
					knife.CutPot(potato[i]);
				}
				JOptionPane.showMessageDialog(null, "Картошка нарезана");
			}
		});
		CutPotato.setBounds(10, 70, 159, 23);
		frame.getContentPane().add(CutPotato);

		JButton CutCabbage = new JButton(
				"\u041D\u0430\u0440\u0435\u0437\u0430\u0442\u044C \u043A\u0430\u043F\u0443\u0441\u0442\u0443");
		CutCabbage.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!"".equals(CabbageCount.getText())) {
					if (Integer.parseInt(CabbageCount.getText()) > 0) {
						cabbage = new Cabbage[Integer.parseInt(CabbageCount
								.getText())];
						for (int i = 0; i < cabbage.length; i++) {
							cabbage[i] = new Cabbage();
						}
					}
				} else {
					JOptionPane.showMessageDialog(null, "Капусты нет",
							"Ошибка", 0, null);
					return;
				}
				for (int i = 0; i < cabbage.length; i++) {
					knife.CutCab(cabbage[i]);
				}
				JOptionPane.showMessageDialog(null, "Капуста нарезана");
			}
		});
		CutCabbage.setBounds(10, 107, 159, 23);
		frame.getContentPane().add(CutCabbage);

		JButton Terka = new JButton(
				"\u041D\u0430\u0442\u0435\u0440\u0435\u0442\u044C \u0437\u0435\u043B\u0435\u043D\u044C");
		Terka.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!other.exist) {
					return;
				}
				terka.Nateret(other);
				JOptionPane.showMessageDialog(null,
						"Остальные ингридиенты готовы");
			}
		});
		Terka.setBounds(10, 141, 159, 23);
		frame.getContentPane().add(Terka);

		JButton AddWater = new JButton(
				"\u0417\u0430\u043B\u0438\u0442\u044C \u0432\u043E\u0434\u0443 \u0432 \u043A\u0430\u0441\u0442\u0440\u044E\u043B\u044E");
		AddWater.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (Kran.isSelected() == false) {
					JOptionPane.showMessageDialog(null, "Откройте кран",
							"Ошибка", 0, null);
					return;
				}
				pan.addWater(water);
				JOptionPane.showMessageDialog(null, "Залили воду в кастрюлю");
			}
		});
		AddWater.setBounds(179, 40, 185, 23);
		frame.getContentPane().add(AddWater);

		JButton AddCabbage = new JButton(
				"\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043A\u0430\u043F\u0443\u0441\u0442\u0443");
		AddCabbage.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (cabbage == null || cabbage.length == 0) {
					JOptionPane.showMessageDialog(null, "Капусты нет",
							"Ошибка", 0, null);
					return;
				}
				for (int i = 0; i < cabbage.length; ++i) {
					if (cabbage[i].cutted == false) {
						JOptionPane.showMessageDialog(null, "Надо нарезать",
								"Ошибка", 0, null);
						return;
					}
				}
				pan.addCab(cabbage);
				JOptionPane.showMessageDialog(null, "Капуста добавлена");
			}
		});
		AddCabbage.setBounds(179, 70, 185, 23);
		frame.getContentPane().add(AddCabbage);

		JButton AddPotato = new JButton(
				"\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043A\u0430\u0440\u0442\u043E\u0448\u043A\u0443");
		AddPotato.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (potato == null || potato.length == 0) {
					JOptionPane.showMessageDialog(null, "Картошки нет",
							"Ошибка", 0, null);
					return;
				}
				for (int i = 0; i < potato.length; i++) {
					if (potato[i].cutted == false) {
						JOptionPane.showMessageDialog(null, "Надо нарезать",
								"Ошибка", 0, null);
						return;
					}
				}
				pan.addPotato(potato);
				JOptionPane.showMessageDialog(null, "Картошка добавлена");
			}
		});
		AddPotato.setBounds(179, 107, 185, 23);
		frame.getContentPane().add(AddPotato);

		JButton AddOther = new JButton(
				"\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0437\u0435\u043B\u0435\u043D\u044C");
		AddOther.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (other.has_ready == false) {
					JOptionPane.showMessageDialog(null, "Ингидиенты не готовы",
							"Ошибка", 0, null);
					return;
				}
				pan.addOther(other);
				JOptionPane.showMessageDialog(null,
						"Остальные ингридиенты добавлены");
			}
		});
		AddOther.setBounds(179, 141, 185, 23);
		frame.getContentPane().add(AddOther);

		Checkbox TurnOn = new Checkbox("Плита включена");
		TurnOn.setBounds(10, 170, 109, 22);
		frame.getContentPane().add(TurnOn);

		JButton Move = new JButton(
				"\u041F\u043E\u0441\u0442\u0430\u0432\u0438\u0442\u044C \u043A\u0430\u0441\u0442\u0440\u044E\u043B\u044E");
		Move.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JOptionPane.showMessageDialog(null, "Кастрюля на плите");
				onStove = true;
			}
		});
		Move.setBounds(10, 198, 159, 23);
		frame.getContentPane().add(Move);

		JButton Cook = new JButton(
				"\u0413\u043E\u0442\u043E\u0432\u0438\u0442\u044C");
		Cook.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				stove.Pan(pan);
				if (TurnOn.getState() == false) {
					JOptionPane.showMessageDialog(null, "Включи плиту",
							"Ошибка", 0, null);
					return;
				} else if (!onStove) {
					JOptionPane.showMessageDialog(null,
							"Поставь кастрюлю на плиту", "Ошибка", 0, null);
					return;
				} else if (!pan.Ready_to_cook()) {
					JOptionPane.showMessageDialog(null,
							"Не хватает ингридиентов для готовки", "Ошибка", 0,
							null);
					return;
				}
				stove.Cook();
				if (!stove.getPan().Is_ready()) {
					JOptionPane.showMessageDialog(null, "Готово!!!");
				} else {
					JOptionPane.showMessageDialog(null, "Упс...", "Ошибка", 0,
							null);
					return;
				}
			}
		});
		Cook.setBounds(10, 232, 159, 23);
		frame.getContentPane().add(Cook);

		JButton Remove = new JButton(
				"\u0423\u0431\u0440\u0430\u0442\u044C \u043A\u0430\u0441\u0442\u0440\u044E\u043B\u044E");
		Remove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (!onStove) {
					JOptionPane.showMessageDialog(null,
							"Сковорода и так не на плите", "Ошибка", 0, null);
				} else if (!stove.getPan().Is_ready()) {
					System.exit(0);
				} else {
					JOptionPane.showMessageDialog(null, "Еще не готово",
							"Ошибка", 0, null);
				}
			}
		});
		Remove.setBounds(10, 266, 159, 23);
		frame.getContentPane().add(Remove);

		PotatoCount = new JTextField();
		PotatoCount.setBounds(77, 11, 86, 20);
		frame.getContentPane().add(PotatoCount);
		PotatoCount.setColumns(10);

		CabbageCount = new JTextField();
		CabbageCount.setColumns(10);
		CabbageCount.setBounds(77, 42, 86, 20);
		frame.getContentPane().add(CabbageCount);
	}
}
