module Homework4 where
    initLast :: [a] -> ([a], a)
    initLast a = (init a,last a)

    headLess :: [a] -> [a] -> [a]
    headLess (x:xs) (y:ys) = xs ++ ys

    howManyNot :: Char -> String -> Int
    howManyNot a b = length [x | x <- b, x /= a] 

    mathGoBrrr :: Num a => [a] -> [a]
    mathGoBrrr [] = []
    mathGoBrrr (x:xs)= ((x-7)*3) : mathGoBrrr xs 