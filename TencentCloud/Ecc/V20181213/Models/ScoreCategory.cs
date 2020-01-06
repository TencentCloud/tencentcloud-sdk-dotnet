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

    public class ScoreCategory : AbstractModel
    {
        
        /// <summary>
        /// 词汇维度
        /// </summary>
        [JsonProperty("Words")]
        public Aspect Words{ get; set; }

        /// <summary>
        /// 句子维度
        /// </summary>
        [JsonProperty("Sentences")]
        public Aspect Sentences{ get; set; }

        /// <summary>
        /// 篇章结构维度
        /// </summary>
        [JsonProperty("Structure")]
        public Aspect Structure{ get; set; }

        /// <summary>
        /// 内容维度
        /// </summary>
        [JsonProperty("Content")]
        public Aspect Content{ get; set; }

        /// <summary>
        /// 维度得分
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// 维度分数占比
        /// </summary>
        [JsonProperty("Percentage")]
        public float? Percentage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Words.", this.Words);
            this.SetParamObj(map, prefix + "Sentences.", this.Sentences);
            this.SetParamObj(map, prefix + "Structure.", this.Structure);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
        }
    }
}

