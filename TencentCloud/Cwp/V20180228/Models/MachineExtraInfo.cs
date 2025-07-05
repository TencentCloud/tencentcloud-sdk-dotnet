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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("WanIP")]
        public string WanIP{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// 网络类型，1:vpc网络 2:基础网络 3:非腾讯云网络
        /// </summary>
        [JsonProperty("NetworkType")]
        public long? NetworkType{ get; set; }

        /// <summary>
        /// 网络名，vpc网络情况下会返回vpc_id
        /// </summary>
        [JsonProperty("NetworkName")]
        public string NetworkName{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WanIP", this.WanIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkName", this.NetworkName);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
        }
    }
}

