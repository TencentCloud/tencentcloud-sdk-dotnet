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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupAssociationStatistics : AbstractModel
    {
        
        /// <summary>
        /// 安全组实例ID。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// ECM实例数。
        /// </summary>
        [JsonProperty("ECM")]
        public long? ECM{ get; set; }

        /// <summary>
        /// ECM模块数。
        /// </summary>
        [JsonProperty("Module")]
        public long? Module{ get; set; }

        /// <summary>
        /// 弹性网卡实例数。
        /// </summary>
        [JsonProperty("ENI")]
        public long? ENI{ get; set; }

        /// <summary>
        /// 被安全组引用数。
        /// </summary>
        [JsonProperty("SG")]
        public long? SG{ get; set; }

        /// <summary>
        /// 负载均衡实例数。
        /// </summary>
        [JsonProperty("CLB")]
        public long? CLB{ get; set; }

        /// <summary>
        /// 全量实例的绑定统计。
        /// </summary>
        [JsonProperty("InstanceStatistics")]
        public InstanceStatistic[] InstanceStatistics{ get; set; }

        /// <summary>
        /// 所有资源的总计数（不包含被安全组引用数）。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "ECM", this.ECM);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ENI", this.ENI);
            this.SetParamSimple(map, prefix + "SG", this.SG);
            this.SetParamSimple(map, prefix + "CLB", this.CLB);
            this.SetParamArrayObj(map, prefix + "InstanceStatistics.", this.InstanceStatistics);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

