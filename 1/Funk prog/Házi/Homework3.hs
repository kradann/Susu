module Homework3 where
    veryPutIntoList :: a -> [[a]]
    veryPutIntoList x = [[x]]

    intervalWithSkip :: Int -> Int -> [Int]
    --intervalWithSkip x y = if x>y then [] else [x, x+2..y]
    intervalWithSkip x y = [x, x+2..y]
    --intervalWithSkip _ _ = []
    

    condAddToList :: a -> Bool -> [a] -> [a] -> [a]
    --condAddToList b c d e = if c then d ++ (b : e) else d ++ e
    condAddToList b True d e = d ++ (b:e)
    condAddToList b False d e = d ++ e 

    fifthRoot :: Integer -> Integer
    fifthRoot x = floor (fromIntegral x ** (1/5))
