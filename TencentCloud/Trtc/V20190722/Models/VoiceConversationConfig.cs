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

    public class VoiceConversationConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>对话服务在TRTC房间使用的<a href="https://cloud.tencent.com/document/product/647/46351#userid">UserId</a>，注意这个userId不能与其他TRTC或者对话服务等已经使用的UserId重复，建议可以把房间ID作为userId的标识的一部分。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>对话服务加入TRTC房间的用户签名，当前 UserId 对应的验证签名，相当于登录密码，具体计算方法请参考TRTC计算<a href="https://cloud.tencent.com/document/product/647/45910#UserSig">UserSig</a>的方案。</p>
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// <p>对话服务订阅的主播名，订阅指定真实用户的音频，只能填写一个订阅主播。</p>
        /// </summary>
        [JsonProperty("TargetUserId")]
        public string[] TargetUserId{ get; set; }

        /// <summary>
        /// <p>回推机器人参数。</p>
        /// </summary>
        [JsonProperty("TTSPushRoomParams")]
        public TranscriptionUserInfoParams TTSPushRoomParams{ get; set; }

        /// <summary>
        /// <p>参与对话的主播持续离开TRTC房间或切换成观众超过MaxIdleTime的时长，自动停止对话任务，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于 86400秒(24小时)。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// <p>用于过滤LLM返回内容，不播放括号中的内容。1：中文括号（）2：英文括号() 3：中文方括号【】4：英文方括号[] 5：英文花括号{} 。默认值为空，表示不进行过滤。 示例值：1取值范围：[1, 5]。S2S 模式不支持填写该参数。</p>
        /// </summary>
        [JsonProperty("FilterBracketsContent")]
        public ulong?[] FilterBracketsContent{ get; set; }

        /// <summary>
        /// <p>字幕显示模式。S2S 模式不支持填写该参数。</p><p>枚举值：</p><ul><li>0： 尽快显示</li><li>1： 句子级别实时显示</li></ul>
        /// </summary>
        [JsonProperty("SubtitleMode")]
        public ulong? SubtitleMode{ get; set; }

        /// <summary>
        /// <p>控制新一轮对话的触发方式，默认为&quot;auto&quot;。S2S 模式不支持填写该参数。</p><p>枚举值：</p><ul><li>&quot;auto&quot;： 后台自动识别断句触发LLM(基于静音时长)</li></ul>
        /// </summary>
        [JsonProperty("TurnDetectionMode")]
        public string TurnDetectionMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamArraySimple(map, prefix + "TargetUserId.", this.TargetUserId);
            this.SetParamObj(map, prefix + "TTSPushRoomParams.", this.TTSPushRoomParams);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamArraySimple(map, prefix + "FilterBracketsContent.", this.FilterBracketsContent);
            this.SetParamSimple(map, prefix + "SubtitleMode", this.SubtitleMode);
            this.SetParamSimple(map, prefix + "TurnDetectionMode", this.TurnDetectionMode);
        }
    }
}

