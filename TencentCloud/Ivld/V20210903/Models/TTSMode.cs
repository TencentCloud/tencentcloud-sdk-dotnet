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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TTSMode : AbstractModel
    {
        
        /// <summary>
        /// 语速，范围：[-2，2]，分别对应不同语速：
        /// -2代表0.6倍
        /// -1代表0.8倍
        /// 0代表1.0倍（默认）
        /// 1代表1.2倍
        /// 2代表1.5倍
        /// 如果需要更细化的语速，可以保留小数点后 2 位，例如0.5/1.25/2.81等。
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// 音色 ID，[音色体验地址](https://cloud.tencent.com/product/tts)。
        /// 
        /// 
        /// |音乐ID|音色名称|推荐场景|
        /// |--|--|--|
        /// |1001|智瑜|情感女声|
        /// |1002|智聆|通用女声|
        /// |1003|智美|客服女声|
        /// |1004|智云|通用男声|
        /// |1005|智莉|通用女声|
        /// |1007|智娜|客服女声|
        /// |1008|智琪|客服女声|
        /// |1009|智芸|知性女声|
        /// |1010|智华|通用男声|
        /// |1017|智蓉|情感女声|
        /// |1018|智靖|情感男声|
        /// 
        /// 
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
        }
    }
}

