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

    public class ModifyLogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>日志主题id</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>检索时间范围-开始时间</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// <p>检索时间范围-结束时间</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// <p>日志检索条件，仅支持 CQL 语法，不支持 Lucene 语法</p><p>对符合检索条件的日志进行修改</p>
        /// </summary>
        [JsonProperty("QueryString")]
        public string QueryString{ get; set; }

        /// <summary>
        /// <p>修改模式</p><p>枚举值：</p><ul><li>PARTIAL： 只修改指定的日志字段</li><li>REPLACE： 整体替换原有日志（不包含预置字段及元数据字段）</li></ul>
        /// </summary>
        [JsonProperty("ModifyMode")]
        public string ModifyMode{ get; set; }

        /// <summary>
        /// <p>修改内容</p><p>不支持修改预置字段(__FILENAME__、__SOURCE__等，但不包括__CONTENT__)及元数据字段(__TAG__开头的字段)</p>
        /// </summary>
        [JsonProperty("ModifyContent")]
        public string ModifyContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "QueryString", this.QueryString);
            this.SetParamSimple(map, prefix + "ModifyMode", this.ModifyMode);
            this.SetParamSimple(map, prefix + "ModifyContent", this.ModifyContent);
        }
    }
}

