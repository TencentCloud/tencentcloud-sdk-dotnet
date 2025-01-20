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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentConfig : AbstractModel
    {
        
        /// <summary>
        /// 机器人的UserId，用于进房发起任务。【注意】这个UserId不能与当前房间内的主播观众[UserId](https://cloud.tencent.com/document/product/647/46351#userid)重复。如果一个房间发起多个任务时，机器人的UserId也不能相互重复，否则会中断前一个任务。需要保证机器人UserId在房间内唯一。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 机器人UserId对应的校验签名，即UserId和UserSig相当于机器人进房的登录密码，具体计算方法请参考TRTC计算[UserSig](https://cloud.tencent.com/document/product/647/45910#UserSig)的方案。
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// 机器人拉流的UserId, 填写后，机器人会拉取该UserId的流进行实时处理
        /// </summary>
        [JsonProperty("TargetUserId")]
        public string TargetUserId{ get; set; }

        /// <summary>
        /// 房间内超过MaxIdleTime 没有推流，后台自动关闭任务，默认值是60s。
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 机器人的欢迎语
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }

        /// <summary>
        /// 智能打断模式，默认为0，0表示服务端自动打断，1表示服务端不打断，由端上发送打断信令进行打断
        /// </summary>
        [JsonProperty("InterruptMode")]
        public ulong? InterruptMode{ get; set; }

        /// <summary>
        /// InterruptMode为0时使用，单位为毫秒，默认为500ms。表示服务端检测到持续InterruptSpeechDuration毫秒的人声则进行打断。
        /// </summary>
        [JsonProperty("InterruptSpeechDuration")]
        public ulong? InterruptSpeechDuration{ get; set; }

        /// <summary>
        /// 控制新一轮对话的触发方式，默认为0。
        /// - 0表示当服务端语音识别检测出的完整一句话后，自动触发一轮新的对话。
        /// - 1表示客户端在收到字幕消息后，自行决定是否手动发送聊天信令触发一轮新的对话。
        /// </summary>
        [JsonProperty("TurnDetectionMode")]
        public ulong? TurnDetectionMode{ get; set; }

        /// <summary>
        /// 是否过滤掉用户只说了一个字的句子，true表示过滤，false表示不过滤，默认值为true
        /// </summary>
        [JsonProperty("FilterOneWord")]
        public bool? FilterOneWord{ get; set; }

        /// <summary>
        /// 欢迎消息优先级，0默认，1高优，高优不能被打断。
        /// </summary>
        [JsonProperty("WelcomeMessagePriority")]
        public ulong? WelcomeMessagePriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamSimple(map, prefix + "TargetUserId", this.TargetUserId);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamSimple(map, prefix + "InterruptSpeechDuration", this.InterruptSpeechDuration);
            this.SetParamSimple(map, prefix + "TurnDetectionMode", this.TurnDetectionMode);
            this.SetParamSimple(map, prefix + "FilterOneWord", this.FilterOneWord);
            this.SetParamSimple(map, prefix + "WelcomeMessagePriority", this.WelcomeMessagePriority);
        }
    }
}

