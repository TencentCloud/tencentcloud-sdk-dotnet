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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceNetworkRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 新VPC网络Id
        /// </summary>
        [JsonProperty("NewVpcId")]
        public string NewVpcId{ get; set; }

        /// <summary>
        /// 新子网Id
        /// </summary>
        [JsonProperty("NewSubnetId")]
        public string NewSubnetId{ get; set; }

        /// <summary>
        /// 原vip保留时长，单位小时，默认为0，代表立即回收，最大为168小时
        /// </summary>
        [JsonProperty("OldIpRetainTime")]
        public long? OldIpRetainTime{ get; set; }

        /// <summary>
        /// 指定VIP地址
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NewVpcId", this.NewVpcId);
            this.SetParamSimple(map, prefix + "NewSubnetId", this.NewSubnetId);
            this.SetParamSimple(map, prefix + "OldIpRetainTime", this.OldIpRetainTime);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
        }
    }
}

