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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServerlessSpaceV2Request : AbstractModel
    {
        
        /// <summary>
        /// vpc信息
        /// </summary>
        [JsonProperty("VpcInfo")]
        public VpcInfo[] VpcInfo{ get; set; }

        /// <summary>
        /// 索引空间名
        /// </summary>
        [JsonProperty("SpaceName")]
        public string SpaceName{ get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 白名单列表
        /// </summary>
        [JsonProperty("KibanaWhiteIpList")]
        public string[] KibanaWhiteIpList{ get; set; }

        /// <summary>
        /// 空间id
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamSimple(map, prefix + "SpaceName", this.SpaceName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "KibanaWhiteIpList.", this.KibanaWhiteIpList);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
        }
    }
}

