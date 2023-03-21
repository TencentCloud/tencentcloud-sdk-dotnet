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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClassificationResult : AbstractModel
    {
        
        /// <summary>
        /// 一级分类名称
        /// </summary>
        [JsonProperty("FirstClassName")]
        public string FirstClassName{ get; set; }

        /// <summary>
        /// 二级分类名称
        /// </summary>
        [JsonProperty("SecondClassName")]
        public string SecondClassName{ get; set; }

        /// <summary>
        /// 一级分类概率
        /// </summary>
        [JsonProperty("FirstClassProbability")]
        public float? FirstClassProbability{ get; set; }

        /// <summary>
        /// 二级分类概率
        /// </summary>
        [JsonProperty("SecondClassProbability")]
        public float? SecondClassProbability{ get; set; }

        /// <summary>
        /// 三级分类名称，仅有当新闻领域五分类可能出现，详情见文本分类文档
        /// </summary>
        [JsonProperty("ThirdClassName")]
        public string ThirdClassName{ get; set; }

        /// <summary>
        /// 三级分类概率，仅有当新闻领域五分类可能出现，详情见文本分类文档
        /// </summary>
        [JsonProperty("ThirdClassProbability")]
        public float? ThirdClassProbability{ get; set; }

        /// <summary>
        /// 四级分类名称，仅有当新闻领域五分类可能出现，详情见文本分类文档
        /// </summary>
        [JsonProperty("FourthClassName")]
        public string FourthClassName{ get; set; }

        /// <summary>
        /// 四级分类概率，仅有当新闻领域五分类可能出现，详情见文本分类文档
        /// </summary>
        [JsonProperty("FourthClassProbability")]
        public float? FourthClassProbability{ get; set; }

        /// <summary>
        /// 五级分类名称，仅有当新闻领域五分类可能出现，详情见文本分类文档
        /// </summary>
        [JsonProperty("FifthClassName")]
        public string FifthClassName{ get; set; }

        /// <summary>
        /// 五级分类概率，仅有当新闻领域五分类可能出现，详情见文本分类文档
        /// </summary>
        [JsonProperty("FifthClassProbability")]
        public float? FifthClassProbability{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstClassName", this.FirstClassName);
            this.SetParamSimple(map, prefix + "SecondClassName", this.SecondClassName);
            this.SetParamSimple(map, prefix + "FirstClassProbability", this.FirstClassProbability);
            this.SetParamSimple(map, prefix + "SecondClassProbability", this.SecondClassProbability);
            this.SetParamSimple(map, prefix + "ThirdClassName", this.ThirdClassName);
            this.SetParamSimple(map, prefix + "ThirdClassProbability", this.ThirdClassProbability);
            this.SetParamSimple(map, prefix + "FourthClassName", this.FourthClassName);
            this.SetParamSimple(map, prefix + "FourthClassProbability", this.FourthClassProbability);
            this.SetParamSimple(map, prefix + "FifthClassName", this.FifthClassName);
            this.SetParamSimple(map, prefix + "FifthClassProbability", this.FifthClassProbability);
        }
    }
}

