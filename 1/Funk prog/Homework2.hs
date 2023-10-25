module Homework2 where
    isLowVowel :: Char -> Bool
    isLowVowel a = elem a "aáoóuú" == True
    isLowVowel _ = False

    nand :: Bool -> Bool -> Bool
    nand True True = False
    nand _ _ = True

    implies :: Bool -> Bool -> Bool
    implies True False = False
    implies _ _ = True

    invertY :: (Int, Int) -> (Int, Int)
    invertY (x,y) = (-x, y)

    isOnParabola :: (Int, Int) -> Bool
    isOnParabola (a,b) = b == a^2

    divisionWithTuples :: Integral a => a -> a -> (a,a,Bool)
    divisionWithTuples _ 0 = (0,0,False)
    divisionWithTuples a b = (div a b,mod a b, mod a b == 0 )
    