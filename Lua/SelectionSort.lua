--根据索引交换
function Swap(arr,index1,index2) 
  local temp = arr[index1];
  arr[index1] = arr[index2];
  arr[index2] = temp;
end

--找到最小的Index
function FindMinIndex(arr,startIndex)
  local val = arr[startIndex];
  local idx = startIndex;
  for i=startIndex+1,#arr  do
    if(val > arr[i]) then
      idx = i;
      val = arr[i];
    end
  end
  return idx;
end

function SelectionSort(arr) 
  for i=1,#arr do
    local minIndex = FindMinIndex(arr,i);
    Swap(arr,i,minIndex);
  end
end

local arr = {88,5,2,1,66};
SelectionSort(arr);
for i=1,#arr do
  print(arr[i]);
end