var checkInclusion = function (s1, s2) {
  const lengthOfs1 = s1.length;
  const lengthOfs2 = s2.length;
  let res = 0;
  for (let i = 0; i < lengthOfs1; i++) {
    res += s1.charCodeAt(i) ** 7;
  }

  for (let i = 0; i < lengthOfs2; i++) {
    if (!s1.includes(s2[i])) continue;

    let sum = 0;
    for (let ii = i; ii < i + lengthOfs1; ii++) {
      sum += s2.charCodeAt(ii) ** 7;
    }

    if (sum == res) return true;
  }

  return false;
};

var checkInclusionEnhanced = function (s1, s2) {
  if (s1.length > s2.length) {
    return false;
  }

  const lengthOfs1 = s1.length;
  const lengthOfs2 = s2.length;

  const s1Count = new Array(26).fill(0);
  const s2Count = new Array(26).fill(0);

  for (let i = 0; i < lengthOfs1; i++) {
    s1Count[s1.charCodeAt(i) - "a".charCodeAt(0)]++;
    s2Count[s2.charCodeAt(i) - "a".charCodeAt(0)]++;
  }

  let matches = 0;
  for (let i = 0; i < 26; i++) {
    if (s1Count[i] === s2Count[i]) {
      matches++;
    }
  }

  let l = 0;
  for (let r = lengthOfs1; r < lengthOfs2; r++) {
    if (matches === 26) return true;

    let index = s2.charCodeAt(r) - "a".charCodeAt(0);
    s2Count[index]++;
    if (s1Count[index] === s2Count[index]) matches++;
    else if (s1Count[index] + 1 === s2Count[index]) matches--;

    index = s2.charCodeAt(l) - "a".charCodeAt(0);
    s2Count[index]--;
    if (s1Count[index] === s2Count[index]) matches++;
    else if (s1Count[index] - 1 === s2Count[index]) matches--;

    l++;
  }

  return matches === 26;
};
let s1 = "cba",
  s2 = "lecabee";

console.log(checkInclusion(s1, s2));
