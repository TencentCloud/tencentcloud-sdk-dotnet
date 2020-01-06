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

    public class FaceInfoResult : AbstractModel
    {
        
        /// <summary>
        /// 人脸尺寸的占比
        /// </summary>
        [JsonProperty("FaceRatio")]
        public float? FaceRatio{ get; set; }

        /// <summary>
        /// 帧高度
        /// </summary>
        [JsonProperty("FrameHeight")]
        public long? FrameHeight{ get; set; }

        /// <summary>
        /// 帧宽度
        /// </summary>
        [JsonProperty("FrameWidth")]
        public long? FrameWidth{ get; set; }

        /// <summary>
        /// 人脸高度
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 人脸左坐标
        /// </summary>
        [JsonProperty("Left")]
        public long? Left{ get; set; }

        /// <summary>
        /// 人脸顶坐标
        /// </summary>
        [JsonProperty("Top")]
        public long? Top{ get; set; }

        /// <summary>
        /// 人脸宽度
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceRatio", this.FaceRatio);
            this.SetParamSimple(map, prefix + "FrameHeight", this.FrameHeight);
            this.SetParamSimple(map, prefix + "FrameWidth", this.FrameWidth);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Left", this.Left);
            this.SetParamSimple(map, prefix + "Top", this.Top);
            this.SetParamSimple(map, prefix + "Width", this.Width);
        }
    }
}

