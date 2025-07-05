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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttackEvent : AbstractModel
    {
        
        /// <summary>
        /// 来源ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaSrcIp")]
        public string SsaSrcIp{ get; set; }

        /// <summary>
        /// 目标ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaDstIp")]
        public string SsaDstIp{ get; set; }

        /// <summary>
        /// 目标省份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaDstProvince")]
        public string SsaDstProvince{ get; set; }

        /// <summary>
        /// 目标城市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaDstCity")]
        public string SsaDstCity{ get; set; }

        /// <summary>
        /// 目标国家
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaDstCountry")]
        public string SsaDstCountry{ get; set; }

        /// <summary>
        /// 来源省份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaSrcProvince")]
        public string SsaSrcProvince{ get; set; }

        /// <summary>
        /// 来源国家
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaSrcCountry")]
        public string SsaSrcCountry{ get; set; }

        /// <summary>
        /// 来源城市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaSrcCity")]
        public string SsaSrcCity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SsaSrcIp", this.SsaSrcIp);
            this.SetParamSimple(map, prefix + "SsaDstIp", this.SsaDstIp);
            this.SetParamSimple(map, prefix + "SsaDstProvince", this.SsaDstProvince);
            this.SetParamSimple(map, prefix + "SsaDstCity", this.SsaDstCity);
            this.SetParamSimple(map, prefix + "SsaDstCountry", this.SsaDstCountry);
            this.SetParamSimple(map, prefix + "SsaSrcProvince", this.SsaSrcProvince);
            this.SetParamSimple(map, prefix + "SsaSrcCountry", this.SsaSrcCountry);
            this.SetParamSimple(map, prefix + "SsaSrcCity", this.SsaSrcCity);
        }
    }
}

