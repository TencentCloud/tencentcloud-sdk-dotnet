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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdrAlertCountItem : AbstractModel
    {
        
        /// <summary>
        /// <p>查询实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>总告警条数</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>病毒木马（VIRUS_TROJAN）数量</p>
        /// </summary>
        [JsonProperty("VirusTrojanCount")]
        public long? VirusTrojanCount{ get; set; }

        /// <summary>
        /// <p>异常登录（ABNORMAL_LOGIN）数量</p>
        /// </summary>
        [JsonProperty("AbnormalLoginCount")]
        public long? AbnormalLoginCount{ get; set; }

        /// <summary>
        /// <p>主机行为（HOST_BEHAVIOR）数量</p>
        /// </summary>
        [JsonProperty("HostBehaviorCount")]
        public long? HostBehaviorCount{ get; set; }

        /// <summary>
        /// <p>网络行为（NETWORK_BEHAVIOR）数量</p>
        /// </summary>
        [JsonProperty("NetworkBehaviorCount")]
        public long? NetworkBehaviorCount{ get; set; }

        /// <summary>
        /// <p>存在告警的主机数量（仅 GlobalCount 模式有值）</p>
        /// </summary>
        [JsonProperty("InstancesCount")]
        public ulong? InstancesCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "VirusTrojanCount", this.VirusTrojanCount);
            this.SetParamSimple(map, prefix + "AbnormalLoginCount", this.AbnormalLoginCount);
            this.SetParamSimple(map, prefix + "HostBehaviorCount", this.HostBehaviorCount);
            this.SetParamSimple(map, prefix + "NetworkBehaviorCount", this.NetworkBehaviorCount);
            this.SetParamSimple(map, prefix + "InstancesCount", this.InstancesCount);
        }
    }
}

