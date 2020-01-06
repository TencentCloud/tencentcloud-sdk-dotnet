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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FacePoseResult : AbstractModel
    {
        
        /// <summary>
        /// 正脸或侧脸的消息
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 围绕Z轴旋转角度，俯仰角
        /// </summary>
        [JsonProperty("Pitch")]
        public float? Pitch{ get; set; }

        /// <summary>
        /// 围绕X轴旋转角度，翻滚角
        /// </summary>
        [JsonProperty("Roll")]
        public float? Roll{ get; set; }

        /// <summary>
        /// 围绕Y轴旋转角度，偏航角
        /// </summary>
        [JsonProperty("Yaw")]
        public float? Yaw{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Pitch", this.Pitch);
            this.SetParamSimple(map, prefix + "Roll", this.Roll);
            this.SetParamSimple(map, prefix + "Yaw", this.Yaw);
        }
    }
}

