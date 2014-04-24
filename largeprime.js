function largestPrime(n) {
	var max = Math.round(Math.sqrt(n));
	for (var i = max; i >= 2; i--) {
		if(n % 1 == 0 && largestPrime(i)==1) {
				return i;
		}
	}
		return 1;
} 
