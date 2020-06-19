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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpperBodyCloth : AbstractModel
    {
        
        /// <summary>
        /// 上衣纹理信息。
        /// </summary>
        [JsonProperty("Texture")]
        public UpperBodyClothTexture Texture{ get; set; }

        /// <summary>
        /// 上衣颜色信息。
        /// </summary>
        [JsonProperty("Color")]
        public UpperBodyClothColor Color{ get; set; }

        /// <summary>
        /// 上衣衣袖信息。
        /// </summary>
        [JsonProperty("Sleeve")]
        public UpperBodyClothSleeve Sleeve{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Texture.", this.Texture);
            this.SetParamObj(map, prefix + "Color.", this.Color);
            this.SetParamObj(map, prefix + "Sleeve.", this.Sleeve);
        }
    }
}

