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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryWechatAuthResult : AbstractModel
    {
        
        /// <summary>
        /// 商户核身单号
        /// </summary>
        [JsonProperty("AuthNo")]
        public string AuthNo{ get; set; }

        /// <summary>
        /// 微信用户标识
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MchId")]
        public string MchId{ get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        [JsonProperty("SubMchId")]
        public string SubMchId{ get; set; }

        /// <summary>
        /// 核身渠道
        /// FROM_MINI_APP：来自小程序方式核身
        /// FROM_HARDWARE：来自硬件设备方式核身
        /// </summary>
        [JsonProperty("AuthScene")]
        public string AuthScene{ get; set; }

        /// <summary>
        /// 核身渠道标识
        /// 
        /// 用于定位渠道具体来源，如果是扫码打卡渠道标识就是具体的小程序appid，若是硬件设备，则是设备的序列号等
        /// </summary>
        [JsonProperty("AuthSource")]
        public string AuthSource{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 所属单位名称
        /// </summary>
        [JsonProperty("EmployerName")]
        public string EmployerName{ get; set; }

        /// <summary>
        /// 核身时间
        /// yyyy-MM-DDTHH:mm:ss+TIMEZONE
        /// 
        /// 示例值：2015-05-20T13:29:35+08:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthTime")]
        public string AuthTime{ get; set; }

        /// <summary>
        /// 核身类型
        /// 
        /// SIGN_IN：考勤、签到打卡类型
        /// INSURANCE：投保类型
        /// CONTRACT：签约类型
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 核身状态
        /// AUTHENTICATE_PROCESSING：核身中
        /// AUTHENTICATE_SUCCESS：核身成功
        /// AUTHENTICATE_FAILED：核身失败
        /// </summary>
        [JsonProperty("AuthState")]
        public string AuthState{ get; set; }

        /// <summary>
        /// 核身失败原因描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthFailReason")]
        public string AuthFailReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthNo", this.AuthNo);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "MchId", this.MchId);
            this.SetParamSimple(map, prefix + "SubMchId", this.SubMchId);
            this.SetParamSimple(map, prefix + "AuthScene", this.AuthScene);
            this.SetParamSimple(map, prefix + "AuthSource", this.AuthSource);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "EmployerName", this.EmployerName);
            this.SetParamSimple(map, prefix + "AuthTime", this.AuthTime);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AuthState", this.AuthState);
            this.SetParamSimple(map, prefix + "AuthFailReason", this.AuthFailReason);
        }
    }
}

