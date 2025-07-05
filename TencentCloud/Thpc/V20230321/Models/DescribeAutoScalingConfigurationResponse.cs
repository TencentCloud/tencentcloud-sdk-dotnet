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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAutoScalingConfigurationResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群ID。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 任务连续等待时间，队列的任务处于连续等待的时间。单位秒。
        /// </summary>
        [JsonProperty("ExpansionBusyTime")]
        public long? ExpansionBusyTime{ get; set; }

        /// <summary>
        /// 节点连续空闲（未运行作业）时间，一个节点连续处于空闲状态时间。
        /// </summary>
        [JsonProperty("ShrinkIdleTime")]
        public long? ShrinkIdleTime{ get; set; }

        /// <summary>
        /// 扩容队列配置概览列表。
        /// </summary>
        [JsonProperty("QueueConfigs")]
        public QueueConfigOverview[] QueueConfigs{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ExpansionBusyTime", this.ExpansionBusyTime);
            this.SetParamSimple(map, prefix + "ShrinkIdleTime", this.ShrinkIdleTime);
            this.SetParamArrayObj(map, prefix + "QueueConfigs.", this.QueueConfigs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

