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

    public class TranscriptionParams : AbstractModel
    {
        
        /// <summary>
        /// 转录机器人的UserId，用于进房发起转录任务。【注意】这个UserId不能与当前房间内的主播观众[UserId](https://cloud.tencent.com/document/product/647/46351#userid)重复。如果一个房间发起多个转录任务时，机器人的userid也不能相互重复，否则会中断前一个任务。需要保证转录机器人UserId在房间内唯一。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 转录机器人UserId对应的校验签名，即UserId和UserSig相当于转录机器人进房的登录密码，具体计算方法请参考TRTC计算[UserSig](https://cloud.tencent.com/document/product/647/45910#UserSig)的方案。
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// IM[管理员账户](
        /// https://cloud.tencent.com/document/product/269/31999#app-.E7.AE.A1.E7.90.86.E5.91.98)，如果填写，后台下发消息会使用IM通道，而不是TRTC自定义消息。
        /// </summary>
        [JsonProperty("IMAdminUserId")]
        [System.Obsolete]
        public string IMAdminUserId{ get; set; }

        /// <summary>
        /// IM管理员账户生成的签名，用于向特定群组发送消息。如果填写，后台下发消息会使用IM通道，而不是TRTC自定义消息。必须和IM管理员的UserId一起填写。
        /// </summary>
        [JsonProperty("IMAdminUserSig")]
        [System.Obsolete]
        public string IMAdminUserSig{ get; set; }

        /// <summary>
        /// 房间内推流用户全部退出后超过MaxIdleTime秒，后台自动关闭转录任务，默认值是60s。
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 1表示机器人只订阅单个人的流，0表示机器人订阅整个房间的流，如果不填默认订阅整个房间的流。
        /// </summary>
        [JsonProperty("TranscriptionMode")]
        public ulong? TranscriptionMode{ get; set; }

        /// <summary>
        /// TranscriptionMode为1时必填，机器人只会拉该userid的流，忽略房间里其他用户。
        /// </summary>
        [JsonProperty("TargetUserId")]
        public string TargetUserId{ get; set; }

        /// <summary>
        /// 机器人订阅的用户列表
        /// 仅 TranscriptionMode 为 1或者 TranscriptionMode 为无限上麦模式支持传入多个用户列表
        /// </summary>
        [JsonProperty("TargetUserIdList")]
        public string[] TargetUserIdList{ get; set; }

        /// <summary>
        /// 声纹配置
        /// </summary>
        [JsonProperty("VoicePrint")]
        public VoicePrint VoicePrint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamSimple(map, prefix + "IMAdminUserId", this.IMAdminUserId);
            this.SetParamSimple(map, prefix + "IMAdminUserSig", this.IMAdminUserSig);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "TranscriptionMode", this.TranscriptionMode);
            this.SetParamSimple(map, prefix + "TargetUserId", this.TargetUserId);
            this.SetParamArraySimple(map, prefix + "TargetUserIdList.", this.TargetUserIdList);
            this.SetParamObj(map, prefix + "VoicePrint.", this.VoicePrint);
        }
    }
}

