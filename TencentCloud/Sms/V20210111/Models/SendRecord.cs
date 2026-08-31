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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>下发的手机号码，依据 E.164 标准为：+[国家（或地区）码][手机号] ，示例如：+8613601238015， 其中前面有一个+号 ，86为国家码，13601238015为手机号。</p>
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// <p>发送流水号，与短信发送接口返回的发送流水号一致。</p>
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// <p>发送状态。</p><p>枚举值：</p><ul><li>1： 提交失败</li><li>2： 提交成功，送达成功</li><li>3： 提交成功，发送中</li><li>4： 提交成功，送达失败</li></ul>
        /// </summary>
        [JsonProperty("SendStatus")]
        public ulong? SendStatus{ get; set; }

        /// <summary>
        /// <p>请求状态码，可参考 <a href="https://cloud.tencent.com/document/api/382/59177#.E7.9F.AD.E4.BF.A1-API-3.0-.E5.8F.91.E9.80.81.E9.94.99.E8.AF.AF.E7.A0.81">短信 API 3.0 发送错误码</a>。</p>
        /// </summary>
        [JsonProperty("RequestCode")]
        public string RequestCode{ get; set; }

        /// <summary>
        /// <p>回执状态码，仅发送状态为 2（提交成功，送达成功）和 4（提交成功，送达失败）时有值，其余状态为空字符串，可参考 <a href="https://cloud.tencent.com/document/product/382/59177#.E5.9B.9E.E6.89.A7.E7.8A.B6.E6.80.81.E9.94.99.E8.AF.AF.E7.A0.81">回执状态错误码</a>。</p>
        /// </summary>
        [JsonProperty("StatusCode")]
        public string StatusCode{ get; set; }

        /// <summary>
        /// <p>国家码或地区码，例如 CN、US 等，对于未识别出国家码或者地区码，默认返回 DEF，具体支持列表请参考 <a href="https://cloud.tencent.com/document/product/382/18051#402a55da-83ac-4e79-a604-b9de0c507756">国际/港澳台短信价格总览</a>。</p>
        /// </summary>
        [JsonProperty("IsoCode")]
        public string IsoCode{ get; set; }

        /// <summary>
        /// <p>短信下发内容，为保证信息安全，短信中的部分入参信息会脱敏存储，对应发送记录查询结果中包含的打码内容，用户实际接收到的短信内容为正常完整内容。有疑问可咨询 <a href="https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81">腾讯云小助手</a> 。</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>发送时间，UNIX 时间戳（秒）。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("SendTime")]
        public ulong? SendTime{ get; set; }

        /// <summary>
        /// <p>用户实际收到短信的时间，UNIX 时间戳（秒），仅发送状态为2（提交成功，送达成功）时有值 ，其余状态默认为 0 。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("UserReceiveTime")]
        public ulong? UserReceiveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "SendStatus", this.SendStatus);
            this.SetParamSimple(map, prefix + "RequestCode", this.RequestCode);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "IsoCode", this.IsoCode);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "SendTime", this.SendTime);
            this.SetParamSimple(map, prefix + "UserReceiveTime", this.UserReceiveTime);
        }
    }
}

