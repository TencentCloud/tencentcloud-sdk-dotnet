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

namespace TencentCloud.Wsa.V20250508.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchProResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>原始查询语</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>搜索结果页面详情，格式为json字符串。</p><ul><li><p>title：结果标题</p></li><li><p>date：内容发布时间</p></li><li><p>url：内容发布源url</p></li><li><p>passage：标准摘要</p></li><li><p>content：动态摘要（仅尊享版、旗舰版返回该字段）</p></li><li><p>site：网站名称，部分不知名站点结果可能为空</p></li><li><p>score：相关性得分，取值0～1，越靠近1表示越相关</p></li><li><p>images：图片列表（旗舰版无该出参）</p></li><li><p>pics：图片列表，单个doc返回0～10条（仅旗舰版参数）</p><ul><li>caption：图片描述</li><li>origin_url：源图url地</li></ul></li><li><p>favicon：网站图标链接，部分不知名站点结果可能为空</p></li><li><p>deeplinks：子链信息，单个doc最多返回10条子链信息。（仅旗舰版参数，通过Deeplinks入参控制）</p><ul><li>title：子链标题</li><li>url：子链地址</li></ul></li></ul>
        /// </summary>
        [JsonProperty("Pages")]
        public string[] Pages{ get; set; }

        /// <summary>
        /// <p>用户版本：standard/premium/lite/flagship（标准/尊享/轻量/旗舰）</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>提示信息</p>
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArraySimple(map, prefix + "Pages.", this.Pages);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

