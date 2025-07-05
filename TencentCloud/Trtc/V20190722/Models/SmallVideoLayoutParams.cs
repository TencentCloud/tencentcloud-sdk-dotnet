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

    public class SmallVideoLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// 代表小画面对应的用户ID。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 代表小画面对应的流类型，0为摄像头，1为屏幕分享。小画面为web用户时此值填0。
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// 小画面在输出时的宽度，单位为像素值，不填默认为0。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public ulong? ImageWidth{ get; set; }

        /// <summary>
        /// 小画面在输出时的高度，单位为像素值，不填默认为0。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public ulong? ImageHeight{ get; set; }

        /// <summary>
        /// 小画面在输出时的X偏移，单位为像素值，LocationX与ImageWidth之和不能超过混流输出的总宽度，不填默认为0。
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// 小画面在输出时的Y偏移，单位为像素值，LocationY与ImageHeight之和不能超过混流输出的总高度，不填默认为0。
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
        }
    }
}

