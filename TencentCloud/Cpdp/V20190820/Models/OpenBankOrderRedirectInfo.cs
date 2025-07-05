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

    public class OpenBankOrderRedirectInfo : AbstractModel
    {
        
        /// <summary>
        /// 生成二维码，引导用户扫码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QRCodeUrl")]
        public string QRCodeUrl{ get; set; }

        /// <summary>
        /// 二维码凭证
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QRCodeKey")]
        public string QRCodeKey{ get; set; }

        /// <summary>
        /// 跳转 URL,用于客户端跳转，订单未支付时返回该参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 跳转凭证过期时间,yyyy-MM-dd HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 小程序 appid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MpAppId")]
        public string MpAppId{ get; set; }

        /// <summary>
        /// 小程序路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MpPath")]
        public string MpPath{ get; set; }

        /// <summary>
        /// 小程序原始 id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MpUserName")]
        public string MpUserName{ get; set; }

        /// <summary>
        /// 网银支付提交页面信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FormInfo")]
        public OpenBankFormInfo FormInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QRCodeUrl", this.QRCodeUrl);
            this.SetParamSimple(map, prefix + "QRCodeKey", this.QRCodeKey);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "MpAppId", this.MpAppId);
            this.SetParamSimple(map, prefix + "MpPath", this.MpPath);
            this.SetParamSimple(map, prefix + "MpUserName", this.MpUserName);
            this.SetParamObj(map, prefix + "FormInfo.", this.FormInfo);
        }
    }
}

