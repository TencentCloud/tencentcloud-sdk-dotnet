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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceRegionDistributionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>查询区域列表</p>
        /// </summary>
        [JsonProperty("Regions")]
        public string[] Regions{ get; set; }

        /// <summary>
        /// <p>查询实例类型列表</p>
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// <p>查询用户拥有的云桌面地域分布信息</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Regions.", this.Regions);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

