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

    public class Eye : AbstractModel
    {
        
        /// <summary>
        /// 识别是否佩戴眼镜。
        /// AttributeItem对应的Type为 —— 0：无眼镜，1：普通眼镜，2：墨镜
        /// </summary>
        [JsonProperty("Glass")]
        public AttributeItem Glass{ get; set; }

        /// <summary>
        /// 识别眼睛的睁开、闭合状态。
        /// AttributeItem对应的Type为 —— 0：睁开，1：闭眼
        /// </summary>
        [JsonProperty("EyeOpen")]
        public AttributeItem EyeOpen{ get; set; }

        /// <summary>
        /// 识别是否双眼皮。
        /// AttributeItem对应的Type为 —— 0：无，1：有。
        /// </summary>
        [JsonProperty("EyelidType")]
        public AttributeItem EyelidType{ get; set; }

        /// <summary>
        /// 眼睛大小。
        /// AttributeItem对应的Type为 —— 0：小眼睛，1：普通眼睛，2：大眼睛。
        /// </summary>
        [JsonProperty("EyeSize")]
        public AttributeItem EyeSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Glass.", this.Glass);
            this.SetParamObj(map, prefix + "EyeOpen.", this.EyeOpen);
            this.SetParamObj(map, prefix + "EyelidType.", this.EyelidType);
            this.SetParamObj(map, prefix + "EyeSize.", this.EyeSize);
        }
    }
}

