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

namespace TencentCloud.Vrs.V20200824.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetTrainingTextRequest : AbstractModel
    {
        
        /// <summary>
        /// 复刻类型。
        /// 5 - 一句话声音复刻。
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 音色场景。（仅支持一句话声音复刻，其余复刻类型不生效） 
        /// 0 - 通用场景（默认）； 
        /// 1 - 聊天场景； 
        /// 2 - 阅读场景； 
        /// 3 - 资讯播报场景。
        /// </summary>
        [JsonProperty("Domain")]
        public long? Domain{ get; set; }

        /// <summary>
        /// 文本语种。（仅支持一句话声音复刻，其余复刻类型不生效） 
        /// 1 - 中文（默认）。
        /// </summary>
        [JsonProperty("TextLanguage")]
        public long? TextLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "TextLanguage", this.TextLanguage);
        }
    }
}

