--BubbleSort
function BubbleSort(arr) 
  for i=1,#arr do
    for j=1,#arr-i-1 do
      if(arr[j+1] < arr[j]) then
        Swap(arr,j+1,j);
      end
    end
  end
end

function Swap(arr,i,j)
  local temp = arr[i];
  arr[i] = arr[j];
  arr[j] = temp;
end

local test = {124,5,6,7326,1,3,26,236,74322}
BubbleSort(test);
for k,v in ipairs(test) do
  print(v);
end