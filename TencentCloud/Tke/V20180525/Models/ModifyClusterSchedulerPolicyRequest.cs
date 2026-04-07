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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterSchedulerPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// SchedulerPolicy配置信息
        /// </summary>
        [JsonProperty("SchedulerPolicyConfig")]
        public SchedulerPolicyConfig[] SchedulerPolicyConfig{ get; set; }

        /// <summary>
        /// 客户端连接
        /// </summary>
        [JsonProperty("ClientConnection")]
        public ClientConnection ClientConnection{ get; set; }

        /// <summary>
        /// 扩展调度器
        /// </summary>
        [JsonProperty("Extenders")]
        public Extenders[] Extenders{ get; set; }

        /// <summary>
        /// 高性能模式
        /// </summary>
        [JsonProperty("HighPerformance")]
        public bool? HighPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "SchedulerPolicyConfig.", this.SchedulerPolicyConfig);
            this.SetParamObj(map, prefix + "ClientConnection.", this.ClientConnection);
            this.SetParamArrayObj(map, prefix + "Extenders.", this.Extenders);
            this.SetParamSimple(map, prefix + "HighPerformance", this.HighPerformance);
        }
    }
}

