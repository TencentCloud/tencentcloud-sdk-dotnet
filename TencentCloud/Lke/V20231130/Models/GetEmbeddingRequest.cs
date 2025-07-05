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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetEmbeddingRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 需要 embedding 的文本, 单条文本最大长度500个字符, 总条数最大7条
        /// </summary>
        [JsonProperty("Inputs")]
        public string[] Inputs{ get; set; }

        /// <summary>
        /// 是否在线, 后台异步任务使用离线, 实时任务使用在线, 默认值: false
        /// </summary>
        [JsonProperty("Online")]
        public bool? Online{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArraySimple(map, prefix + "Inputs.", this.Inputs);
            this.SetParamSimple(map, prefix + "Online", this.Online);
        }
    }
}

