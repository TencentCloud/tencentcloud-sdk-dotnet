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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendEmailRequest : AbstractModel
    {
        
        /// <summary>
        /// 发信邮件地址。请填写发件人邮箱地址，例如：noreply@mail.qcloud.com
        /// 如需填写发件人说明，请按照如下方式： 
        /// 别名 <邮箱地址>
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// 收信人邮箱地址，最多支持群发50人。注意：邮件内容会显示所有收件人地址，非群发邮件请多次调用API发送。
        /// </summary>
        [JsonProperty("Destination")]
        public string[] Destination{ get; set; }

        /// <summary>
        /// 邮件主题
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// 邮件的“回复”电子邮件地址。可以填写您能收到邮件的邮箱地址，可以是个人邮箱。如果不填，收件人将会回复到腾讯云。
        /// </summary>
        [JsonProperty("ReplyToAddresses")]
        public string ReplyToAddresses{ get; set; }

        /// <summary>
        /// 使用模板发送时，填写的模板相关参数
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// 使用API直接发送内容时，填写的邮件内容
        /// </summary>
        [JsonProperty("Simple")]
        public Simple Simple{ get; set; }

        /// <summary>
        /// 需要发送附件时，填写附件相关参数。
        /// </summary>
        [JsonProperty("Attachments")]
        public Attachment[] Attachments{ get; set; }

        /// <summary>
        /// 退订选项 1: 加入退订链接 0: 不加入退订链接
        /// </summary>
        [JsonProperty("Unsubscribe")]
        public string Unsubscribe{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamArraySimple(map, prefix + "Destination.", this.Destination);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "ReplyToAddresses", this.ReplyToAddresses);
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamObj(map, prefix + "Simple.", this.Simple);
            this.SetParamArrayObj(map, prefix + "Attachments.", this.Attachments);
            this.SetParamSimple(map, prefix + "Unsubscribe", this.Unsubscribe);
        }
    }
}

