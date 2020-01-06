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

    public class ImageTransform : AbstractModel
    {
        
        /// <summary>
        /// 类型，取值有：
        /// <li> Rotate：图像旋转。</li>
        /// <li> Flip：图像翻转。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 图像以中心点为原点进行旋转的角度，取值范围0~360。当 Type = Rotate 时有效。
        /// </summary>
        [JsonProperty("RotateAngle")]
        public float? RotateAngle{ get; set; }

        /// <summary>
        /// 图像翻转动作，取值有：
        /// <li>Horizental：水平翻转，即左右镜像。</li>
        /// <li>Vertical：垂直翻转，即上下镜像。</li>
        /// 当 Type = Flip 时有效。
        /// </summary>
        [JsonProperty("Flip")]
        public string Flip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RotateAngle", this.RotateAngle);
            this.SetParamSimple(map, prefix + "Flip", this.Flip);
        }
    }
}

