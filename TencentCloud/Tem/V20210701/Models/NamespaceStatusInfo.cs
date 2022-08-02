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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamespaceStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 命名空间id
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// TCB envId | EKS clusterId
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 环境状态
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 环境启动状态（不在启动中为null）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentStartingStatus")]
        public TemEnvironmentStartingStatus EnvironmentStartingStatus{ get; set; }

        /// <summary>
        /// 环境停止状态（不在停止中为null）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentStoppingStatus")]
        public TemEnvironmentStoppingStatus EnvironmentStoppingStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamObj(map, prefix + "EnvironmentStartingStatus.", this.EnvironmentStartingStatus);
            this.SetParamObj(map, prefix + "EnvironmentStoppingStatus.", this.EnvironmentStoppingStatus);
        }
    }
}

