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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VmGroupOther : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 程序包ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 程序包名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 程序包版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// 部署组实例数
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 部署组运行中实例数
        /// </summary>
        [JsonProperty("RunInstanceCount")]
        public long? RunInstanceCount{ get; set; }

        /// <summary>
        /// 部署组中停止实例数
        /// </summary>
        [JsonProperty("OffInstanceCount")]
        public long? OffInstanceCount{ get; set; }

        /// <summary>
        /// 部署组状态，Running运行中，Waiting等待中，Paused暂停中，Updating更新中，RollingBack回滚中，Abnormal异常，Unknown未知
        /// </summary>
        [JsonProperty("GroupStatus")]
        public string GroupStatus{ get; set; }

        /// <summary>
        /// 服务配置信息是否匹配
        /// </summary>
        [JsonProperty("IsNotEqualServiceConfig")]
        public bool? IsNotEqualServiceConfig{ get; set; }

        /// <summary>
        /// HealthCheckSettings
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "RunInstanceCount", this.RunInstanceCount);
            this.SetParamSimple(map, prefix + "OffInstanceCount", this.OffInstanceCount);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
            this.SetParamSimple(map, prefix + "IsNotEqualServiceConfig", this.IsNotEqualServiceConfig);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
        }
    }
}

