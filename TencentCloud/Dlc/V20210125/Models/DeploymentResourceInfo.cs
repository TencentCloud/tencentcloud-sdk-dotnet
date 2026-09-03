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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeploymentResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>部署业务唯一标识（deploymentUid）</p>
        /// </summary>
        [JsonProperty("DeploymentId")]
        public string DeploymentId{ get; set; }

        /// <summary>
        /// <p>部署名称</p>
        /// </summary>
        [JsonProperty("DeploymentName")]
        public string DeploymentName{ get; set; }

        /// <summary>
        /// <p>部署状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Worker 节点 BillingItem</p>
        /// </summary>
        [JsonProperty("WorkerBillingItem")]
        public string WorkerBillingItem{ get; set; }

        /// <summary>
        /// <p>Worker 节点规格倍数</p>
        /// </summary>
        [JsonProperty("WorkerSpec")]
        public long? WorkerSpec{ get; set; }

        /// <summary>
        /// <p>Worker 节点资源类型，枚举： • GU — GPU 计费单位 • CU — CPU 计费单位</p>
        /// </summary>
        [JsonProperty("WorkerResourceType")]
        public string WorkerResourceType{ get; set; }

        /// <summary>
        /// <p>Head 节点 BillingItem</p>
        /// </summary>
        [JsonProperty("HeadBillingItem")]
        public string HeadBillingItem{ get; set; }

        /// <summary>
        /// <p>Head 节点规格倍数</p>
        /// </summary>
        [JsonProperty("HeadSpec")]
        public long? HeadSpec{ get; set; }

        /// <summary>
        /// <p>Head 节点资源类型。当前实现恒为 CU</p>
        /// </summary>
        [JsonProperty("HeadResourceType")]
        public string HeadResourceType{ get; set; }

        /// <summary>
        /// <p>GPU 型号。CPU 部署或型号未知时为空串 &quot;&quot;</p>
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// <p>期望副本数</p>
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeploymentId", this.DeploymentId);
            this.SetParamSimple(map, prefix + "DeploymentName", this.DeploymentName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "WorkerBillingItem", this.WorkerBillingItem);
            this.SetParamSimple(map, prefix + "WorkerSpec", this.WorkerSpec);
            this.SetParamSimple(map, prefix + "WorkerResourceType", this.WorkerResourceType);
            this.SetParamSimple(map, prefix + "HeadBillingItem", this.HeadBillingItem);
            this.SetParamSimple(map, prefix + "HeadSpec", this.HeadSpec);
            this.SetParamSimple(map, prefix + "HeadResourceType", this.HeadResourceType);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
        }
    }
}

