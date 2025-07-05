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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceNetInfo : AbstractModel
    {
        
        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("InstanceGroupType")]
        public string InstanceGroupType{ get; set; }

        /// <summary>
        /// 实例组ID
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public string InstanceGroupId{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 网络类型, 0-基础网络, 1-vpc网络, 2-黑石网络
        /// </summary>
        [JsonProperty("NetType")]
        public long? NetType{ get; set; }

        /// <summary>
        /// 私有网络IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 私有网络端口
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 外网域名
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// 外网IP
        /// </summary>
        [JsonProperty("WanIP")]
        public string WanIP{ get; set; }

        /// <summary>
        /// 外网端口
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// 外网开启状态
        /// </summary>
        [JsonProperty("WanStatus")]
        public string WanStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceGroupType", this.InstanceGroupType);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "WanIP", this.WanIP);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
        }
    }
}

