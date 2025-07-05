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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SegmentPortraitPicResponse : AbstractModel
    {
        
        /// <summary>
        /// 处理后的图片 base64 数据，透明背景图。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultImage")]
        public string ResultImage{ get; set; }

        /// <summary>
        /// 一个通过 base64 编码的文件，解码后文件由 Float 型浮点数组成。这些浮点数代表原图从左上角开始的每一行的每一个像素点，每一个浮点数的值是原图相应像素点位于人体轮廓内的置信度（0-1）转化的灰度值（0-255）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultMask")]
        public string ResultMask{ get; set; }

        /// <summary>
        /// 图片是否存在前景。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasForeground")]
        public bool? HasForeground{ get; set; }

        /// <summary>
        /// 支持将处理过的图片 base64 数据，透明背景图以Url的形式返回值，Url有效期为30分钟。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultImageUrl")]
        public string ResultImageUrl{ get; set; }

        /// <summary>
        /// 一个通过 base64 编码的文件，解码后文件由 Float 型浮点数组成。支持以Url形式的返回值；Url有效期为30分钟。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultMaskUrl")]
        public string ResultMaskUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "ResultImage", this.ResultImage);
            this.SetParamSimple(map, prefix + "ResultMask", this.ResultMask);
            this.SetParamSimple(map, prefix + "HasForeground", this.HasForeground);
            this.SetParamSimple(map, prefix + "ResultImageUrl", this.ResultImageUrl);
            this.SetParamSimple(map, prefix + "ResultMaskUrl", this.ResultMaskUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

