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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataMaskStrategyPolicy : AbstractModel
    {
        
        /// <summary>
        /// 数据脱敏权限对象
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyInfo")]
        public Policy PolicyInfo{ get; set; }

        /// <summary>
        /// 数据脱敏策略ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataMaskStrategyId")]
        public string DataMaskStrategyId{ get; set; }

        /// <summary>
        /// 绑定字段类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColumnType")]
        public string ColumnType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PolicyInfo.", this.PolicyInfo);
            this.SetParamSimple(map, prefix + "DataMaskStrategyId", this.DataMaskStrategyId);
            this.SetParamSimple(map, prefix + "ColumnType", this.ColumnType);
        }
    }
}

