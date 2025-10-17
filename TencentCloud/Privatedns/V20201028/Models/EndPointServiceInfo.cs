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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndPointServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// ip
        /// </summary>
        [JsonProperty("EndPointVip")]
        public string EndPointVip{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 网络侧状态，0 可用，1 待接受，3 拒绝
        /// </summary>
        [JsonProperty("EndPointState")]
        public ulong? EndPointState{ get; set; }

        /// <summary>
        /// 状态，1表示可用，0表示删除
        /// </summary>
        [JsonProperty("EndPointStatus")]
        public ulong? EndPointStatus{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("EndPointRemark")]
        public string EndPointRemark{ get; set; }

        /// <summary>
        /// 网络侧隔离状态，1：已隔离，0：未隔离
        /// </summary>
        [JsonProperty("EndPointIsolateFlag")]
        public ulong? EndPointIsolateFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndPointVip", this.EndPointVip);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "EndPointState", this.EndPointState);
            this.SetParamSimple(map, prefix + "EndPointStatus", this.EndPointStatus);
            this.SetParamSimple(map, prefix + "EndPointRemark", this.EndPointRemark);
            this.SetParamSimple(map, prefix + "EndPointIsolateFlag", this.EndPointIsolateFlag);
        }
    }
}

