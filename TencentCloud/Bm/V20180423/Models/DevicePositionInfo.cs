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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DevicePositionInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

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
        /// 业务IP
        /// </summary>
        [JsonProperty("LanIp")]
        public string LanIp{ get; set; }

        /// <summary>
        /// 实例别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 机架名称
        /// </summary>
        [JsonProperty("RckName")]
        public string RckName{ get; set; }

        /// <summary>
        /// 机位
        /// </summary>
        [JsonProperty("PosCode")]
        public ulong? PosCode{ get; set; }

        /// <summary>
        /// 交换机名称
        /// </summary>
        [JsonProperty("SwitchName")]
        public string SwitchName{ get; set; }

        /// <summary>
        /// 设备交付时间
        /// </summary>
        [JsonProperty("DeliverTime")]
        public string DeliverTime{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "LanIp", this.LanIp);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "RckName", this.RckName);
            this.SetParamSimple(map, prefix + "PosCode", this.PosCode);
            this.SetParamSimple(map, prefix + "SwitchName", this.SwitchName);
            this.SetParamSimple(map, prefix + "DeliverTime", this.DeliverTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
        }
    }
}

