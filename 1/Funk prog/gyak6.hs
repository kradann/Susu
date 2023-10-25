module Gyak6 where
    
    inc' :: Num a => a -> a
    inc' = (+1)

    inc :: Num a => a -> a
    inc = \x -> x+1


    map' :: (a -> b) -> [a] -> [b]
    map' f [] = []
    map' f (x:xs) = f x : map' f xs

    filter' :: (a->Bool) -> [a] -> [a]
    filter' p [] = []
    filter' p (x:xs)
        | p x = x : filter' p xs
        | otherwise = filter' p xs