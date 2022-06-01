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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DnsDataFilter : AbstractModel
    {
        
        /// <summary>
        /// 参数名称，取值范围：
        /// zone：站点名
        /// host：域名
        /// type：dns解析类型
        /// code：dns返回状态码
        /// area：解析服务器所在区域
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数值
        /// 当Name=area时，Value取值范围：
        /// 亚洲：Asia
        /// 欧洲：Europe
        /// 非洲：Africa
        /// 大洋洲：Oceania
        /// 美洲：Americas
        /// 
        /// 当Name=code时，Value取值范围：
        /// NoError：成功的响应
        /// NXDomain：只在权威域名服务器的响应消息中有效，标示请求中请求的域不存在
        /// NotImp：域名服务器不支持请求的类型
        /// Refused：域名服务器因为策略的原因拒绝执行请求的操作
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 参数值
        /// 当Name=area时，Value取值范围：
        /// 亚洲：Asia
        /// 欧洲：Europe
        /// 非洲：Africa
        /// 大洋洲：Oceania
        /// 美洲：Americas
        /// 
        /// 当Name=code时，Value取值范围：
        /// NoError：成功的响应
        /// NXDomain：只在权威域名服务器的响应消息中有效，标示请求中请求的域不存在
        /// NotImp：域名服务器不支持请求的类型
        /// Refused：域名服务器因为策略的原因拒绝执行请求的操作
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

