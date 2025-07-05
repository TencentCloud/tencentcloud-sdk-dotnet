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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GridPodInfo : AbstractModel
    {
        
        /// <summary>
        /// Pod名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// 状态(Pending｜Running｜Succeeded｜Failed｜Unknown)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 节点名
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 节点IP
        /// </summary>
        [JsonProperty("NodeIP")]
        public string NodeIP{ get; set; }

        /// <summary>
        /// Pod的IP
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// 启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 运行时长（秒）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunSec")]
        public long? RunSec{ get; set; }

        /// <summary>
        /// 重启次数
        /// </summary>
        [JsonProperty("RestartCount")]
        public long? RestartCount{ get; set; }

        /// <summary>
        /// 集群名称ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeIP", this.NodeIP);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "RunSec", this.RunSec);
            this.SetParamSimple(map, prefix + "RestartCount", this.RestartCount);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
        }
    }
}

