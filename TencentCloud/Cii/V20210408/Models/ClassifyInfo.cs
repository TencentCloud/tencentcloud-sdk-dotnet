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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClassifyInfo : AbstractModel
    {
        
        /// <summary>
        /// 一级分类
        /// </summary>
        [JsonProperty("FirstClass")]
        public string FirstClass{ get; set; }

        /// <summary>
        /// 二级分类
        /// </summary>
        [JsonProperty("SecondClass")]
        public string SecondClass{ get; set; }

        /// <summary>
        /// 三级分类
        /// </summary>
        [JsonProperty("ThirdClass")]
        public string ThirdClass{ get; set; }

        /// <summary>
        /// 一级分类序号
        /// </summary>
        [JsonProperty("FirstClassId")]
        public ulong? FirstClassId{ get; set; }

        /// <summary>
        /// 二级分类序号
        /// </summary>
        [JsonProperty("SecondClassId")]
        public ulong? SecondClassId{ get; set; }

        /// <summary>
        /// 三级分类序号
        /// </summary>
        [JsonProperty("ThirdClassId")]
        public ulong? ThirdClassId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstClass", this.FirstClass);
            this.SetParamSimple(map, prefix + "SecondClass", this.SecondClass);
            this.SetParamSimple(map, prefix + "ThirdClass", this.ThirdClass);
            this.SetParamSimple(map, prefix + "FirstClassId", this.FirstClassId);
            this.SetParamSimple(map, prefix + "SecondClassId", this.SecondClassId);
            this.SetParamSimple(map, prefix + "ThirdClassId", this.ThirdClassId);
        }
    }
}

