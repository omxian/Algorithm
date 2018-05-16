--Merge Sort
function Merge(arr,prevIdx,middleIdx,nextIdx)
  local tempArr = {table.unpack(arr)};
  local arrIndex = prevIdx;
  local i = prevIdx;
  local j = middleIdx + 1;
  local k = prevIdx;
  
  while(i<=middleIdx and j<=nextIdx) do
    if(tempArr[i] < tempArr[j]) then
      arr[k] = tempArr[i]
      i = i + 1;
    else
      arr[k] = tempArr[j]
      j = j + 1;
    end
    k = k + 1;
  end
  
  while(i<=middleIdx) do
    arr[k] = tempArr[i];
    i = i + 1;
    k = k + 1;
  end
  
  while(j<=nextIdx) do
    arr[k] = tempArr[j];
    j = j + 1;
    k = k + 1;
  end
end

function MergeSort(arr,prevIdx,nextIdx)
  if(nextIdx > prevIdx) then
    local middleIdx = math.floor((prevIdx+nextIdx)/2);
    MergeSort(arr,prevIdx,middleIdx);
    MergeSort(arr,middleIdx+1,nextIdx);
    Merge(arr,prevIdx,middleIdx,nextIdx);
  end
end

local test = {3, 7, 12, 14, 2, 6, 9, 11};
MergeSort(test, 1, #test);
for k,v in ipairs(test) do
  local result = {2, 3, 6, 7, 9, 11, 12, 14};
  assert(v == result[k]);
end

test = {9,8,7,6,5,4,3,2,1};
MergeSort(test, 1, #test);
for k,v in ipairs(test) do
  local result = {1,2,3,4,5,6,7,8,9};
  assert(v == result[k]);
end