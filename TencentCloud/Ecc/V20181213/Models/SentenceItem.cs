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

namespace TencentCloud.Ecc.V20181213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SentenceItem : AbstractModel
    {
        
        /// <summary>
        /// 英语句子
        /// </summary>
        [JsonProperty("Sentence")]
        public string Sentence{ get; set; }

        /// <summary>
        /// 段落id
        /// </summary>
        [JsonProperty("ParaID")]
        public long? ParaID{ get; set; }

        /// <summary>
        /// 句子id
        /// </summary>
        [JsonProperty("SentenceID")]
        public long? SentenceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sentence", this.Sentence);
            this.SetParamSimple(map, prefix + "ParaID", this.ParaID);
            this.SetParamSimple(map, prefix + "SentenceID", this.SentenceID);
        }
    }
}

