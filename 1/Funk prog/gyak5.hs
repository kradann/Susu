module Gyak5 where
    import Data.Char
    import Prelude hiding((^))

    upperLower :: Char -> Char
    upperLower a
        | isLower a = toUpper a
        | isUpper a = toLower a
        | otherwise = a
    
    sqr :: Num a => a -> a
    sqr a = a*a

    (^) :: Num a => a -> Integer -> a
    x ^ n
        | n == 0 = 1
        | even n = sqr(x^(n `div` 2))
        | otherwise = x*x^(n-1)
    
    toBin :: Integer -> [Int]
    toBin 0 = []
    toBin n
        | even n = 0 : toBin (n `div` 2)
        | otherwise = 1 : toBin (n `div` 2)

    toBinCorrect :: Integer -> [Int]
    toBinCorrect n = reverse (toBin n)

    drop' :: Int -> [a] -> [a]
    drop' _ [] = []
    drop' 0 l = l
    drop' n (x:xs) = drop' (n-1) xs

    take' :: Int -> [a] -> [a]
    take' _ [] = []
    take' 0 _ = []
    take' n (x:xs) = x : take' (n-1) xs

    --insert :: Ord a => a -> [a] -> [a]
    --insert k [] = [k]
    --insert k l@(x:xs)
    --    | x <= k = x : insert k xs
    --    | otherwise k : x : xs
