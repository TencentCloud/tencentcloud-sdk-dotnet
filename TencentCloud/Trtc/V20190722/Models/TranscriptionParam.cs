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

    public class TranscriptionParam : AbstractModel
    {
        
        /// <summary>
        /// 转录服务在TRTC房间使用的[UserId](https://cloud.tencent.com/document/product/647/46351#userid)，注意这个userId不能与其他TRTC或者转录服务等已经使用的UserId重复，建议可以把房间ID作为userId的标识的一部分。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 转录服务加入TRTC房间的用户签名，当前 UserId 对应的验证签名，相当于登录密码，具体计算方法请参考TRTC计算[UserSig](https://cloud.tencent.com/document/product/647/45910#UserSig)的方案。
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// 转录用户白名单，开始服务时，为空或不填表示转录所有主播音频，填具体值表示转录指定主播音频。
        /// 使用黑白名单时，同一个用户同时在黑白名单时，以黑名单为主。
        /// </summary>
        [JsonProperty("SubscribeList")]
        public TranscriptionUserInfoParams[] SubscribeList{ get; set; }

        /// <summary>
        /// 转录用户黑名单，为空或不填表示无黑名单，填具体值表示不转录指定主播音频。
        /// 同一个用户同时在黑白名单时，以黑名单为主。
        /// </summary>
        [JsonProperty("UnSubscribeList")]
        public TranscriptionUserInfoParams[] UnSubscribeList{ get; set; }

        /// <summary>
        /// 所有参与转录的主播持续离开TRTC房间或切换成观众超过MaxIdleTime的时长，自动停止转录任务，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于 86400秒(24小时)。
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 自定义通道：支持自定义信息，只可以填0-2， 0表示不开启自定义通道，1表示开启自定义数据，2表示开启自定义消息。不填默认不开启自定义通道。注意：填1自定义数据只对 SDK版本 >= 5.15.0生效。
        /// </summary>
        [JsonProperty("SendCustomMode")]
        public ulong? SendCustomMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamArrayObj(map, prefix + "SubscribeList.", this.SubscribeList);
            this.SetParamArrayObj(map, prefix + "UnSubscribeList.", this.UnSubscribeList);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "SendCustomMode", this.SendCustomMode);
        }
    }
}

