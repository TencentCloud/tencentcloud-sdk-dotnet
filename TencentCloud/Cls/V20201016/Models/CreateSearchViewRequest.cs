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

    public class CreateSearchViewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>日志集id</p><p>标记视图所属该日志集，用于查询日志集下的查询视图配置</p>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>日志集所属地域</p><p>参数格式：ap-guangzhou</p>
        /// </summary>
        [JsonProperty("LogsetRegion")]
        public string LogsetRegion{ get; set; }

        /// <summary>
        /// <p>视图名称</p><p>入参限制：最大支持255字符，不能包含&quot;|&quot;字符。</p>
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// <p>视图类型</p><p>枚举值：</p><ul><li>log： 日志主题</li><li>metric： 指标主题</li></ul><p>Topics字段中配置的主题信息应该与ViewType类型匹配</p>
        /// </summary>
        [JsonProperty("ViewType")]
        public string ViewType{ get; set; }

        /// <summary>
        /// <p>视图主题配置信息</p><p>Topics字段中配置的主题信息应该与ViewType类型匹配</p>
        /// </summary>
        [JsonProperty("Topics")]
        public ViewSearchTopic[] Topics{ get; set; }

        /// <summary>
        /// <p>配置描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>自定义视图id前缀</p><p>参数格式：<code>^[a-z0-9][a-z0-9_-]{1,61}[a-z0-9]$</code></p><p>配置成功之后ViewId格式: ${ViewIdPrefix}-view</p>
        /// </summary>
        [JsonProperty("ViewIdPrefix")]
        public string ViewIdPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "LogsetRegion", this.LogsetRegion);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
            this.SetParamArrayObj(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ViewIdPrefix", this.ViewIdPrefix);
        }
    }
}

