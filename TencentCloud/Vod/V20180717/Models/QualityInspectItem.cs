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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityInspectItem : AbstractModel
    {
        
        /// <summary>
        /// 异常片段起始的偏移时间，单位：秒。
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 异常片段终止的偏移时间，单位：秒。
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 检测出异常的区域坐标。数组包含 4 个元素 [x1,y1,x2,y2]，依次表示区域左上点、右下点的横纵坐标。
        /// <font color=red>注意：</font> 仅当 Type 取值为下列之一时，本字段取值有效：
        /// <li>BlackWhiteEdge：黑白边；</li>
        /// <li>Mosaic：马赛克；</li>
        /// <li>QRCode：二维码；</li>
        /// <li>AppletCode：小程序码；</li>
        /// <li>BarCode：条形码。</li>
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// 置信度，取值范围：[0, 100]。
        /// <font color=red>注意：</font> 仅当 Type 取值为下列之一时，本字段取值有效：
        /// <li>Mosaic：马赛克；</li>
        /// <li>QRCode：二维码；</li>
        /// <li>AppletCode：小程序码；</li>
        /// <li>BarCode：条形码。</li>
        /// </summary>
        [JsonProperty("Confidence")]
        public ulong? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

