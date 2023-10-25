module Gyak3 where
    smallPrimes :: [Int]
    smallPrimes = [2,3,5,7]
    
    addElem :: a -> [a] -> [a]
    addElem  x l = x : l

    first :: [Int] -> Int
    first [] = 0
    --first [1] = 1
    --first [a] = a
    first (x:xs) = x
    
