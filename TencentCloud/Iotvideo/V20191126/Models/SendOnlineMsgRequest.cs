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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendOnlineMsgRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备TID
        /// </summary>
        [JsonProperty("Tid")]
        public string Tid{ get; set; }

        /// <summary>
        /// 如果设备处于休眠状态，是否唤醒设备
        /// </summary>
        [JsonProperty("Wakeup")]
        public bool? Wakeup{ get; set; }

        /// <summary>
        /// 等待回应类型
        /// 0：不等待设备回应直接响应请求;
        /// 1：要求设备确认消息已接收,或等待超时后返回;
        /// 2：要求设备进行响应处理,收到设备的响应数据后,将设备响应数据回应给请求方;
        /// </summary>
        [JsonProperty("WaitResp")]
        public ulong? WaitResp{ get; set; }

        /// <summary>
        /// 消息主题
        /// </summary>
        [JsonProperty("MsgTopic")]
        public string MsgTopic{ get; set; }

        /// <summary>
        /// 消息内容，最大长度不超过8k字节
        /// </summary>
        [JsonProperty("MsgContent")]
        public string MsgContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tid", this.Tid);
            this.SetParamSimple(map, prefix + "Wakeup", this.Wakeup);
            this.SetParamSimple(map, prefix + "WaitResp", this.WaitResp);
            this.SetParamSimple(map, prefix + "MsgTopic", this.MsgTopic);
            this.SetParamSimple(map, prefix + "MsgContent", this.MsgContent);
        }
    }
}

