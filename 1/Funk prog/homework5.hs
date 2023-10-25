module Homework5 where
    mulFirst :: Int -> [Int] -> Int
    mulFirst _ [] = 1
    mulFirst n (x:xs)
        | n <= 0 = 1
        | otherwise = x * mulFirst (n-1) xs
    
    everyThird :: [a] -> [a]
    everyThird [] = []
    everyThird (x:[]) = x : everyThird []
    everyThird (x:y:[]) = x : everyThird []
    everyThird (x:y:z:zs) = x: everyThird zs

    inserthelp :: Int -> a -> [a] -> [a]
    inserthelp 0 c xs = c:xs
    inserthelp b c (x:xs) = x : inserthelp (b-1) c xs

    insertAt :: Int -> a -> [a] -> [a]
    insertAt _ c ([]) = [c]
    insertAt b c (x:xs)
        | b <= 0 = c:x:xs
        | length xs < b-1 = (x: xs) ++ [c]
        | otherwise = inserthelp b c (x:xs)
    
    chonk :: String -> [String]
    chonk "" = []
    chonk xs = xs : chonk (tail xs)