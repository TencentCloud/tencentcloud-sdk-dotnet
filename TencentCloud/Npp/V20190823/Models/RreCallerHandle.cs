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

namespace TencentCloud.Npp.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RreCallerHandle : AbstractModel
    {
        
        /// <summary>
        /// 呼叫主叫以后，给主叫用户的语音提示，播放该提示时用户所有按键无效
        /// </summary>
        [JsonProperty("ReadPrompt")]
        public string ReadPrompt{ get; set; }

        /// <summary>
        /// 可中断提示，播放该提示时，用户可以按键
        /// </summary>
        [JsonProperty("InterruptPrompt")]
        public string InterruptPrompt{ get; set; }

        /// <summary>
        /// 对应按键操作,如果没有结构体里定义按键操作用户按键以后都从 interruptPrompt 重新播放
        /// </summary>
        [JsonProperty("KeyList")]
        public KeyList[] KeyList{ get; set; }

        /// <summary>
        /// 最多重复播放次数，超过该次数拆线
        /// </summary>
        [JsonProperty("RepeatTimes")]
        public string RepeatTimes{ get; set; }

        /// <summary>
        /// 用户按键回调通知地址，如果为空不回调
        /// </summary>
        [JsonProperty("KeyPressUrl")]
        public string KeyPressUrl{ get; set; }

        /// <summary>
        /// 提示音男声女声：1女声，2男声。默认女声
        /// </summary>
        [JsonProperty("PromptGender")]
        public string PromptGender{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReadPrompt", this.ReadPrompt);
            this.SetParamSimple(map, prefix + "InterruptPrompt", this.InterruptPrompt);
            this.SetParamArrayObj(map, prefix + "KeyList.", this.KeyList);
            this.SetParamSimple(map, prefix + "RepeatTimes", this.RepeatTimes);
            this.SetParamSimple(map, prefix + "KeyPressUrl", this.KeyPressUrl);
            this.SetParamSimple(map, prefix + "PromptGender", this.PromptGender);
        }
    }
}

