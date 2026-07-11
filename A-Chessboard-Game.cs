

--
-- Complete the 'chessboardGame' function below.
--
-- The function is expected to return a STRING.
-- The function accepts following parameters:
--  1. INTEGER x
--  2. INTEGER y
--



local fptr = io.open(os.getenv("OUTPUT_PATH"), "w")

local t = io.stdin:read("*n", "*l")

for titr = 1, t do
    local firstmultipleinput = {}
    for token in string.gmatch(io.stdin:read("*l"):gsub("%s+$", ""), "[^%s]+") do
        table.insert(firstmultipleinput, token)
    end

    local x = tonumber(firstmultipleinput[1]:match("^%s*(.-)%s*$"))

    local y = tonumber(firstmultipleinput[2]:match("^%s*(.-)%s*$"))

    local result = chessboardGame(x, y)

    fptr:write(result, "\n")
end

fptr:close()
