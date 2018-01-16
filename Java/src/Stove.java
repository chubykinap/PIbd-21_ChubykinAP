public class Stove {
	private Pan pan;
	public boolean state = false;

	public void Pan(Pan p) {
		pan = p;
	}
	
	public Pan getPan(){
		return pan;
	}

	public void Cook() {
		if (state) {
			while (pan.Is_ready()) {
				pan.GetHeat();
			}
		}
	}
}
