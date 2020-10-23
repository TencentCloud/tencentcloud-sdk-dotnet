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

    public class LowerBodyCloth : AbstractModel
    {
        
        /// <summary>
        /// 下衣颜色信息。
        /// </summary>
        [JsonProperty("Color")]
        public LowerBodyClothColor Color{ get; set; }

        /// <summary>
        /// 下衣长度信息 。
        /// </summary>
        [JsonProperty("Length")]
        public LowerBodyClothLength Length{ get; set; }

        /// <summary>
        /// 下衣类型信息。
        /// </summary>
        [JsonProperty("Type")]
        public LowerBodyClothType Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Color.", this.Color);
            this.SetParamObj(map, prefix + "Length.", this.Length);
            this.SetParamObj(map, prefix + "Type.", this.Type);
        }
    }
}

