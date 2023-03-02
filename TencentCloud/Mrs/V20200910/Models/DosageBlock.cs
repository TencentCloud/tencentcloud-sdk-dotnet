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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DosageBlock : AbstractModel
    {
        
        /// <summary>
        /// 值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 单次计量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SingleMeasurement")]
        public string SingleMeasurement{ get; set; }

        /// <summary>
        /// 频次
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// 给药途径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DrugDeliveryRoute")]
        public string DrugDeliveryRoute{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "SingleMeasurement", this.SingleMeasurement);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "DrugDeliveryRoute", this.DrugDeliveryRoute);
        }
    }
}

