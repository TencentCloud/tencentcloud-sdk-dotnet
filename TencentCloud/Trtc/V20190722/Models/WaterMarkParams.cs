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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterMarkParams : AbstractModel
    {
        
        /// <summary>
        /// 混流-水印图片ID。取值为实时音视频控制台上传的图片ID。
        /// </summary>
        [JsonProperty("WaterMarkId")]
        public ulong? WaterMarkId{ get; set; }

        /// <summary>
        /// 混流-水印宽。单位为像素值。水印宽+X偏移不能超过整个画布宽。
        /// </summary>
        [JsonProperty("WaterMarkWidth")]
        public ulong? WaterMarkWidth{ get; set; }

        /// <summary>
        /// 混流-水印高。单位为像素值。水印高+Y偏移不能超过整个画布高。
        /// </summary>
        [JsonProperty("WaterMarkHeight")]
        public ulong? WaterMarkHeight{ get; set; }

        /// <summary>
        /// 水印在输出时的X偏移。单位为像素值。水印宽+X偏移不能超过整个画布宽。
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// 水印在输出时的Y偏移。单位为像素值。水印高+Y偏移不能超过整个画布高。
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }

        /// <summary>
        /// 混流-水印图片URL地址，支持png、jpg、jpeg、bmp格式，暂不支持透明通道。URL链接长度限制为512字节。WaterMarkUrl和WaterMarkId参数都填时，以WaterMarkUrl为准。图片大小限制不超过2MB。
        /// </summary>
        [JsonProperty("WaterMarkUrl")]
        public string WaterMarkUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterMarkId", this.WaterMarkId);
            this.SetParamSimple(map, prefix + "WaterMarkWidth", this.WaterMarkWidth);
            this.SetParamSimple(map, prefix + "WaterMarkHeight", this.WaterMarkHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "WaterMarkUrl", this.WaterMarkUrl);
        }
    }
}

