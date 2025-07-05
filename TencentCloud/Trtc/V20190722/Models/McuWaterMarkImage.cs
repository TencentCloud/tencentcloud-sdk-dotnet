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

    public class McuWaterMarkImage : AbstractModel
    {
        
        /// <summary>
        /// 水印图片URL地址，支持png、jpg、jpeg格式。图片大小限制不超过5MB。
        /// 注：您需要确保图片链接的可访问性，后台单次下载超时时间为10秒，最多重试3次，若最终图片下载失败，水印图片将不会生效。
        /// </summary>
        [JsonProperty("WaterMarkUrl")]
        public string WaterMarkUrl{ get; set; }

        /// <summary>
        /// 水印在输出时的宽。单位为像素值。
        /// </summary>
        [JsonProperty("WaterMarkWidth")]
        public ulong? WaterMarkWidth{ get; set; }

        /// <summary>
        /// 水印在输出时的高。单位为像素值。
        /// </summary>
        [JsonProperty("WaterMarkHeight")]
        public ulong? WaterMarkHeight{ get; set; }

        /// <summary>
        /// 水印在输出时的X偏移。单位为像素值。
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// 水印在输出时的Y偏移。单位为像素值。
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }

        /// <summary>
        /// 水印在输出时的层级，不填默认为0。
        /// </summary>
        [JsonProperty("ZOrder")]
        public ulong? ZOrder{ get; set; }

        /// <summary>
        /// 动态水印类型，默认为0。0:关闭；1:随机位置，每秒变动一次；2:边界扫描反弹，每帧变动一次。
        /// </summary>
        [JsonProperty("DynamicPosType")]
        public ulong? DynamicPosType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterMarkUrl", this.WaterMarkUrl);
            this.SetParamSimple(map, prefix + "WaterMarkWidth", this.WaterMarkWidth);
            this.SetParamSimple(map, prefix + "WaterMarkHeight", this.WaterMarkHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "ZOrder", this.ZOrder);
            this.SetParamSimple(map, prefix + "DynamicPosType", this.DynamicPosType);
        }
    }
}

