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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkipCondition : AbstractModel
    {
        
        /// <summary>
        /// 例外跳过类型，取值为：
        /// <li>header_fields：HTTP请求Header；</li>
        /// <li>cookie：HTTP请求Cookie；</li>
        /// <li>query_string：HTTP请求URL中的Query参数；</li>
        /// <li>uri：HTTP请求URI；</li>
        /// <li>body_raw：HTTP请求Body；</li>
        /// <li>body_json： JSON格式的HTTP Body。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 选择跳过的字段，取值为：
        /// <li>args：uri 下选择 query 参数: ?name1=jack&age=12；</li>
        /// <li>path：uri 下选择部分路径：/path/to/resource.jpg；</li>
        /// <li>full：uri 下选择完整路径：example.com/path/to/resource.jpg?name1=jack&age=12；</li>
        /// <li>upload_filename：分段文件名，即分段传输文件时；</li>
        /// <li>keys：所有的Key；</li>
        /// <li>values：匹配Key对应的值；</li>
        /// <li>key_value：匹配Key及匹配Value。</li>
        /// </summary>
        [JsonProperty("Selector")]
        public string Selector{ get; set; }

        /// <summary>
        /// 匹配Key所使用的匹配方式，取值为：
        /// <li>equal：精准匹配，等于；</li>
        /// <li>wildcard：通配符匹配，支持 * 通配。</li>
        /// </summary>
        [JsonProperty("MatchFromType")]
        public string MatchFromType{ get; set; }

        /// <summary>
        /// 匹配Key的值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string[] MatchFrom{ get; set; }

        /// <summary>
        /// 匹配Content所使用的匹配方式，取值为：
        /// <li>equal：精准匹配，等于；</li>
        /// <li>wildcard：通配符匹配，支持 * 通配。</li>
        /// </summary>
        [JsonProperty("MatchContentType")]
        public string MatchContentType{ get; set; }

        /// <summary>
        /// 匹配Value的值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MatchContent")]
        public string[] MatchContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Selector", this.Selector);
            this.SetParamSimple(map, prefix + "MatchFromType", this.MatchFromType);
            this.SetParamArraySimple(map, prefix + "MatchFrom.", this.MatchFrom);
            this.SetParamSimple(map, prefix + "MatchContentType", this.MatchContentType);
            this.SetParamArraySimple(map, prefix + "MatchContent.", this.MatchContent);
        }
    }
}

