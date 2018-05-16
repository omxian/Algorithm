--从1->rightIndex的arr已经排序
local insert = function(arr, rightIndex, value)
  local idx = rightIndex;
  while (idx >= 1 and arr[idx] > value) do
    arr[idx + 1] = arr[idx]; 
    idx = idx-1;
  end
  arr[idx + 1] = value;
end

local insertSort = function(arr) 
  for i=2,#arr,1 do
    insert(arr, i-1, arr[i]);
  end
end

local arr ={4,22,1,55,6,6}; 
insertSort(arr);
for i=1,#arr do
  print(arr[i]);
end