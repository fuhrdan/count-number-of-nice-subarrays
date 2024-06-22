//*****************************************************************************
//** 1248. Count Number of Nice Subarrays leetcode                           **
//** I started with going through and having a "sliding window" approach,    **
//** it wasn't working correctly and took a lot of time.  Then I started     **
//** reading (I know, hard for someone who is functionally illiterate) and   **
//** and went with the tried and true "hash table" solution for a leetcode   **
//** problem.  It worked, but is middle-of-the-road.  --Dan                  **
//*****************************************************************************

int numberOfSubarrays(int* nums, int numsSize, int k){
    int retNum[2];
    int res = 0;
    int pre = 0;
    int current = 0;
    for(int i = 0; i < numsSize; i++)
    {
        retNum[nums[i] & 1]++;
        if(retNum[1] == k)
        {
            pre = current;
        }
        while(retNum[1] == k)
        {
            retNum[nums[current] & 1]--;
            current++;
        }
        res = res + current - pre;
    }
    return res;
}