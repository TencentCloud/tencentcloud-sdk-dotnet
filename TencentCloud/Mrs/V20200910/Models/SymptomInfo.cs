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

    public class SymptomInfo : AbstractModel
    {
        
        /// <summary>
        /// 等级
        /// </summary>
        [JsonProperty("Grade")]
        public BlockInfo Grade{ get; set; }

        /// <summary>
        /// 部位
        /// </summary>
        [JsonProperty("Part")]
        public Part Part{ get; set; }

        /// <summary>
        /// 原文位置
        /// </summary>
        [JsonProperty("Index")]
        public long?[] Index{ get; set; }

        /// <summary>
        /// 病变
        /// </summary>
        [JsonProperty("Symptom")]
        public BlockInfo Symptom{ get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [JsonProperty("Attrs")]
        public BlockInfo[] Attrs{ get; set; }

        /// <summary>
        /// 原文
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 坐标
        /// </summary>
        [JsonProperty("Coords")]
        public Coord[] Coords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Grade.", this.Grade);
            this.SetParamObj(map, prefix + "Part.", this.Part);
            this.SetParamArraySimple(map, prefix + "Index.", this.Index);
            this.SetParamObj(map, prefix + "Symptom.", this.Symptom);
            this.SetParamArrayObj(map, prefix + "Attrs.", this.Attrs);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamArrayObj(map, prefix + "Coords.", this.Coords);
        }
    }
}

