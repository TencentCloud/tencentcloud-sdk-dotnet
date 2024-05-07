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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NoticeReceiver : AbstractModel
    {
        
        /// <summary>
        /// 接受者类型。可选值：
        /// -  Uin - 用户ID
        /// - Group - 用户组ID
        /// 暂不支持其余接收者类型。
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// 接收者。
        /// 当ReceiverType为Uin时，ReceiverIds的值为用户id。[子用户信息查询](https://cloud.tencent.com/document/product/598/36258)
        /// 当ReceiverType为Group时，ReceiverIds的值为用户组id。[CAM用户组](https://cloud.tencent.com/document/product/598/14985)
        /// </summary>
        [JsonProperty("ReceiverIds")]
        public long?[] ReceiverIds{ get; set; }

        /// <summary>
        /// 通知接收渠道。
        /// - Email - 邮件
        /// - Sms - 短信
        /// - WeChat - 微信
        /// - Phone - 电话
        /// </summary>
        [JsonProperty("ReceiverChannels")]
        public string[] ReceiverChannels{ get; set; }

        /// <summary>
        /// 允许接收信息的开始时间。格式：`15:04:05`，必填。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 允许接收信息的结束时间。格式：`15:04:05`，必填。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 位序。
        /// 
        /// - 入参时无效。
        /// - 出参时有效。
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "ReceiverIds.", this.ReceiverIds);
            this.SetParamArraySimple(map, prefix + "ReceiverChannels.", this.ReceiverChannels);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

