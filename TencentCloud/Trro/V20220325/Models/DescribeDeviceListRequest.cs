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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>设备所属项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>设备类型筛选，不填默认为全部设备类型</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>对设备ID或Name按关键字进行模糊匹配，不填则不进行模糊匹配</p>
        /// </summary>
        [JsonProperty("SearchWords")]
        public string SearchWords{ get; set; }

        /// <summary>
        /// <p>每页返回的最大设备数，不填默认为10</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>当前页码，不填默认为1（首页）</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>设备状态筛选，不填默认为不过滤。取值：[&quot;ready&quot;,&quot;connected&quot;,&quot;online&quot;]，online代表ready或connected</p>
        /// </summary>
        [JsonProperty("DeviceStatus")]
        public string DeviceStatus{ get; set; }

        /// <summary>
        /// <p>标识查询项目下的设备注册类型，默认不包含免注册登录设备。 若存在免注册登录设备，该参数传&quot;1&quot;</p><p>枚举值：</p><ul><li>0： 项目不包含免注册登录设备</li><li>1： 项目包含免注册登录设备</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("RegisterType")]
        public long? RegisterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "SearchWords", this.SearchWords);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "DeviceStatus", this.DeviceStatus);
            this.SetParamSimple(map, prefix + "RegisterType", this.RegisterType);
        }
    }
}

