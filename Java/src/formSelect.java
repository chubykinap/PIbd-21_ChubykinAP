import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Graphics;

import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.TransferHandler;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;

import java.awt.Color;
import java.awt.datatransfer.DataFlavor;
import java.awt.datatransfer.UnsupportedFlavorException;
import java.awt.dnd.DnDConstants;
import java.awt.dnd.DropTarget;
import java.awt.dnd.DropTargetDragEvent;
import java.awt.dnd.DropTargetDropEvent;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.IOException;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class formSelect extends JDialog {
	ITech ship = null;
	private boolean exist;

	/**
	 * Create the dialog.
	 */
	public formSelect(JFrame frame) {
		super(frame, true);
		setBounds(100, 100, 450, 332);
		getContentPane().setLayout(null);
		{
			JPanel buttonPane = new JPanel();
			buttonPane.setBounds(0, 260, 434, 33);
			buttonPane.setLayout(new FlowLayout(FlowLayout.RIGHT));
			getContentPane().add(buttonPane);
			{
				JButton ok = new JButton("OK");
				ok.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent arg0) {
						exist = true;
						dispose();
					}
				});
				ok.setActionCommand("OK");
				buttonPane.add(ok);
				getRootPane().setDefaultButton(ok);
			}
			{
				JButton cancel = new JButton("Cancel");
				cancel.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent arg0) {
						exist = false;
						dispose();
					}
				});
				cancel.setActionCommand("Cancel");
				buttonPane.add(cancel);
			}
		}

		MouseListener mouse = new MouseListener() {

			@Override
			public void mouseClicked(MouseEvent arg0) {
			}

			@Override
			public void mouseEntered(MouseEvent arg0) {
			}

			@Override
			public void mouseExited(MouseEvent arg0) {
			}

			@Override
			public void mousePressed(MouseEvent arg0) {
				JComponent jc = (JComponent) arg0.getSource();
				TransferHandler th = jc.getTransferHandler();
				th.exportAsDrag(jc, arg0, TransferHandler.COPY);
			}

			@Override
			public void mouseReleased(MouseEvent arg0) {
			}
		};

		JPanel panel = new JPanel();
		panel.setBounds(115, 11, 182, 172);
		getContentPane().add(panel);
		panel.setDropTarget(new DropTarget() {
			public void drop(DropTargetDropEvent e) {
				for (DataFlavor df : e.getTransferable()
						.getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) == "Ship") {
							ship = new Ship(30, 3, 9000, Color.GRAY);
						} else if (e.getTransferable().getTransferData(df) == "Cruiser") {							
							ship = new Cruiser(30, 3, 9000, Color.GRAY, true,
									true, Color.GRAY);
						}
					} catch (UnsupportedFlavorException e1) {
						e1.printStackTrace();
					} catch (IOException e1) {
						e1.printStackTrace();
					}
					draw(panel, ship);
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable()
						.getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (Exception e1) {
						e1.printStackTrace();
					}
				}
			}
		});

		JPanel panelBlack = new JPanel();
		panelBlack.setName("black");
		panelBlack.setBackground(Color.BLACK);
		panelBlack.setBounds(307, 11, 50, 50);
		getContentPane().add(panelBlack);
		panelBlack.addMouseListener(mouse);
		panelBlack.setTransferHandler(new TransferHandler("name"));

		JPanel panelWhite = new JPanel();
		panelWhite.setName("white");
		panelWhite.setBackground(Color.WHITE);
		panelWhite.setBounds(367, 11, 50, 50);
		getContentPane().add(panelWhite);
		panelWhite.addMouseListener(mouse);
		panelWhite.setTransferHandler(new TransferHandler("name"));

		JPanel panelGreen = new JPanel();
		panelGreen.setName("green");
		panelGreen.setBackground(Color.GREEN);
		panelGreen.setBounds(307, 72, 50, 50);
		getContentPane().add(panelGreen);
		panelGreen.addMouseListener(mouse);
		panelGreen.setTransferHandler(new TransferHandler("name"));

		JPanel panelBlue = new JPanel();
		panelBlue.setName("blue");
		panelBlue.setBackground(Color.BLUE);
		panelBlue.setBounds(367, 72, 50, 50);
		getContentPane().add(panelBlue);
		panelBlue.addMouseListener(mouse);
		panelBlue.setTransferHandler(new TransferHandler("name"));

		JPanel panelRed = new JPanel();
		panelRed.setName("red");
		panelRed.setBackground(Color.RED);
		panelRed.setBounds(307, 133, 50, 50);
		getContentPane().add(panelRed);
		panelRed.addMouseListener(mouse);
		panelRed.setTransferHandler(new TransferHandler("name"));

		JPanel panelGray = new JPanel();
		panelGray.setName("gray");
		panelGray.setBackground(Color.GRAY);
		panelGray.setBounds(367, 133, 50, 50);
		getContentPane().add(panelGray);
		panelGray.addMouseListener(mouse);
		panelGray.setTransferHandler(new TransferHandler("name"));

		JPanel panelYellow = new JPanel();
		panelYellow.setName("yellow");
		panelYellow.setBackground(Color.YELLOW);
		panelYellow.setBounds(307, 194, 50, 50);
		getContentPane().add(panelYellow);
		panelYellow.addMouseListener(mouse);
		panelYellow.setTransferHandler(new TransferHandler("name"));

		JPanel panelOrange = new JPanel();
		panelOrange.setName("orange");
		panelOrange.setBackground(Color.ORANGE);
		panelOrange.setBounds(367, 194, 50, 50);
		getContentPane().add(panelOrange);
		panelOrange.addMouseListener(mouse);
		panelOrange.setTransferHandler(new TransferHandler("name"));

		JLabel LShip = new JLabel("Ship");
		LShip.setBounds(10, 11, 95, 50);
		getContentPane().add(LShip);
		LShip.addMouseListener(mouse);
		LShip.setTransferHandler(new TransferHandler("text"));

		JLabel LCruiser = new JLabel("Cruiser");
		LCruiser.setBounds(10, 72, 95, 50);
		getContentPane().add(LCruiser);
		LCruiser.addMouseListener(mouse);
		LCruiser.setTransferHandler(new TransferHandler("text"));

		JLabel mainColor = new JLabel("mainColor");
		mainColor.setBounds(115, 194, 77, 50);
		getContentPane().add(mainColor);
		mainColor.setDropTarget(new DropTarget() {
			public void drop(DropTargetDropEvent e) {
				if (ship != null) {
					try {
						for (DataFlavor df : e.getTransferable()
								.getTransferDataFlavors()) {
							ship.setMainColor((colorSelect(e.getTransferable()
									.getTransferData(df).toString())));
							draw(panel, ship);
						}
					} catch (Exception ex) {
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable()
						.getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						e1.printStackTrace();
					}
				}
			}
		});

		JLabel dopColor = new JLabel("dopColor");
		dopColor.setBounds(220, 194, 77, 50);
		getContentPane().add(dopColor);
		dopColor.setDropTarget(new DropTarget() {
			public void drop(DropTargetDropEvent e) {
				if (ship != null) {
					try {

						for (DataFlavor df : e.getTransferable()
								.getTransferDataFlavors()) {
							((Cruiser) ship).setDopColor((colorSelect(e
									.getTransferable().getTransferData(df)
									.toString())));
							draw(panel, ship);
						}
					} catch (Exception ex) {
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable()
						.getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						e1.printStackTrace();
					}
				}
			}
		});
	}

	public void draw(JPanel panel, ITech ship) {
		if (ship != null) {
			Graphics g = panel.getGraphics();
			g.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			ship.setPos(35, 25);
			ship.drawSudno(g);
		}
	}

	public Color colorSelect(String s) {
		switch (s) {
		case "black":
			return Color.black;
		case "white":
			return Color.white;
		case "green":
			return Color.green;
		case "blue":
			return Color.blue;
		case "red":
			return Color.red;
		case "gray":
			return Color.gray;
		case "yellow":
			return Color.yellow;
		case "orange":
			return Color.orange;
		}

		return null;
	}

	public ITech returnShip() {
		return ship;
	}

	public boolean checkExist() {
		setVisible(true);
		return exist;
	}
}
