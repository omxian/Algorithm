local binarySearch = function(arr, targetVal) 
    local min = 1;
    local max = #arr;
    local index;
    
    while(min <= max) do
      index = math.floor((min+max) / 2);
      local value = arr[index];
      if(value == targetVal) then
        return index;
      elseif(value > targetVal) then
        max = index - 1;
      elseif(value < targetVal) then
        min = index + 1;
      end
    end
    
    return  -1;
end

local test = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
assert(21 == binarySearch(test,73));
assert(1 == binarySearch(test,2));
assert(2 == binarySearch(test,3));
assert(-1 ==  binarySearch(test,1));
