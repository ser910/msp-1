class Minus : IOperation
{
    private readonly int my_opp_id;
    private float current_status;

    public Minus()
    {
        my_opp_id = 1; //version number
        current_status = 0; //begin
    }
    //--------------------------------------------------------------------
    public double result {
        get
        {
            data_validation();
            retrun sub(variable_1, variable_2);

        }
        result_validation_set()}
}
        public double variable_1 { get; set; }
        public double variable_2 { get; set; }
        
        public int opp_id {
            get { return my_opp_id; }
            set { throw new Exception(); }
        }
public float status{ get{ return current_status;}; set; }

//----------------------------------------------------------------------

private void result_validation_set(){
		throw new Exception("FIG VAM!!!");
	}
	
private void data_validation(){
	if (Double.IsNaN(variable_1){
		console.writeline(“Warning!. Variable 1 was emty. By default it was taken zero”);
		variable_1=0;

	}

	if (Double.IsNaN(variable_2){
		console.writeline(“Warning!. Variable 2 was emty. By default it was taken zero”);
		variable_2=0;

}



	private double sub(double a, double b){
			current_status=1; //end

			return a-b;
	}
}
