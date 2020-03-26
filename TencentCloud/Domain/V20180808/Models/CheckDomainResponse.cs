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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckDomainResponse : AbstractModel
    {
        
        /// <summary>
        /// 所查询域名名称
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 是否能够注册
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// 不能注册原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 是否是溢价词
        /// </summary>
        [JsonProperty("Premium")]
        public bool? Premium{ get; set; }

        /// <summary>
        /// 域名价格
        /// </summary>
        [JsonProperty("Price")]
        public ulong? Price{ get; set; }

        /// <summary>
        /// 是否是敏感词
        /// </summary>
        [JsonProperty("BlackWord")]
        public bool? BlackWord{ get; set; }

        /// <summary>
        /// 溢价词描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// 溢价词的续费价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeeRenew")]
        public ulong? FeeRenew{ get; set; }

        /// <summary>
        /// 域名真实价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealPrice")]
        public ulong? RealPrice{ get; set; }

        /// <summary>
        /// 溢价词的转入价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeeTransfer")]
        public ulong? FeeTransfer{ get; set; }

        /// <summary>
        /// 溢价词的赎回价格
        /// </summary>
        [JsonProperty("FeeRestore")]
        public ulong? FeeRestore{ get; set; }

        /// <summary>
        /// 检测年限
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "Premium", this.Premium);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "BlackWord", this.BlackWord);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "FeeRenew", this.FeeRenew);
            this.SetParamSimple(map, prefix + "RealPrice", this.RealPrice);
            this.SetParamSimple(map, prefix + "FeeTransfer", this.FeeTransfer);
            this.SetParamSimple(map, prefix + "FeeRestore", this.FeeRestore);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

