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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDashboardRequest : AbstractModel
    {
        
        /// <summary>
        /// 仪表盘名称
        /// </summary>
        [JsonProperty("DashboardName")]
        public string DashboardName{ get; set; }

        /// <summary>
        /// 仪表盘配置数据
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 标签描述列表，通过指定该参数可以同时绑定标签到相应的日志主题。最大支持10个标签键值对，同一个资源只能绑定到同一个标签键下。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DashboardName", this.DashboardName);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

