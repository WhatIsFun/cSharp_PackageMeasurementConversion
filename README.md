 It is designed to solve the problem of converting measurement input strings into a list of the total
values of measured inflows for each package.
1. The input strings represent measurement packages and follow a specific encoding format. Each package
consists of a number indicating the count of values measured in each measurement cycle, followed by
the measured values.
2. The values are encoded using alphabetical characters, with "a" representing 1, "b" representing 2, and so
on, up to "z" representing 26.
3. Numbers higher than 26 are encoded with multiple characters that are added together. The encoding
format is terminated with the first non-"z" character following a sequence of multiple characters
representing a number.

Examples:
Input: aa
Body: [1]

Input=abbcc
Body: [2, 6]

Input: dz_a_aazzaaa
Output: [28, 53, 1]

Input: a_
Output: [0]

Input: abcdabcdab
Output: [2, 7, 7]

Input: abcdabcdab_
Output: [2, 7, 7, 0]
