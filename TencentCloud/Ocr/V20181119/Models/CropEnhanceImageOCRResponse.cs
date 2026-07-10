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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CropEnhanceImageOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>处理后图的宽</p>
        /// </summary>
        [JsonProperty("CroppedWidth")]
        public long? CroppedWidth{ get; set; }

        /// <summary>
        /// <p>处理后图的高</p>
        /// </summary>
        [JsonProperty("CroppedHeight")]
        public long? CroppedHeight{ get; set; }

        /// <summary>
        /// <p>图像处理后的jpg图片，base64格式</p>
        /// </summary>
        [JsonProperty("CroppedImage")]
        public string CroppedImage{ get; set; }

        /// <summary>
        /// <p>切图区域的4个角点坐标, 是个长度为8的数组<br>[0,1,2,3,4,5,6,7]</p><p>(0,1) 左上角坐标<br>(2,3) 右上角坐标<br>(4,5) 右下角坐标<br>(6,7) 左下角坐标</p>
        /// </summary>
        [JsonProperty("Position")]
        public long?[] Position{ get; set; }

        /// <summary>
        /// <p>图像角度，AdjustOrientation =1时生效, 返回值如下  -1: 失败  0、90、180、270</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Angle")]
        public long? Angle{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CroppedWidth", this.CroppedWidth);
            this.SetParamSimple(map, prefix + "CroppedHeight", this.CroppedHeight);
            this.SetParamSimple(map, prefix + "CroppedImage", this.CroppedImage);
            this.SetParamArraySimple(map, prefix + "Position.", this.Position);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

