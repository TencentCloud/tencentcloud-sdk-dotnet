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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendEmailStatus : AbstractModel
    {
        
        /// <summary>
        /// SendEmail返回的MessageId
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// 收件人邮箱
        /// </summary>
        [JsonProperty("ToEmailAddress")]
        public string ToEmailAddress{ get; set; }

        /// <summary>
        /// 发件人邮箱
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// 腾讯云处理状态
        /// 0: 处理成功
        /// 1001: 内部系统异常
        /// 1002: 内部系统异常
        /// 1003: 内部系统异常
        /// 1003: 内部系统异常
        /// 1004: 发信超时
        /// 1005: 内部系统异常
        /// 1006: 触发频率控制，短时间内对同一地址发送过多邮件
        /// 1007: 邮件地址在黑名单中
        /// 1008: 域名被收件人拒收
        /// 1009: 内部系统异常
        /// 1010: 超出了每日发送限制
        /// 1011: 无发送自定义内容权限，必须使用模板
        /// 1013: 域名被收件人取消订阅
        /// 2001: 找不到相关记录
        /// 3007: 模板ID无效或者不可用
        /// 3008: 被收信域名临时封禁
        /// 3009: 无权限使用该模板
        /// 3010: TemplateData字段格式不正确 
        /// 3014: 发件域名没有经过认证，无法发送
        /// 3020: 收件方邮箱类型在黑名单
        /// 3024: 邮箱地址格式预检查失败
        /// 3030: 退信率过高，临时限制发送
        /// 3033: 余额不足，账号欠费等
        /// </summary>
        [JsonProperty("SendStatus")]
        public long? SendStatus{ get; set; }

        /// <summary>
        /// 收件方处理状态
        /// 0: 请求成功被腾讯云接受，进入发送队列
        /// 1: 邮件递送成功，DeliverTime表示递送成功的时间
        /// 2: 邮件因某种原因被丢弃，DeliverMessage表示丢弃原因
        /// 3: 收件方ESP拒信，一般原因为邮箱地址不存在，或其它原因
        /// 8: 邮件被ESP因某些原因延迟递送，DeliverMessage表示延迟原因
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public long? DeliverStatus{ get; set; }

        /// <summary>
        /// 收件方处理状态描述
        /// </summary>
        [JsonProperty("DeliverMessage")]
        public string DeliverMessage{ get; set; }

        /// <summary>
        /// 请求到达腾讯云时间戳
        /// </summary>
        [JsonProperty("RequestTime")]
        public long? RequestTime{ get; set; }

        /// <summary>
        /// 腾讯云执行递送时间戳
        /// </summary>
        [JsonProperty("DeliverTime")]
        public long? DeliverTime{ get; set; }

        /// <summary>
        /// 用户是否打开该邮件
        /// </summary>
        [JsonProperty("UserOpened")]
        public bool? UserOpened{ get; set; }

        /// <summary>
        /// 用户是否点击该邮件中的链接
        /// </summary>
        [JsonProperty("UserClicked")]
        public bool? UserClicked{ get; set; }

        /// <summary>
        /// 用户是否取消该发送者的订阅
        /// </summary>
        [JsonProperty("UserUnsubscribed")]
        public bool? UserUnsubscribed{ get; set; }

        /// <summary>
        /// 用户是否举报该发送者
        /// </summary>
        [JsonProperty("UserComplainted")]
        public bool? UserComplainted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "ToEmailAddress", this.ToEmailAddress);
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamSimple(map, prefix + "SendStatus", this.SendStatus);
            this.SetParamSimple(map, prefix + "DeliverStatus", this.DeliverStatus);
            this.SetParamSimple(map, prefix + "DeliverMessage", this.DeliverMessage);
            this.SetParamSimple(map, prefix + "RequestTime", this.RequestTime);
            this.SetParamSimple(map, prefix + "DeliverTime", this.DeliverTime);
            this.SetParamSimple(map, prefix + "UserOpened", this.UserOpened);
            this.SetParamSimple(map, prefix + "UserClicked", this.UserClicked);
            this.SetParamSimple(map, prefix + "UserUnsubscribed", this.UserUnsubscribed);
            this.SetParamSimple(map, prefix + "UserComplainted", this.UserComplainted);
        }
    }
}

