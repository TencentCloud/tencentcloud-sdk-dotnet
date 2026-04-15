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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CameraControlConfig : AbstractModel
    {
        
        /// <summary>
        /// 水平运镜，控制摄像机在水平方向上的移动量（沿x轴平移）
        /// 
        /// 取值范围：[-10, 10]，负值表示向左平移，正值表示向右平移
        /// </summary>
        [JsonProperty("Horizontal")]
        public float? Horizontal{ get; set; }

        /// <summary>
        /// 垂直运镜，控制摄像机在垂直方向上的移动量（沿y轴平移）
        /// 
        /// 取值范围：[-10, 10]，负值表示向下平移，正值表示向上平移
        /// </summary>
        [JsonProperty("Vertical")]
        public float? Vertical{ get; set; }

        /// <summary>
        /// 水平摇镜，控制摄像机在水平面上的旋转量（绕y轴旋转）
        /// 
        /// 取值范围：[-10, 10]，负值表示绕y轴向左旋转，正值表示绕y轴向右旋转
        /// </summary>
        [JsonProperty("Pan")]
        public float? Pan{ get; set; }

        /// <summary>
        /// 垂直摇镜，控制摄像机在垂直面上的旋转量（沿x轴旋转）
        /// 
        /// 取值范围：[-10, 10]，负值表示绕x轴向下旋转，正值表示绕x轴向上旋转
        /// </summary>
        [JsonProperty("Tilt")]
        public float? Tilt{ get; set; }

        /// <summary>
        /// 旋转运镜，控制摄像机的滚动量（绕z轴旋转）
        /// 
        /// 取值范围：[-10, 10]，负值表示绕z轴逆时针旋转，正值表示绕z轴顺时针旋转
        /// </summary>
        [JsonProperty("Roll")]
        public float? Roll{ get; set; }

        /// <summary>
        /// 变焦，控制摄像机的焦距变化，影响视野的远近
        /// 
        /// 取值范围：[-10, 10]，负值表示焦距变长、视野范围变小，正值表示焦距变短、视野范围变大
        /// </summary>
        [JsonProperty("Zoom")]
        public float? Zoom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Horizontal", this.Horizontal);
            this.SetParamSimple(map, prefix + "Vertical", this.Vertical);
            this.SetParamSimple(map, prefix + "Pan", this.Pan);
            this.SetParamSimple(map, prefix + "Tilt", this.Tilt);
            this.SetParamSimple(map, prefix + "Roll", this.Roll);
            this.SetParamSimple(map, prefix + "Zoom", this.Zoom);
        }
    }
}

