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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点角色, MASTER, WORKER, ETCD, MASTER_ETCD,ALL, 默认为WORKER
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// 实例异常(或者处于初始化中)的原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

        /// <summary>
        /// 实例的状态
        /// - initializing创建中
        /// - running 运行中
        /// - failed 异常
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 是否不可调度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Unschedulable")]
        public bool? Unschedulable{ get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 节点内网IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LanIP")]
        public string LanIP{ get; set; }

        /// <summary>
        /// 资源池ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// 原生节点参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Native")]
        public NativeNodeInfo Native{ get; set; }

        /// <summary>
        /// 普通节点参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regular")]
        public RegularNodeInfo Regular{ get; set; }

        /// <summary>
        /// 超级节点参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Super")]
        public SuperNodeInfo Super{ get; set; }

        /// <summary>
        /// 第三方节点参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("External")]
        public ExternalNodeInfo External{ get; set; }

        /// <summary>
        /// 节点类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "Unschedulable", this.Unschedulable);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "LanIP", this.LanIP);
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamObj(map, prefix + "Native.", this.Native);
            this.SetParamObj(map, prefix + "Regular.", this.Regular);
            this.SetParamObj(map, prefix + "Super.", this.Super);
            this.SetParamObj(map, prefix + "External.", this.External);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
        }
    }
}

