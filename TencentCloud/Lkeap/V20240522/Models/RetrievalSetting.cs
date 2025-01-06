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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RetrievalSetting : AbstractModel
    {
        
        /// <summary>
        /// 检索的类型，不填该参数则检索全部。
        /// - `DOC`：文档
        /// - `QA`：QA
        /// 
        /// 仅RetrieveKnowledge接口支持该参数
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 返回个数
        /// </summary>
        [JsonProperty("TopK")]
        public long? TopK{ get; set; }

        /// <summary>
        /// 分数过滤
        /// </summary>
        [JsonProperty("ScoreThreshold")]
        public float? ScoreThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TopK", this.TopK);
            this.SetParamSimple(map, prefix + "ScoreThreshold", this.ScoreThreshold);
        }
    }
}

