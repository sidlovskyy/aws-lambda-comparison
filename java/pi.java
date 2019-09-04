package example;

import com.amazonaws.services.lambda.runtime.Context; 
import com.amazonaws.services.lambda.runtime.LambdaLogger;

public class Pi {
    public String myHandler(int myCount, Context context) {

        // var history = new List<double>();

        LambdaLogger logger = context.getLogger();
        logger.log("received : " + myCount);
        
        
        return String.valueOf(myCount);
    }
}