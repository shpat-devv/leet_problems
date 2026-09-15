class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        prefix = ""
        index = 0

        try:
            current = strs[0][0]
        except:
            return prefix

        while True:
            for x in range(1, len(strs)):
                if strs[x][index] != current:
                    return prefix
                
            prefix += current
            index += 1
            current = strs[0][index]

test = Solution()

print(test.longestCommonPrefix(["flower","flow","flight"]))
print(test.longestCommonPrefix(["", ""]))
print(test.longestCommonPrefix(["ab", "ab", "ab"]))