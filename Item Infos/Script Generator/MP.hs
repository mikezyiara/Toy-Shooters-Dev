module MP where

import System.Environment
import Data.List

tem = makeJSONTemplate 5000 5100

-- makeJSONTemplate :: Int -> Int -> String
makeJSONTemplate i target
  = concat (intersperse "\n" (map makeString [i..target]))

eight = "      "
twelve = eight ++ "    "

makeString :: Int -> String
makeString i = st5
  where
    st = "  {\n" ++ eight ++ "\"id\":" ++ (show i) ++ ",\n"
    st1 = st ++ twelve ++ "\"name\": " ++ "\"RandomName\",\n"
    st2 = st1 ++ twelve ++ "\"price_c\": " ++ "10000,\n"
    st' = st2 ++ twelve ++ "\"price_p\": " ++ "30000,\n"
    st3 = st' ++ twelve ++  "\"type\":" ++ "\"Rifle\",\n"
    st4 = st3 ++ twelve ++ "\"description\":" ++ "\"Random Description\"\n"
    st4' = st4 ++ twelve ++ "\"rarity\":" ++ "1\n"
    st5 = st4' ++ "  },\n\n\n"

try = makeString 3 ++ "\n" ++ makeString 4

main :: IO ()
main = do
  args <- getArgs
  main' args

  where
    main' :: [String] -> IO ()
    main' [output] = do
      -- replace expand with expandMore for the extension implementation
      writeFile output (tem)
    main' _ = putStrLn ("Usage: runghc MP <output>")
