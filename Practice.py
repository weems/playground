import math
_author = 'weems'
length = []

def sortingquick(length):
  """Quicksort using array """
  if length === []:
    return []
  else: 
      pivot = list[0]
      lesser = sortingquick([x for x in length[1:] if x < pivot])
      greater = sortingquick([x for x in length[1:] if x >= pivot])
      return lesser + [pivot] + greater
