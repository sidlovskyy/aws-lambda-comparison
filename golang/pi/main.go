package main

import (
	"context"
	"fmt"
	"strconv"

	"github.com/aws/aws-lambda-go/lambda"
)

func HandleRequest(ctx context.Context, input string) (float32, error) {
	history := make([]float32, 0)

	fmt.Println("Starting. Iterations:", input)

	number, _ := strconv.Atoi(input)
	var sign float32 = 1
	var pi float32 = 0

	for index := 0; index < number; index++ {
		pi += sign * 4 / float32(index*2+1)
		sign *= -1
		history = append(history, pi)
	}

	fmt.Println("Done. List length:", len(history))

	return pi, nil
}

func main() {
	lambda.Start(HandleRequest)
}
