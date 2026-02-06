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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceStateResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群状态，例如：Serving
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 集群操作创建时间
        /// </summary>
        [JsonProperty("FlowCreateTime")]
        public string FlowCreateTime{ get; set; }

        /// <summary>
        /// 集群操作名称
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 集群操作进度
        /// </summary>
        [JsonProperty("FlowProgress")]
        public float? FlowProgress{ get; set; }

        /// <summary>
        /// 集群状态描述，例如：运行中
        /// </summary>
        [JsonProperty("InstanceStateDesc")]
        public string InstanceStateDesc{ get; set; }

        /// <summary>
        /// 集群流程错误信息，例如：“创建失败，资源不足”
        /// </summary>
        [JsonProperty("FlowMsg")]
        public string FlowMsg{ get; set; }

        /// <summary>
        /// 当前步骤的名称，例如：”购买资源中“
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 集群备份任务开启状态
        /// </summary>
        [JsonProperty("BackupStatus")]
        public long? BackupStatus{ get; set; }

        /// <summary>
        /// 集群备份任务开启状态2
        /// </summary>
        [JsonProperty("BackupOpenStatus")]
        public long? BackupOpenStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "FlowCreateTime", this.FlowCreateTime);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowProgress", this.FlowProgress);
            this.SetParamSimple(map, prefix + "InstanceStateDesc", this.InstanceStateDesc);
            this.SetParamSimple(map, prefix + "FlowMsg", this.FlowMsg);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "BackupStatus", this.BackupStatus);
            this.SetParamSimple(map, prefix + "BackupOpenStatus", this.BackupOpenStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

