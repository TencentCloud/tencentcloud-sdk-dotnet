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

    public class ComposeMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入的媒体轨道列表，包括视频、音频、图片等素材组成的多个轨道信息。输入的多个轨道在时间轴上和输出媒体文件的时间轴对齐，时间轴上相同时间点的各个轨道的素材进行重叠，视频或者图片按轨道顺序进行图像的叠加，轨道顺序高的素材叠加在上面；音频素材进行混音。
        /// </summary>
        [JsonProperty("Tracks")]
        public MediaTrack[] Tracks{ get; set; }

        /// <summary>
        /// 输出的媒体文件信息。
        /// </summary>
        [JsonProperty("Output")]
        public ComposeMediaOutput Output{ get; set; }

        /// <summary>
        /// 制作视频文件时使用的画布。
        /// </summary>
        [JsonProperty("Canvas")]
        public Canvas Canvas{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tracks.", this.Tracks);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamObj(map, prefix + "Canvas.", this.Canvas);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

