namespace Namespace {
    
    using System.Collections.Generic;
    
    using System.Linq;
    
    public static class Module {
        
        public static object maxDistance(object area) {
            var fields = area[0];
            var towers = area[1];
            var distances = new List<object>();
            foreach (var i in towers) {
                foreach (var _tup_1 in fields.Select((_p_1,_p_2) => Tuple.Create(_p_2, _p_1))) {
                    var idx = _tup_1.Item1;
                    var f = _tup_1.Item2;
                    if (idx > 0 && idx < fields.Count - 1 && !towers.Contains(fields[idx])) {
                        if (towers.Contains(fields[idx - 1]) || towers.Contains(fields[idx + 1])) {
                            if (fields[idx - 1] == i || fields[idx + 1] == i) {
                                distances.append(abs(i - f));
                            }
                        } else {
                            distances.append(abs(i - f));
                        }
                    } else if (idx == 0 && !towers.Contains(fields[idx])) {
                        if (towers.Contains(fields[idx + 1])) {
                            if (fields[idx + 1] == i) {
                                distances.append(abs(i - f));
                            }
                        } else {
                            distances.append(abs(i - f));
                        }
                    } else if (idx == fields.Count - 1 && !towers.Contains(fields[idx])) {
                        if (towers.Contains(fields[idx - 1])) {
                            if (fields[idx - 1] == i) {
                                distances.append(abs(i - f));
                            }
                        } else {
                            distances.append(abs(i - f));
                        }
                    }
                }
            }
            return max(distances);
        }
    }
}
