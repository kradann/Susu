module Gyak2 where

    returnFrist :: a -> b -> a
    returnFrist a _ = a  -- aláhúzás joker

    foo :: Bool -> Bool -> Bool
    foo True True = True
    --foo True False = False
    --foo False True = False
    --foo False False = False helyett
    foo _ _ = False
    --parciális függény
    -- toltális függvény (mindenre visszaad valamit)
    -- True és False függvény

    not' :: Bool -> Bool
    not' True = False
    not' False = True
    
    double :: Int -> (Int, Int)
    double a = (a, a)
    -- (a,b) fst visszaadja az a-t snd visszadaj a b-t
    scrap :: (Int, Int) -> Int
    scrap (a, b) = a

    func :: Num a => a -> a -> a
    func a b = a + b