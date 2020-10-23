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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Eyebrow : AbstractModel
    {
        
        /// <summary>
        /// 眉毛浓密。
        /// AttributeItem对应的Type为 —— 0：淡眉，1：浓眉。
        /// </summary>
        [JsonProperty("EyebrowDensity")]
        public AttributeItem EyebrowDensity{ get; set; }

        /// <summary>
        /// 眉毛弯曲。
        /// AttributeItem对应的Type为 —— 0：不弯，1：弯眉。
        /// </summary>
        [JsonProperty("EyebrowCurve")]
        public AttributeItem EyebrowCurve{ get; set; }

        /// <summary>
        /// 眉毛长短。
        /// AttributeItem对应的Type为 —— 0：短眉毛，1：长眉毛。
        /// </summary>
        [JsonProperty("EyebrowLength")]
        public AttributeItem EyebrowLength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EyebrowDensity.", this.EyebrowDensity);
            this.SetParamObj(map, prefix + "EyebrowCurve.", this.EyebrowCurve);
            this.SetParamObj(map, prefix + "EyebrowLength.", this.EyebrowLength);
        }
    }
}

