package supermarket.model.core;

public class EAN {

	private String code;

	public EAN(String code) {
		if (isNullOrWhiteSpace(code))
			throw new IllegalArgumentException("The code must not be empty.");
		if (!containsJustDigits(code))
			throw new IllegalArgumentException("The code must consist only if digits but was "+ code);
		if (code.length() != 9 && code.length() != 13)
			throw new IllegalArgumentException("The code must be 9 or 13 characters long but was " + code);

		this.code = code;
	}

	private boolean isNullOrWhiteSpace(String text) {
		return text == null || text.isEmpty();
	}
	private static boolean containsJustDigits(String text) {
		return text.matches("[0-9]*");
	}

	public String getCode() {
		return code;
	}

	public static EAN newEAN(String code) {
		return new EAN(code);
	}


	@Override
	public String toString() {
		return String.format("EAN%i: %s", code.length(), code);
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((code == null) ? 0 : code.hashCode());
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		EAN other = (EAN) obj;
		if (code == null) {
			if (other.code != null)
				return false;
		} else if (!code.equals(other.code))
			return false;
		return true;
	}

}
