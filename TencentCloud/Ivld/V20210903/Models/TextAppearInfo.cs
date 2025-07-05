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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextAppearInfo : AbstractModel
    {
        
        /// <summary>
        /// 文本结果数组中的下标
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }

        /// <summary>
        /// 关键词在文本中出现的起始偏移量(包含)
        /// </summary>
        [JsonProperty("StartPosition")]
        public long? StartPosition{ get; set; }

        /// <summary>
        /// 关键词在文本中出现的结束偏移量(不包含)
        /// </summary>
        [JsonProperty("EndPosition")]
        public long? EndPosition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "StartPosition", this.StartPosition);
            this.SetParamSimple(map, prefix + "EndPosition", this.EndPosition);
        }
    }
}

