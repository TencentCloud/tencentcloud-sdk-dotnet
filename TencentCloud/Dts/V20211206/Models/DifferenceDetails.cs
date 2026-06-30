/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DifferenceDetails : AbstractModel
    {
        
        /// <summary>
        /// 校验结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 源库gtid set
        /// </summary>
        [JsonProperty("SrcGtidSets")]
        public string SrcGtidSets{ get; set; }

        /// <summary>
        /// 目标库gtid set
        /// </summary>
        [JsonProperty("DstGtidSets")]
        public string DstGtidSets{ get; set; }

        /// <summary>
        /// 源库差异的gtid set
        /// </summary>
        [JsonProperty("DiffSrc")]
        public string DiffSrc{ get; set; }

        /// <summary>
        /// 源库中不一致的表
        /// </summary>
        [JsonProperty("DiffSrcTables")]
        public string[] DiffSrcTables{ get; set; }

        /// <summary>
        /// 目标库差异的gtid set
        /// </summary>
        [JsonProperty("DiffDst")]
        public string DiffDst{ get; set; }

        /// <summary>
        /// 校验结束时间
        /// </summary>
        [JsonProperty("CompareTimestamp")]
        public string CompareTimestamp{ get; set; }

        /// <summary>
        /// 同步范围内的不一致表
        /// </summary>
        [JsonProperty("DiffSrcTablesNeedSync")]
        public string[] DiffSrcTablesNeedSync{ get; set; }

        /// <summary>
        /// 同步范围内是否存在不一致的表
        /// </summary>
        [JsonProperty("DiffSrcIsNeedSync")]
        public bool? DiffSrcIsNeedSync{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "SrcGtidSets", this.SrcGtidSets);
            this.SetParamSimple(map, prefix + "DstGtidSets", this.DstGtidSets);
            this.SetParamSimple(map, prefix + "DiffSrc", this.DiffSrc);
            this.SetParamArraySimple(map, prefix + "DiffSrcTables.", this.DiffSrcTables);
            this.SetParamSimple(map, prefix + "DiffDst", this.DiffDst);
            this.SetParamSimple(map, prefix + "CompareTimestamp", this.CompareTimestamp);
            this.SetParamArraySimple(map, prefix + "DiffSrcTablesNeedSync.", this.DiffSrcTablesNeedSync);
            this.SetParamSimple(map, prefix + "DiffSrcIsNeedSync", this.DiffSrcIsNeedSync);
        }
    }
}

