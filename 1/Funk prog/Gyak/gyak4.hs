module Gyak4 where

--listagenerátor, halmazkifejezések

evenSquares :: [Int]
evenSquares = [a^2 | a <- [1..10], even a]

tupleees :: [(Int, Int)]
tupleees = [(x,y) | x <-[0..3], odd x, y <- [x..6], even y]
--tupleees = [(x,y) | x <-[0..3], y <- [x..6], odd x && even y]

paralell :: [(Char, Char)]
paralell = [(x,y)| (x,y) <- (zip "abc" "efg")]

paralell2 ::[(Int)]
paralell2 = [2*x+y |(x,y) <-(zip [1..3] [11..22])]
--paralell2 = [2*(fst a) + (snd a) | a <-(zip [1..3] [11..22])]

foo ((x:y):xs) = True
foo _ = False

-- Rekurzió

-- n! = n* (n-1)!, ha 0! = 1

fact :: Integer -> Integer
fact 0 = 1
fact n = n * fact(n-1)

-- fib 0 = 0, fib 1 = 1, fib n = fib (n-1) * fib (n-2)

fib :: Integer -> Integer
fib 0 = 0
fib 1 = 1
fib n = fib(n-1) + fib(n-2)

fibhelp :: Integer -> Integer -> Integer -> Integer
fibhelp a b 0 = a 
fibhelp a b n = fibhelp(b)(a+b)(n-1)

fib2 :: Integer -> Integer
fib2 n = fibhelp 0 1 n