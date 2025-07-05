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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateH5FaceIdUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息; 必选
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 慧眼业务ID; 不填写时后台使用Caller反查
        /// </summary>
        [JsonProperty("WbAppId")]
        public string WbAppId{ get; set; }

        /// <summary>
        /// 姓名; 可选(未通过实名认证的用户必选)
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户证件类型; 可选; 默认ID_CARD:中国居民身份证
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 用户证件号; 可选(未通过实名认证的用户必选)
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// H5人脸核身完成后回调的第三方Url; 可选; 不需要做Encode, 跳转的参数: ?code=XX&orderNo=XX&liveRate=xx, code=0表示成功,orderNo为订单号,liveRate为百分制活体检测得分
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 参数值为"1":直接跳转到url回调地址; 可选; 其他值:跳转提供的结果页面
        /// </summary>
        [JsonProperty("JumpType")]
        public string JumpType{ get; set; }

        /// <summary>
        /// browser:表示在浏览器启动刷脸, app:表示在App里启动刷脸,默认值为browser; 可选
        /// </summary>
        [JsonProperty("OpenFrom")]
        public string OpenFrom{ get; set; }

        /// <summary>
        /// 跳转类型; 可选; 参数值为"1"时,刷脸页面使用replace方式跳转,不在浏览器history中留下记录;不传或其他值则正常跳转
        /// </summary>
        [JsonProperty("RedirectType")]
        public string RedirectType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "WbAppId", this.WbAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "JumpType", this.JumpType);
            this.SetParamSimple(map, prefix + "OpenFrom", this.OpenFrom);
            this.SetParamSimple(map, prefix + "RedirectType", this.RedirectType);
        }
    }
}

