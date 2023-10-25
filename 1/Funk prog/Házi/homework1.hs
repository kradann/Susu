module Homework1 where

 intExpr1 :: Int
 intExpr1 = 69

 intExpr2 :: Int
 intExpr2 = 420

 intExpr3 :: Int
 intExpr3 = 69420

 triple :: Int -> Int
 triple a = a * 3

 inc :: Int -> Int
 inc n = n + 1

 sevenTeen1 :: Int
 sevenTeen1 = inc(inc(triple(inc(inc(triple(inc(0)))))))

 sevenTeen2 :: Int
 sevenTeen2  = inc(inc(inc(inc(inc(triple(inc(triple(inc(0)))))))))

 sevenTeen3 :: Int
 sevenTeen3  = inc(inc(inc(inc(inc(inc(inc(inc(triple(triple(inc(0)))))))))))

 foo :: Int -> a -> a -> Bool
 foo a b c = (a `mod` 2) == 0

 ter :: Int -> Int -> Int
 ter a b = a*b

 ker :: Int -> Int -> Int
 ker a b = 2*a + 2*b