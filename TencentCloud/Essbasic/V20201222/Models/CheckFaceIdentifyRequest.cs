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

    public class CheckFaceIdentifyRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息; 必选
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 人脸核身渠道; 必选; WEIXINAPP:腾讯电子签小程序,FACEID:腾讯电子签慧眼,None:白名单中的客户直接通过
        /// </summary>
        [JsonProperty("VerifyChannel")]
        public string VerifyChannel{ get; set; }

        /// <summary>
        /// 核身订单号; 必选; 对于WEIXINAPP,直接取响应的{VerifyResult};对于FACEID,使用{WbAppId}:{OrderNo}拼接
        /// </summary>
        [JsonProperty("VerifyResult")]
        public string VerifyResult{ get; set; }

        /// <summary>
        /// 要对比的姓名; 可选; 未填写时对比caller.OperatorId的实名信息
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 要对比的身份证号码; 可选; 未填写时对比caller.OperatorId的实名信息
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 是否取认证时的照片
        /// </summary>
        [JsonProperty("GetPhoto")]
        public bool? GetPhoto{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "VerifyChannel", this.VerifyChannel);
            this.SetParamSimple(map, prefix + "VerifyResult", this.VerifyResult);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "GetPhoto", this.GetPhoto);
        }
    }
}

