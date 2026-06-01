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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDataRetrievalRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数据检索ID示例值：dataretrieval-123456</p>
        /// </summary>
        [JsonProperty("DataRetrievalId")]
        public string DataRetrievalId{ get; set; }

        /// <summary>
        /// <p>数据检索名称示例值：DataDive</p>
        /// </summary>
        [JsonProperty("DataRetrievalName")]
        public string DataRetrievalName{ get; set; }

        /// <summary>
        /// <p>聚合检索条件 示例值：from entries|where size &gt;4096</p>
        /// </summary>
        [JsonProperty("CompoundCondition")]
        public string CompoundCondition{ get; set; }

        /// <summary>
        /// <p>列表检索条件</p>
        /// </summary>
        [JsonProperty("QueryCondition")]
        public string QueryCondition{ get; set; }

        /// <summary>
        /// <p>数据检索按月重复，每月1-31号，选择一天，每月将在这一天自动创建快照；例如1 代表1号；与DayOfWeek二选一</p>
        /// </summary>
        [JsonProperty("DayOfMonth")]
        public string DayOfMonth{ get; set; }

        /// <summary>
        /// <p>数据检索重复日期，星期一到星期日。 1代表星期一、7代表星期天，与DayOfMonth，二选一</p>
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public string DayOfWeek{ get; set; }

        /// <summary>
        /// <p>重复时间点,0-23，小时</p>
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataRetrievalId", this.DataRetrievalId);
            this.SetParamSimple(map, prefix + "DataRetrievalName", this.DataRetrievalName);
            this.SetParamSimple(map, prefix + "CompoundCondition", this.CompoundCondition);
            this.SetParamSimple(map, prefix + "QueryCondition", this.QueryCondition);
            this.SetParamSimple(map, prefix + "DayOfMonth", this.DayOfMonth);
            this.SetParamSimple(map, prefix + "DayOfWeek", this.DayOfWeek);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
        }
    }
}

