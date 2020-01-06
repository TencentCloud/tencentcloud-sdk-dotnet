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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CropImageResponse : AbstractModel
    {
        
        /// <summary>
        /// 裁剪区域左上角X坐标值
        /// </summary>
        [JsonProperty("X")]
        public long? X{ get; set; }

        /// <summary>
        /// 裁剪区域左上角Y坐标值
        /// </summary>
        [JsonProperty("Y")]
        public long? Y{ get; set; }

        /// <summary>
        /// 裁剪区域的宽度，单位为像素
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 裁剪区域的高度，单位为像素
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 原图宽度，单位为像素
        /// </summary>
        [JsonProperty("OriginalWidth")]
        public long? OriginalWidth{ get; set; }

        /// <summary>
        /// 原图高度，单位为像素
        /// </summary>
        [JsonProperty("OriginalHeight")]
        public long? OriginalHeight{ get; set; }

        /// <summary>
        /// 0：抠图正常；
        /// 1：原图过长，指原图的高度是宽度的1.8倍以上；
        /// 2：原图过宽，指原图的宽度是高度的1.8倍以上；
        /// 3：抠图区域过长，指抠图的高度是主体备选框高度的1.6倍以上；
        /// 4：抠图区域过宽，指当没有检测到人脸时，抠图区域宽度是检测出的原图主体区域宽度的1.6倍以上；
        /// 5：纯色图，指裁剪区域视觉较为单一、缺乏主体部分 ；
        /// 6：宽高比异常，指Width : Height取值超出[1, 2.5]的范围；
        /// 
        /// 以上是辅助决策的参考建议，可以根据业务需求选择采纳或忽视。
        /// </summary>
        [JsonProperty("CropResult")]
        public long? CropResult{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "OriginalWidth", this.OriginalWidth);
            this.SetParamSimple(map, prefix + "OriginalHeight", this.OriginalHeight);
            this.SetParamSimple(map, prefix + "CropResult", this.CropResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

