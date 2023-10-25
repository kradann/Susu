module Homework6 where
    import Data.Char

    negativeProduct :: (Num a, Ord a) => [a] -> a
    negativeProduct [] = 1
    negativeProduct (x:xs)
        | x < 0 = x * negativeProduct xs
        | otherwise = 1*negativeProduct xs

    cipher :: String -> String
    cipher [] = []
    cipher (x:[]) = []
    cipher (x:y:[]) = []
    cipher (x:y:z:xs)
        | isDigit x && isLetter y && isLetter z = y:[z]
        | otherwise = cipher (y:z:xs)

    uniques :: Eq a => [a] -> [a]
    uniques [] = []
    uniques ([x]) = [x]
    uniques (x:y:xs)
        | x == y = uniques (y:xs)
        | otherwise = x: uniques (y:xs)
    
    sortMergeDesc :: Ord a => [a] -> [a] -> [a]
    sortMergeDesc [] x = x
    sortMergeDesc x [] = x
    sortMergeDesc (x:xs) (y:ys)
        | x >= y = x : sortMergeDesc xs (y:ys)
        | otherwise = y: sortMergeDesc (x:xs) ys  