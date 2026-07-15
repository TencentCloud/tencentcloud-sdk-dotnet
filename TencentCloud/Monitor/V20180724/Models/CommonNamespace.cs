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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonNamespace : AbstractModel
    {
        
        /// <summary>
        /// <p>命名空间标示</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>命名空间名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>命名空间值</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>产品名称</p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>配置信息</p>
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// <p>支持地域列表</p>
        /// </summary>
        [JsonProperty("AvailableRegions")]
        public string[] AvailableRegions{ get; set; }

        /// <summary>
        /// <p>排序Id</p>
        /// </summary>
        [JsonProperty("SortId")]
        public long? SortId{ get; set; }

        /// <summary>
        /// <p>Dashboard中的唯一表示</p>
        /// </summary>
        [JsonProperty("DashboardId")]
        public string DashboardId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamArraySimple(map, prefix + "AvailableRegions.", this.AvailableRegions);
            this.SetParamSimple(map, prefix + "SortId", this.SortId);
            this.SetParamSimple(map, prefix + "DashboardId", this.DashboardId);
        }
    }
}

