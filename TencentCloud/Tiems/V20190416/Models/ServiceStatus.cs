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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceStatus : AbstractModel
    {
        
        /// <summary>
        /// 预期副本数
        /// </summary>
        [JsonProperty("DesiredReplicas")]
        public ulong? DesiredReplicas{ get; set; }

        /// <summary>
        /// 当前副本数
        /// </summary>
        [JsonProperty("CurrentReplicas")]
        public ulong? CurrentReplicas{ get; set; }

        /// <summary>
        /// Normal：正常运行中；Abnormal：服务异常，例如容器启动失败等；Waiting：服务等待中，例如容器下载镜像过程等；Stopped：已停止 Stopping 停止中；Resuming：重启中；Updating：服务更新中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 服务处于当前状态的原因集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Conditions")]
        public Conditions[] Conditions{ get; set; }

        /// <summary>
        /// 副本名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Replicas")]
        public string[] Replicas{ get; set; }

        /// <summary>
        /// 运行状态对额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 副本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicaInfos")]
        public ReplicaInfo[] ReplicaInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DesiredReplicas", this.DesiredReplicas);
            this.SetParamSimple(map, prefix + "CurrentReplicas", this.CurrentReplicas);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamArraySimple(map, prefix + "Replicas.", this.Replicas);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "ReplicaInfos.", this.ReplicaInfos);
        }
    }
}

