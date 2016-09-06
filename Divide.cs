  class Divide:IOperation
    {
        private readonly int my_opp_id;
        private float current_status;

        public Divide()
        {
            my_opp_id = 4; //version number
            current_status = 0;
        }


        public double result
        {
            get
            {
                DataValidation();
                return divide(variable_1, variable_2);
            }
            set
            {
                result_validation_set();
            }
        }
        public double variable_1 { get; set; }
        public double variable_2 { get; set; }
        public int opp_id
        {
            get { return my_opp_id; }
            set { throw new Exception(); }
        }

        public float status
        {
            get { return current_status; }
        }



        private void result_validation_set()
        {
            throw new Exception("FIG VAM!!!");
        }

        private void DataValidation()
        {
            if (double.IsNaN(variable_1))
            {
                Console.WriteLine("Warning! Varianle 1 is Empty, By default it was taken zero");
                variable_1 = 0;
            }
            if (double.IsNaN(variable_2))
            {
                Console.WriteLine("Warning! Varianle 2 is Empty, By default it was taken one");
                variable_2 = 1;
            }
            if (variable_2==0)
            {
                throw new Exception();
            }

            current_status = 0.5f;
            //Exception part    Error
        }

        private double divide(double a, double b)
        {
            current_status = 1;
            return a / b;
        }

    }
  }
