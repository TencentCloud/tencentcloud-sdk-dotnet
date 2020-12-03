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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GatewayDeployGroup : AbstractModel
    {
        
        /// <summary>
        /// 网关部署组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// 网关部署组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployGroupName")]
        public string DeployGroupName{ get; set; }

        /// <summary>
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 应用分类：V：虚拟机应用，C：容器应用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 部署组应用状态,取值: Running、Waiting、Paused、Updating、RollingBack、Abnormal、Unknown
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupStatus")]
        public string GroupStatus{ get; set; }

        /// <summary>
        /// 集群类型，C ：容器，V：虚拟机
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployGroupId", this.DeployGroupId);
            this.SetParamSimple(map, prefix + "DeployGroupName", this.DeployGroupName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
        }
    }
}

