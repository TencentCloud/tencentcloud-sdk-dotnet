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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Invas : AbstractModel
    {
        
        /// <summary>
        /// 原文位置
        /// </summary>
        [JsonProperty("Index")]
        public long?[] Index{ get; set; }

        /// <summary>
        /// 部位
        /// </summary>
        [JsonProperty("Part")]
        public Part Part{ get; set; }

        /// <summary>
        /// 阳性
        /// </summary>
        [JsonProperty("Positive")]
        public string Positive{ get; set; }

        /// <summary>
        /// 原文
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Index.", this.Index);
            this.SetParamObj(map, prefix + "Part.", this.Part);
            this.SetParamSimple(map, prefix + "Positive", this.Positive);
            this.SetParamSimple(map, prefix + "Src", this.Src);
        }
    }
}

