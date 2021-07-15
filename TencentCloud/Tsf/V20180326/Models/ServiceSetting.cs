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

    public class ServiceSetting : AbstractModel
    {
        
        /// <summary>
        /// 0:公网, 1:集群内访问, 2：NodePort, 3: VPC 内网访问
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 容器端口映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtocolPorts")]
        public ProtocolPort[] ProtocolPorts{ get; set; }

        /// <summary>
        /// 子网ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 是否创建 k8s service，默认为 false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisableService")]
        public bool? DisableService{ get; set; }

        /// <summary>
        /// service 是否为 headless 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeadlessService")]
        public bool? HeadlessService{ get; set; }

        /// <summary>
        /// 当为 true 且 DisableService 也为 true 时，会删除之前创建的 service，请小心使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowDeleteService")]
        public bool? AllowDeleteService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "ProtocolPorts.", this.ProtocolPorts);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DisableService", this.DisableService);
            this.SetParamSimple(map, prefix + "HeadlessService", this.HeadlessService);
            this.SetParamSimple(map, prefix + "AllowDeleteService", this.AllowDeleteService);
        }
    }
}

