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
        /// 一级分类概率
        /// </summary>
        [JsonProperty("FirstClassProbability")]
        public float? FirstClassProbability{ get; set; }

        /// <summary>
        /// 二级分类名称
        /// </summary>
        [JsonProperty("SecondClassName")]
        public string SecondClassName{ get; set; }

        /// <summary>
        /// 二级分类概率
        /// </summary>
        [JsonProperty("SecondClassProbability")]
        public float? SecondClassProbability{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstClassName", this.FirstClassName);
            this.SetParamSimple(map, prefix + "FirstClassProbability", this.FirstClassProbability);
            this.SetParamSimple(map, prefix + "SecondClassName", this.SecondClassName);
            this.SetParamSimple(map, prefix + "SecondClassProbability", this.SecondClassProbability);
        }
    }
}

