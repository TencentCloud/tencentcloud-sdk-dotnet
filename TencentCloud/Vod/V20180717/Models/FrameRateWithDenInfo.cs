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

    public class FrameRateWithDenInfo : AbstractModel
    {
        
        /// <summary>
        /// 插帧帧率配置控制开关，可选值：
        /// <li>ON：开启；</li>
        /// <li>OFF：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 帧率分子，取值范围：非负数，除以分母后小于100，单位：Hz。 默认值 0。 注意：对于转码，该参数会覆盖 VideoTemplate 内部的 Fps。
        /// </summary>
        [JsonProperty("FpsNum")]
        public long? FpsNum{ get; set; }

        /// <summary>
        /// 帧率分母，取值范围：大于等于1。 默认值 1。
        /// </summary>
        [JsonProperty("FpsDen")]
        public long? FpsDen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "FpsNum", this.FpsNum);
            this.SetParamSimple(map, prefix + "FpsDen", this.FpsDen);
        }
    }
}

