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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceNetworkAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定需修改网络的实例 ID。例如：cmgo-p8vn****。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 原 IP 地址保留时长。
        /// - 单位为分钟，0表示立即回收原 IP 地址。
        /// - 原 IP 将在约定时间后释放，在释放前原 IP和新 IP均可访问。
        /// </summary>
        [JsonProperty("OldIpExpiredTime")]
        public ulong? OldIpExpiredTime{ get; set; }

        /// <summary>
        /// 切换后的私有网络 ID，若实例当前为基础网络，该字段无需配置。
        /// </summary>
        [JsonProperty("NewUniqVpcId")]
        public string NewUniqVpcId{ get; set; }

        /// <summary>
        /// 切换私有网络的子网 ID。若实例当前为基础网络，该字段无需配置。
        /// </summary>
        [JsonProperty("NewUniqSubnetId")]
        public string NewUniqSubnetId{ get; set; }

        /// <summary>
        /// IP 地址信息，包含新 IP 地址与 原 IP 地址。
        /// </summary>
        [JsonProperty("NetworkAddresses")]
        public ModifyNetworkAddress[] NetworkAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OldIpExpiredTime", this.OldIpExpiredTime);
            this.SetParamSimple(map, prefix + "NewUniqVpcId", this.NewUniqVpcId);
            this.SetParamSimple(map, prefix + "NewUniqSubnetId", this.NewUniqSubnetId);
            this.SetParamArrayObj(map, prefix + "NetworkAddresses.", this.NetworkAddresses);
        }
    }
}

