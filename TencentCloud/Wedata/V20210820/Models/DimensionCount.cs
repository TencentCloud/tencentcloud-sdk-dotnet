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

    public class DimensionCount : AbstractModel
    {
        
        /// <summary>
        /// 维度类型1：准确性，2：唯一性，3：完整性，4：一致性，5：及时性，6：有效性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimType")]
        [System.Obsolete]
        public ulong? DimType{ get; set; }

        /// <summary>
        /// 统计值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 维度类型1：准确性，2：唯一性，3：完整性，4：一致性，5：及时性，6：有效性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DimType", this.DimType);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
        }
    }
}

