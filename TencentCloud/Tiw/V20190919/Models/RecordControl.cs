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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordControl : AbstractModel
    {
        
        /// <summary>
        /// 设置是否开启录制控制参数，只有设置为true的时候，录制控制参数才生效。
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 设置是否禁用录制的全局控制参数。一般与`StreamControls`参数配合使用。
        /// 
        /// true - 所有流都不录制。
        /// false - 所有流都录制。默认为false。
        /// 
        /// 这里的设置对所有流都生效，如果同时在 `StreamControls` 列表中针对指定流设置了控制参数，则优先采用`StreamControls`中设置的控制参数。
        /// </summary>
        [JsonProperty("DisableRecord")]
        public bool? DisableRecord{ get; set; }

        /// <summary>
        /// 设置是否禁用所有流的音频录制的全局控制参数。一般与`StreamControls`参数配合使用。
        /// 
        /// true - 所有流的录制都不对音频进行录制。
        /// false - 所有流的录制都需要对音频进行录制。默认为false。
        /// 
        /// 这里的设置对所有流都生效，如果同时在 `StreamControls` 列表中针对指定流设置了控制参数，则优先采用`StreamControls`中设置的控制参数。
        /// </summary>
        [JsonProperty("DisableAudio")]
        public bool? DisableAudio{ get; set; }

        /// <summary>
        /// 设置是否所有流都只录制小画面的全局控制参数。一般与`StreamControls`参数配合使用。
        /// 
        /// true - 所有流都只录制小画面。设置为true时，请确保上行端在推流的时候同时上行了小画面，否则录制视频可能是黑屏。
        /// false - 所有流都录制大画面，默认为false。
        /// 
        /// 这里的设置对所有流都生效，如果同时在 `StreamControls` 列表中针对指定流设置了控制参数，则优先采用`StreamControls`中设置的控制参数。
        /// </summary>
        [JsonProperty("PullSmallVideo")]
        public bool? PullSmallVideo{ get; set; }

        /// <summary>
        /// 针对具体流指定控制参数，如果列表为空，则所有流采用全局配置的控制参数进行录制。列表不为空，则列表中指定的流将优先按此列表指定的控制参数进行录制。
        /// </summary>
        [JsonProperty("StreamControls")]
        public StreamControl[] StreamControls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamSimple(map, prefix + "DisableAudio", this.DisableAudio);
            this.SetParamSimple(map, prefix + "PullSmallVideo", this.PullSmallVideo);
            this.SetParamArrayObj(map, prefix + "StreamControls.", this.StreamControls);
        }
    }
}

