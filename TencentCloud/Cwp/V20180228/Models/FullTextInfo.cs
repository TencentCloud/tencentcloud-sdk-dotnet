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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FullTextInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否大小写敏感
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public bool? CaseSensitive{ get; set; }

        /// <summary>
        /// 分词符
        /// </summary>
        [JsonProperty("Tokenizer")]
        public string Tokenizer{ get; set; }

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
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
            this.SetParamSimple(map, prefix + "Tokenizer", this.Tokenizer);
            this.SetParamSimple(map, prefix + "ContainZH", this.ContainZH);
        }
    }
}

