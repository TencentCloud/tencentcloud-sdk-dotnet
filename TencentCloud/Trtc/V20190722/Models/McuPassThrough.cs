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

    public class McuPassThrough : AbstractModel
    {
        
        /// <summary>
        /// 透传SEI的payload内容。
        /// </summary>
        [JsonProperty("PayloadContent")]
        public string PayloadContent{ get; set; }

        /// <summary>
        /// SEI消息的payload_type，取值范围5、100-254（244除外，244为我们内部自定义的时间戳SEI）。
        /// </summary>
        [JsonProperty("PayloadType")]
        public ulong? PayloadType{ get; set; }

        /// <summary>
        /// PayloadType为5，PayloadUuid必须填写。PayloadType不是5时，不需要填写，填写会被后台忽略。该值必须是32长度的十六进制。
        /// </summary>
        [JsonProperty("PayloadUuid")]
        public string PayloadUuid{ get; set; }

        /// <summary>
        /// SEI发送间隔，单位毫秒，默认值为1000。
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 取值范围[0,1]，填1：发送关键帧时会确保带SEI；填0：发送关键帧时不确保带SEI。默认值为0。
        /// </summary>
        [JsonProperty("FollowIdr")]
        public ulong? FollowIdr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayloadContent", this.PayloadContent);
            this.SetParamSimple(map, prefix + "PayloadType", this.PayloadType);
            this.SetParamSimple(map, prefix + "PayloadUuid", this.PayloadUuid);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "FollowIdr", this.FollowIdr);
        }
    }
}

