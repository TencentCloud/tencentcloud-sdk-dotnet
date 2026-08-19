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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContainerPortItem : AbstractModel
    {
        
        /// <summary>
        /// 监听进程名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 容器内监听端口
        /// </summary>
        [JsonProperty("ContainerPort")]
        public long? ContainerPort{ get; set; }

        /// <summary>
        /// 进程运行用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// 容器内进程ID
        /// </summary>
        [JsonProperty("ContainerPID")]
        public long? ContainerPID{ get; set; }

        /// <summary>
        /// 宿主机内网IP地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostInnerIP")]
        public string HostInnerIP{ get; set; }

        /// <summary>
        /// 宿主机外网IP地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostPublicIP")]
        public string HostPublicIP{ get; set; }

        /// <summary>
        /// 宿主机映射端口
        /// </summary>
        [JsonProperty("PublicPort")]
        public long? PublicPort{ get; set; }

        /// <summary>
        /// 网络协议类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamSimple(map, prefix + "ContainerPID", this.ContainerPID);
            this.SetParamSimple(map, prefix + "HostInnerIP", this.HostInnerIP);
            this.SetParamSimple(map, prefix + "HostPublicIP", this.HostPublicIP);
            this.SetParamSimple(map, prefix + "PublicPort", this.PublicPort);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
        }
    }
}

