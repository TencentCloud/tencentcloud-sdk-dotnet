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

namespace TencentCloud.Vpc.V20170312.Models
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
        /// 云服务器实例数。
        /// </summary>
        [JsonProperty("CVM")]
        public ulong? CVM{ get; set; }

        /// <summary>
        /// 数据库实例数。
        /// </summary>
        [JsonProperty("CDB")]
        public ulong? CDB{ get; set; }

        /// <summary>
        /// 弹性网卡实例数。
        /// </summary>
        [JsonProperty("ENI")]
        public ulong? ENI{ get; set; }

        /// <summary>
        /// 被安全组引用数。
        /// </summary>
        [JsonProperty("SG")]
        public ulong? SG{ get; set; }

        /// <summary>
        /// 负载均衡实例数。
        /// </summary>
        [JsonProperty("CLB")]
        public ulong? CLB{ get; set; }

        /// <summary>
        /// 全量实例的绑定统计。
        /// </summary>
        [JsonProperty("InstanceStatistics")]
        public InstanceStatistic[] InstanceStatistics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "CVM", this.CVM);
            this.SetParamSimple(map, prefix + "CDB", this.CDB);
            this.SetParamSimple(map, prefix + "ENI", this.ENI);
            this.SetParamSimple(map, prefix + "SG", this.SG);
            this.SetParamSimple(map, prefix + "CLB", this.CLB);
            this.SetParamArrayObj(map, prefix + "InstanceStatistics.", this.InstanceStatistics);
        }
    }
}

