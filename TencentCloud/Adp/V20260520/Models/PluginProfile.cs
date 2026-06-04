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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginProfile : AbstractModel
    {
        
        /// <summary>
        /// 插件作者
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// 插件描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 插件图标url
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 插件产品分类
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 普通插件 |
        /// | 1 | 连接器类插件 |
        /// </summary>
        [JsonProperty("PluginClass")]
        public long? PluginClass{ get; set; }

        /// <summary>
        /// 插件类型
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | API接口 |
        /// | 1 | 代码 |
        /// | 2 | MCP |
        /// | 3 | 应用 |
        /// </summary>
        [JsonProperty("PluginKind")]
        public long? PluginKind{ get; set; }

        /// <summary>
        /// 插件来源
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 自定义插件 |
        /// | 1 | 官方插件 |
        /// | 2 | 第三方插件 |
        /// </summary>
        [JsonProperty("PluginSource")]
        public long? PluginSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PluginClass", this.PluginClass);
            this.SetParamSimple(map, prefix + "PluginKind", this.PluginKind);
            this.SetParamSimple(map, prefix + "PluginSource", this.PluginSource);
        }
    }
}

