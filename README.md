# aws-lambda-comparison
Comparison of AWS lambda written on different languages

Pi number generation on N iterations:

|Language      |TIME 1k     |MEM 1k     |TIME 100k   |MEM 100k      |TIME 10kk   |MEM 10kk    |
|--------------|------------|-----------|-------------|-------------|------------|------------|
|.NET Core 2.1 |0.27 ms     |81 Mb      |2 ms         |85 Mb        |1150 ms     |256 Mb      |
|Node 8.10     |0.4 ms      |73 Mb      |3 ms         |87 Mb        |2400 ms     |256 Mb      |
|Go 1.x        |0.4 ms      |45 Mb      |1.3 ms       |50 Mb        |800 ms      |220 Mb      |
|Python 3.7    |8 ms        |63 Mb      |190 ms       |67 Mb        |fails       |fails       |
|Ruby 2.5      |16 ms       |55 Mb      |125 ms       |61 Mb        |11000 ms    |220 Mb      |
|Java          |

Python 3.7 5kk - TIME 9500 ms, MEM 5kk