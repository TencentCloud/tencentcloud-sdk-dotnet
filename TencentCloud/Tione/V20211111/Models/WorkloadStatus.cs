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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkloadStatus : AbstractModel
    {
        
        /// <summary>
        /// 当前实例数
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// 更新的实例数
        /// </summary>
        [JsonProperty("UpdatedReplicas")]
        public long? UpdatedReplicas{ get; set; }

        /// <summary>
        /// 就绪的实例数
        /// </summary>
        [JsonProperty("ReadyReplicas")]
        public long? ReadyReplicas{ get; set; }

        /// <summary>
        /// 可用的实例数
        /// </summary>
        [JsonProperty("AvailableReplicas")]
        public long? AvailableReplicas{ get; set; }

        /// <summary>
        /// 不可用的实例数
        /// </summary>
        [JsonProperty("UnavailableReplicas")]
        public long? UnavailableReplicas{ get; set; }

        /// <summary>
        /// Normal	正常运行中
        /// Abnormal	服务异常，例如容器启动失败等
        /// Waiting	服务等待中，例如容器下载镜像过程等
        /// Stopped   已停止 
        /// Pending 启动中
        /// Stopping 停止中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 工作负载的状况信息
        /// </summary>
        [JsonProperty("StatefulSetCondition")]
        [System.Obsolete]
        public StatefulSetCondition[] StatefulSetCondition{ get; set; }

        /// <summary>
        /// 工作负载历史的状况信息
        /// </summary>
        [JsonProperty("Conditions")]
        public StatefulSetCondition[] Conditions{ get; set; }

        /// <summary>
        /// 状态异常时，展示原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "UpdatedReplicas", this.UpdatedReplicas);
            this.SetParamSimple(map, prefix + "ReadyReplicas", this.ReadyReplicas);
            this.SetParamSimple(map, prefix + "AvailableReplicas", this.AvailableReplicas);
            this.SetParamSimple(map, prefix + "UnavailableReplicas", this.UnavailableReplicas);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "StatefulSetCondition.", this.StatefulSetCondition);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

