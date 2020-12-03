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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuantileEntity : AbstractModel
    {
        
        /// <summary>
        /// 最大值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxValue")]
        public string MaxValue{ get; set; }

        /// <summary>
        /// 最小值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinValue")]
        public string MinValue{ get; set; }

        /// <summary>
        /// 五分位值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FifthPositionValue")]
        public string FifthPositionValue{ get; set; }

        /// <summary>
        /// 九分位值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NinthPositionValue")]
        public string NinthPositionValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "MinValue", this.MinValue);
            this.SetParamSimple(map, prefix + "FifthPositionValue", this.FifthPositionValue);
            this.SetParamSimple(map, prefix + "NinthPositionValue", this.NinthPositionValue);
        }
    }
}

