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

    public class CoverBySnapshotTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 指定时间点截图模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 截图方式。包含：
        /// <li>Time：依照时间点截图</li>
        /// <li>Percent：依照百分比截图</li>
        /// </summary>
        [JsonProperty("PositionType")]
        public string PositionType{ get; set; }

        /// <summary>
        /// 截图位置：
        /// <li>对于依照时间点截图，该值表示指定视频第几秒的截图作为封面</li>
        /// <li>对于依照百分比截图，该值表示使用视频百分之多少的截图作为封面</li>
        /// </summary>
        [JsonProperty("PositionValue")]
        public float? PositionValue{ get; set; }

        /// <summary>
        /// 水印列表，支持多张图片或文字水印，最大可支持 10 张。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "PositionType", this.PositionType);
            this.SetParamSimple(map, prefix + "PositionValue", this.PositionValue);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
        }
    }
}

