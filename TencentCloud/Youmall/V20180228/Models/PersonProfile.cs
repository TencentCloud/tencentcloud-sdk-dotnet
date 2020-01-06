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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PersonProfile : AbstractModel
    {
        
        /// <summary>
        /// 客人编码
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Gender")]
        public ulong? Gender{ get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty("Age")]
        public ulong? Age{ get; set; }

        /// <summary>
        /// 首次到场时间
        /// </summary>
        [JsonProperty("FirstArrivedTime")]
        public string FirstArrivedTime{ get; set; }

        /// <summary>
        /// 来访次数
        /// </summary>
        [JsonProperty("ArrivedCount")]
        public ulong? ArrivedCount{ get; set; }

        /// <summary>
        /// 客户图片
        /// </summary>
        [JsonProperty("PicUrl")]
        public string PicUrl{ get; set; }

        /// <summary>
        /// 置信度
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "FirstArrivedTime", this.FirstArrivedTime);
            this.SetParamSimple(map, prefix + "ArrivedCount", this.ArrivedCount);
            this.SetParamSimple(map, prefix + "PicUrl", this.PicUrl);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
        }
    }
}

