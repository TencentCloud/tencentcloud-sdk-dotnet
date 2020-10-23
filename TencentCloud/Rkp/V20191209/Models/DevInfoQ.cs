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

namespace TencentCloud.Rkp.V20191209.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DevInfoQ : AbstractModel
    {
        
        /// <summary>
        /// devid
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 风险值
        /// </summary>
        [JsonProperty("RiskScore")]
        public long? RiskScore{ get; set; }

        /// <summary>
        /// 风险详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskInfo")]
        public RiskDetail[] RiskInfo{ get; set; }

        /// <summary>
        /// 概率值
        /// </summary>
        [JsonProperty("Probability")]
        public float? Probability{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "RiskScore", this.RiskScore);
            this.SetParamArrayObj(map, prefix + "RiskInfo.", this.RiskInfo);
            this.SetParamSimple(map, prefix + "Probability", this.Probability);
        }
    }
}

