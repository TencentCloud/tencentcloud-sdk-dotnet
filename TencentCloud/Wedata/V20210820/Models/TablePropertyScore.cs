/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TablePropertyScore : AbstractModel
    {
        
        /// <summary>
        /// 表ID
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [JsonProperty("DayTime")]
        public string DayTime{ get; set; }

        /// <summary>
        /// 表完整性评分
        /// </summary>
        [JsonProperty("Integrity")]
        public float? Integrity{ get; set; }

        /// <summary>
        /// 表保障性评分
        /// </summary>
        [JsonProperty("Safety")]
        public float? Safety{ get; set; }

        /// <summary>
        /// 表及时性评分
        /// </summary>
        [JsonProperty("Timeliness")]
        public float? Timeliness{ get; set; }

        /// <summary>
        /// 表稳定性评分
        /// </summary>
        [JsonProperty("Stability")]
        public float? Stability{ get; set; }

        /// <summary>
        /// 表规范性评分
        /// </summary>
        [JsonProperty("Normative")]
        public float? Normative{ get; set; }

        /// <summary>
        /// 资产评分平均分
        /// </summary>
        [JsonProperty("Average")]
        public float? Average{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "DayTime", this.DayTime);
            this.SetParamSimple(map, prefix + "Integrity", this.Integrity);
            this.SetParamSimple(map, prefix + "Safety", this.Safety);
            this.SetParamSimple(map, prefix + "Timeliness", this.Timeliness);
            this.SetParamSimple(map, prefix + "Stability", this.Stability);
            this.SetParamSimple(map, prefix + "Normative", this.Normative);
            this.SetParamSimple(map, prefix + "Average", this.Average);
        }
    }
}

