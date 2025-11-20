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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TalkBasicConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 系统提示词
        /// </summary>
        [JsonProperty("SystemPrompt")]
        public string SystemPrompt{ get; set; }

        /// <summary>
        /// 欢迎语，支持多个欢迎语随机切换，格式：字符串数组，JSON字符串。
        /// </summary>
        [JsonProperty("GreetingMessage")]
        public string GreetingMessage{ get; set; }

        /// <summary>
        /// 音色，支持的音色列表：100510000-阅读男声智逍遥；101001-情感女声智瑜；101002-通用女声智聆；101003-客服女声智美；101004-通用男声智云；101005-通用女声智莉；101006-助手女声智言；101008-客服女声智琪；101009-知性女声智芸；101010-通用男声智华；101011-新闻女声智燕；101012-新闻女声智丹；101013-新闻男声智辉；101014 -新闻男声智宁；101015-男童声智萌；101016-女童声智甜；101017-情感女声智蓉；101018-情感男声智靖；101019-粤语女声智彤。
        /// </summary>
        [JsonProperty("DefaultVoiceType")]
        public long? DefaultVoiceType{ get; set; }

        /// <summary>
        /// 复刻音色ID，当不为空时，DefaultVoiceType为200000000
        /// </summary>
        [JsonProperty("FastVoiceType")]
        public string FastVoiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SystemPrompt", this.SystemPrompt);
            this.SetParamSimple(map, prefix + "GreetingMessage", this.GreetingMessage);
            this.SetParamSimple(map, prefix + "DefaultVoiceType", this.DefaultVoiceType);
            this.SetParamSimple(map, prefix + "FastVoiceType", this.FastVoiceType);
        }
    }
}

