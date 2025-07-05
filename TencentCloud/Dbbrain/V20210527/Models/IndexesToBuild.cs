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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndexesToBuild : AbstractModel
    {
        
        /// <summary>
        /// 索引id，唯一标识一个索引。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 创建索引命令。
        /// </summary>
        [JsonProperty("IndexCommand")]
        public string IndexCommand{ get; set; }

        /// <summary>
        /// 索引字符串。
        /// </summary>
        [JsonProperty("IndexStr")]
        public string IndexStr{ get; set; }

        /// <summary>
        /// 优化级别，1-4，优先级从高到低。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 索引得分。
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 签名。
        /// </summary>
        [JsonProperty("Signs")]
        public string[] Signs{ get; set; }

        /// <summary>
        /// 0-待创建；1-创建中。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IndexCommand", this.IndexCommand);
            this.SetParamSimple(map, prefix + "IndexStr", this.IndexStr);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "Signs.", this.Signs);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

