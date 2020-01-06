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

    public class AudioVolumeParam : AbstractModel
    {
        
        /// <summary>
        /// 是否静音，取值范围0或1。
        /// <li>0表示不静音。</li>
        /// <li>1表示静音。</li>
        /// 默认是0。
        /// </summary>
        [JsonProperty("Mute")]
        public long? Mute{ get; set; }

        /// <summary>
        /// 音频增益，取值范围0~10。
        /// <li>大于1表示增加音量。</li>
        /// <li>小于1表示降低音量。</li>
        /// <li>0和1：表示不改变。</li>
        /// 默认是0。
        /// </summary>
        [JsonProperty("Gain")]
        public float? Gain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mute", this.Mute);
            this.SetParamSimple(map, prefix + "Gain", this.Gain);
        }
    }
}

