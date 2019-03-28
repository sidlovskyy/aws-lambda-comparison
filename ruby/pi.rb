def lambda_handler(event:, context:)
    history = [];
    
    print 'Starting. Iterations: ', event
    
    number = event.to_i
    sign = 1
    pi = 0
    for index in 0..number - 1
    	pi += sign * 4 / (index * 2.0 + 1)
    	sign *= -1
    	history << pi
    end
    
    print 'Done. List length: ', history.length

    return pi;
end
