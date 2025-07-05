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

namespace TencentCloud.Cii.V20201210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResultObject : AbstractModel
    {
        
        /// <summary>
        /// 图片质量分
        /// </summary>
        [JsonProperty("Quality")]
        public float? Quality{ get; set; }

        /// <summary>
        /// 由结构化算法结构化json转换的字符串，具体协议参见算法结构化结果协议
        /// </summary>
        [JsonProperty("StructureResult")]
        public string StructureResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quality", this.Quality);
            this.SetParamSimple(map, prefix + "StructureResult", this.StructureResult);
        }
    }
}

