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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoVipInfo : AbstractModel
    {
        
        /// <summary>
        /// 只读vip状态
        /// </summary>
        [JsonProperty("RoVipStatus")]
        public long? RoVipStatus{ get; set; }

        /// <summary>
        /// 只读vip的子网
        /// </summary>
        [JsonProperty("RoSubnetId")]
        public long? RoSubnetId{ get; set; }

        /// <summary>
        /// 只读vip的私有网络
        /// </summary>
        [JsonProperty("RoVpcId")]
        public long? RoVpcId{ get; set; }

        /// <summary>
        /// 只读vip的端口号
        /// </summary>
        [JsonProperty("RoVport")]
        public long? RoVport{ get; set; }

        /// <summary>
        /// 只读vip
        /// </summary>
        [JsonProperty("RoVip")]
        public string RoVip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoVipStatus", this.RoVipStatus);
            this.SetParamSimple(map, prefix + "RoSubnetId", this.RoSubnetId);
            this.SetParamSimple(map, prefix + "RoVpcId", this.RoVpcId);
            this.SetParamSimple(map, prefix + "RoVport", this.RoVport);
            this.SetParamSimple(map, prefix + "RoVip", this.RoVip);
        }
    }
}

