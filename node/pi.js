exports.handler = async (input) => {
    const history = [];

    console.log(`Starting. Iterations: ${input}`);

    const number = parseInt(input);
    let sign = 1;
    let pi = 0;
    for (let index = 0; index < number; index++) {
        pi += sign * 4 / (index * 2 + 1);
        sign *= -1;
        history.push(pi);
    }

    console.log(`Done. List length: ${history.length}`);

    return pi;
};
