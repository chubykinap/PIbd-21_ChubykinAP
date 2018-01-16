public class Pan {
	private Water water;
	private Potato[] potato;
	private Cabbage[] cabbage;
	private Other_Ingredients other;
	private boolean ready_to_cook = false;

	public boolean Ready_to_cook() {
		AllIn();
		return ready_to_cook;
	}

	public void addCab(Cabbage[] k) {
		if (cabbage == null) {
			cabbage = k;
		}
	}

	public void addWater(Water w) {
		water = w;
	}

	public void addPotato(Potato[] p) {
		if (potato == null) {
			potato = p;
		}
	}

	public void addOther(Other_Ingredients o) {
		other = o;
	}

	public void GetHeat() {
		if (!ready_to_cook) {
			return;
		}
		if (water.Temperature == 100) {
			for (int i = 0; i < potato.length; i++) {
				potato[i].Heat();
			}
			for (int i = 0; i < cabbage.length; i++) {
				cabbage[i].Heat();
			}
			other.Heat();
		} else {
			water.Heat();
		}
	}

	public void AllIn() {
		if (cabbage == null || potato == null || other == null || water == null) {
			ready_to_cook = false;
			return;
		} else {
			for (int i = 0; i < cabbage.length; i++) {
				if (cabbage[i] == null) {
					ready_to_cook = false;
					return;
				}
			}
			for (int i = 0; i < potato.length; i++) {
				if (potato[i] == null) {
					ready_to_cook = false;
					return;
				}
			}
		}
		ready_to_cook = true;
	}

	public boolean Is_ready() {
		if (cabbage == null || potato == null) {
			return false;
		}
		for (int i = 0; i < cabbage.length; i++) {
			if (cabbage[i].Ready() < 10) {
				return false;
			}
		}
		for (int i = 0; i < potato.length; i++) {
			if (potato[i].Ready() < 10) {
				return false;
			}
		}
		if (other.Ready() < 10) {
			return false;
		}
		return true;
	}
}
