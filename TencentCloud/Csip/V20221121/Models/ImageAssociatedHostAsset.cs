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

    public class ImageAssociatedHostAsset : AbstractModel
    {
        
        /// <summary>
        /// <p>主机uuid</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>主机quuid</p>
        /// </summary>
        [JsonProperty("QUuid")]
        public string QUuid{ get; set; }

        /// <summary>
        /// <p>主机名</p>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>主机所属账号名</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>主机所属账号appid</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>主机所属账号uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>主机内网地址</p>
        /// </summary>
        [JsonProperty("InnerIp")]
        public string InnerIp{ get; set; }

        /// <summary>
        /// <p>主机公网地址</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>主机上agent状态</p><p>枚举值：</p><ul><li>ONLINE： 在线</li><li>OFFLINE： 离线</li><li>UNINSTALL： 已卸载</li></ul>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>主机实例id</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>主机状态</p>
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "QUuid", this.QUuid);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "InnerIp", this.InnerIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
        }
    }
}

