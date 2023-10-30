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

    public class DescribeInstancePluginInfo : AbstractModel
    {
        
        /// <summary>
        /// 插件名
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// 插件版本
        /// </summary>
        [JsonProperty("PluginVersion")]
        public string PluginVersion{ get; set; }

        /// <summary>
        /// 插件描述
        /// </summary>
        [JsonProperty("PluginDesc")]
        public string PluginDesc{ get; set; }

        /// <summary>
        /// 插件状态：-2 已卸载 -1 卸载中 0 安装中 1 已安装
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 插件是否可卸载
        /// </summary>
        [JsonProperty("Removable")]
        public bool? Removable{ get; set; }

        /// <summary>
        /// 0：系统插件
        /// </summary>
        [JsonProperty("PluginType")]
        public long? PluginType{ get; set; }

        /// <summary>
        /// 插件变更时间
        /// </summary>
        [JsonProperty("PluginUpdateTime")]
        public string PluginUpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "PluginVersion", this.PluginVersion);
            this.SetParamSimple(map, prefix + "PluginDesc", this.PluginDesc);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Removable", this.Removable);
            this.SetParamSimple(map, prefix + "PluginType", this.PluginType);
            this.SetParamSimple(map, prefix + "PluginUpdateTime", this.PluginUpdateTime);
        }
    }
}

