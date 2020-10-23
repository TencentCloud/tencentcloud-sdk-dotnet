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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Hair : AbstractModel
    {
        
        /// <summary>
        /// 头发长度信息。
        /// AttributeItem对应的Type为 —— 0：光头，1：短发，2：中发，3：长发，4：绑发。
        /// </summary>
        [JsonProperty("Length")]
        public AttributeItem Length{ get; set; }

        /// <summary>
        /// 刘海信息。
        /// AttributeItem对应的Type为 —— 0：无刘海，1：有刘海。
        /// </summary>
        [JsonProperty("Bang")]
        public AttributeItem Bang{ get; set; }

        /// <summary>
        /// 头发颜色信息。
        /// AttributeItem对应的Type为 —— 0：黑色，1：金色，2：棕色，3：灰白色。
        /// </summary>
        [JsonProperty("Color")]
        public AttributeItem Color{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Length.", this.Length);
            this.SetParamObj(map, prefix + "Bang.", this.Bang);
            this.SetParamObj(map, prefix + "Color.", this.Color);
        }
    }
}

