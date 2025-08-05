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
        /// 原始查询语
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 搜索结果页面详情，格式为json字符串。
        /// title：结果标题
        /// date：内容发布时间
        /// url：内容发布源url
        /// passage：标准摘要
        /// content：动态摘要 （尊享版字段）
        /// site：网站名称，部分不知名站点结果可能为空
        /// score：相关性得分，取值0～1，越靠近1表示越相关
        /// images：图片列表
        /// favicon：网站图标链接，部分不知名站点结果可能为空
        /// </summary>
        [JsonProperty("Pages")]
        public string[] Pages{ get; set; }

        /// <summary>
        /// 提示信息
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
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

