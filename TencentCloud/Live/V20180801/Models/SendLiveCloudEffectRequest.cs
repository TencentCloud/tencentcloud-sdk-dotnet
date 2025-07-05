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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendLiveCloudEffectRequest : AbstractModel
    {
        
        /// <summary>
        /// 推流路径，与推流和播放地址中的AppName保持一致，默认为 live。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 您的推流域名。
        /// </summary>
        [JsonProperty("PushDomainName")]
        public string PushDomainName{ get; set; }

        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 云端特效 ID。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 默认随系统配置，云端特效循环 少于5次。可自定义指定礼物循环次数，不超过100次。
        /// </summary>
        [JsonProperty("LoopTimes")]
        public long? LoopTimes{ get; set; }

        /// <summary>
        /// 操作人备注信息。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 缩小比例，默认0 不缩放。
        /// 可选值：0-9， 值越大，越缩小。
        /// </summary>
        [JsonProperty("ZoomFactor")]
        public long? ZoomFactor{ get; set; }

        /// <summary>
        /// 指定云端特效渲染位置百分比。默认居中显示。
        /// 原点为画面左上角，该参数指定特效渲染离原点的横向比例，可选值 0 - 100。
        /// </summary>
        [JsonProperty("XPosition")]
        public string XPosition{ get; set; }

        /// <summary>
        /// 指定云端特效渲染位置百分比。默认居中显示。
        /// 原点为画面左上角，该参数指定特效渲染离原点的纵向比例，可选值 0 - 100。
        /// </summary>
        [JsonProperty("YPosition")]
        public string YPosition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "PushDomainName", this.PushDomainName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "LoopTimes", this.LoopTimes);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "ZoomFactor", this.ZoomFactor);
            this.SetParamSimple(map, prefix + "XPosition", this.XPosition);
            this.SetParamSimple(map, prefix + "YPosition", this.YPosition);
        }
    }
}

