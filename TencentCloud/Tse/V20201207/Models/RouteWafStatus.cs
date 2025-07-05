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

    public class RouteWafStatus : AbstractModel
    {
        
        /// <summary>
        /// 路由的名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 路由的 ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        ///  路由是否开启 WAF 防护
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        [JsonProperty("Methods")]
        public string[] Methods{ get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [JsonProperty("Paths")]
        public string[] Paths{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// 路由对应服务的名字
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 路由对应服务的ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Methods.", this.Methods);
            this.SetParamArraySimple(map, prefix + "Paths.", this.Paths);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
        }
    }
}

