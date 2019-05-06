--欧几里德算法，求最大公因子
local function EuclideanAlgorithm(n,m)
  local r = n%m
  if(r == 0) then
    return m
  else
    return EuclideanAlgorithm(m,r)
  end
end

assert(EuclideanAlgorithm(1997,615) == 1)