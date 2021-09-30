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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachinePredict : AbstractModel
    {
        
        /// <summary>
        /// 核保引擎名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 核保结论
        /// </summary>
        [JsonProperty("Conclusion")]
        public string Conclusion{ get; set; }

        /// <summary>
        /// AI决策树解释
        /// </summary>
        [JsonProperty("Explanation")]
        public UnderwriteItem[] Explanation{ get; set; }

        /// <summary>
        /// 疾病指标
        /// </summary>
        [JsonProperty("Disease")]
        public UnderwriteItem[] Disease{ get; set; }

        /// <summary>
        /// 检查异常
        /// </summary>
        [JsonProperty("Laboratory")]
        public UnderwriteItem[] Laboratory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Conclusion", this.Conclusion);
            this.SetParamArrayObj(map, prefix + "Explanation.", this.Explanation);
            this.SetParamArrayObj(map, prefix + "Disease.", this.Disease);
            this.SetParamArrayObj(map, prefix + "Laboratory.", this.Laboratory);
        }
    }
}

