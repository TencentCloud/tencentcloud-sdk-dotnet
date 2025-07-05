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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueInfo : AbstractModel
    {
        
        /// <summary>
        /// 字段的分词符
        /// </summary>
        [JsonProperty("Tokenizer")]
        public string Tokenizer{ get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 字段是否开启分析功能
        /// </summary>
        [JsonProperty("SqlFlag")]
        public bool? SqlFlag{ get; set; }

        /// <summary>
        /// 是否包含中文
        /// </summary>
        [JsonProperty("ContainZH")]
        public bool? ContainZH{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tokenizer", this.Tokenizer);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SqlFlag", this.SqlFlag);
            this.SetParamSimple(map, prefix + "ContainZH", this.ContainZH);
        }
    }
}

