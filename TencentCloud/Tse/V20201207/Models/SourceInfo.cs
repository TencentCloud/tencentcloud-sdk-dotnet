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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceInfo : AbstractModel
    {
        
        /// <summary>
        /// 微服务引擎接入IP地址信息
        /// </summary>
        [JsonProperty("Addresses")]
        public string[] Addresses{ get; set; }

        /// <summary>
        /// 微服务引擎VPC信息
        /// </summary>
        [JsonProperty("VpcInfo")]
        public SourceInstanceVpcInfo VpcInfo{ get; set; }

        /// <summary>
        /// 微服务引擎鉴权信息
        /// </summary>
        [JsonProperty("Auth")]
        public SourceInstanceAuth Auth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Addresses.", this.Addresses);
            this.SetParamObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamObj(map, prefix + "Auth.", this.Auth);
        }
    }
}

