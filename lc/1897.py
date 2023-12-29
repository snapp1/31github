class Solution:
    def makeEqual(self, words: List[str]) -> bool:
        sum = 0
        for i in words:
            for j in i:
                if j not in mp:
                    mp[j] = 0
                mp[j] += 1
        for i in mp:
            if mp[i] % len(words) != 0:
                return False
        return True