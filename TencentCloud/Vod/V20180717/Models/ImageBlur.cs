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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageBlur : AbstractModel
    {
        
        /// <summary>
        /// 图片模糊的操作类型。可选模式有：
        /// <li>Gaussian : 高斯模糊。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 模糊半径，取值范围为1 - 50。当 Type 取值为 Gaussian 时此字段有效。
        /// </summary>
        [JsonProperty("Radius")]
        public long? Radius{ get; set; }

        /// <summary>
        /// 正态分布的标准差，必须大于0。当 Type 取值为 Gaussian 时此字段有效。
        /// </summary>
        [JsonProperty("Sigma")]
        public long? Sigma{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Radius", this.Radius);
            this.SetParamSimple(map, prefix + "Sigma", this.Sigma);
        }
    }
}

