--Quick Sort
function QuickSort(arr,q,r)
  if(r>q) then
    local pivot = Partition(arr,q,r);
    QuickSort(arr,q,pivot-1);
    QuickSort(arr,pivot+1,r);
  end
end

--分区操作，返回基准Index
function Partition(arr,q,r)
  --p为pivot最后应该所在的位置，也就是两个列表的交界处
  --未到最后时，p指向bigger列表的第一个
  --最后再切换位置
  local p = q;
  local pivotValue = arr[r];
  for j=q, r-1,1 do
    if(arr[j] <= pivotValue) then
      Swap(arr,q,j);
      q = q + 1;
    end
  end
  Swap(arr,q,r);
  return q;
end

function Swap(arr,i,j)
  local temp = arr[i];
  arr[i] = arr[j];
  arr[j] = temp;
end

local testArr =  {9, 7, 5, 11, 12, 2, 14, 3, 10, 6};
QuickSort(testArr, 1, #testArr);