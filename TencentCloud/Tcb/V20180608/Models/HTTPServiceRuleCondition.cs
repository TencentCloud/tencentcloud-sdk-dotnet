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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPServiceRuleCondition : AbstractModel
    {
        
        /// <summary>
        /// <p>Target 匹配对象</p><p>枚举值：</p><ul><li>url_path： 请求 URI 路径（不含查询串），例：/static/logo.jpg</li><li>file_extension： 请求文件扩展名（EO 从 path 中解析），例：jpg</li><li>full_uri： 完整 URI（路径 + 查询串），例：/download?type=hd</li></ul>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// <p>MatchType 字符串匹配类型</p><p>枚举值：</p><ul><li>prefix：  前缀匹配</li><li>suffix： 后缀匹配</li><li>contains： 包含匹配</li><li>exact： 精确匹配</li></ul>
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// <p>Values 匹配值集合，Values 内任一命中即认为条件成立（OR 语义）</p><p>入参限制：单项 1~1024 字节，最多 100 条</p>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

