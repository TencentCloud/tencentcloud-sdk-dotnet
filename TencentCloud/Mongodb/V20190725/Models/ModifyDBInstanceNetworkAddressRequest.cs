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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceNetworkAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 原IP保留时长，单位为分钟；原IP会在约定时间后释放，在释放前原IP和新IP均可访问；0表示立即回收原IP
        /// </summary>
        [JsonProperty("OldIpExpiredTime")]
        public ulong? OldIpExpiredTime{ get; set; }

        /// <summary>
        /// 切换后IP地址所属私有网络统一ID，若为基础网络，该字段为空
        /// </summary>
        [JsonProperty("NewUniqVpcId")]
        public string NewUniqVpcId{ get; set; }

        /// <summary>
        /// 切换后IP地址所属子网统一ID，若为基础网络，该字段为空
        /// </summary>
        [JsonProperty("NewUniqSubnetId")]
        public string NewUniqSubnetId{ get; set; }

        /// <summary>
        /// 待修改IP信息
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

